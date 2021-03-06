﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using XUnitTestCommon.TestsCore;
using Newtonsoft.Json.Linq;
using XUnitTestCommon.ServiceSettings;
using Allure.Commons;
using System.Threading;
using NUnit.Framework.Internal;

namespace XUnitTestCommon.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class BaseTest
    {
        public IList<string> schemesError;
        private int stepNumber = 0;

        public static ThreadLocal<int> isStepOpened = new ThreadLocal<int>(() => { return 0; });
        public static ThreadLocal<Stack<string>> stepUID = new ThreadLocal<Stack<string>>(() => { return new Stack<string>(); });

        public static ThreadLocal<Dictionary<string, List<Attachment>>> attaches = new ThreadLocal<Dictionary<string, List<Attachment>>>(() => new Dictionary<string, List<Attachment>>());

        public static Dictionary<string, List<Response>> responses;
        private readonly List<Func<Task>> _cleanupActions = new List<Func<Task>>();
        private readonly List<Func<Task>> _oneTimeCleanupActions = new List<Func<Task>>();

        protected Allure2Report allure = new Allure2Report();

        protected static JObject cfg = NewServiceSettings.Settings();

        protected virtual void Initialize() { }

        protected void Step(string name, Action action, bool throwException = true)
        {
            Exception stepException = null;
            string guid = Guid.NewGuid().ToString();
            Console.WriteLine(name);
            isStepOpened.Value++; // need to know where attach log - in step or test
            allure.AddStep(new StepResult{status = Status.passed, name = $"{stepNumber++}: {name}" }, guid);
            stepUID.Value.Push(guid);
            try
            {
                action.Invoke();
            }
            catch (Exception e)
            {
                stepException = e;
            }
            finally
            {
                if (stepException != null)
                    allure.StopStep(stepUID.Value.Pop(), true);
                else
                    allure.StopStep(stepUID.Value.Pop(), false);
            }

            isStepOpened.Value--;

            if (throwException && stepException != null )
                throw stepException;      
        }

        #region response info
        public static void ValidateScheme(bool valid, IList<string> errors)
        {
            if (!valid)
            {
                errors.ToList().ForEach(e => Console.WriteLine(e));
                Assert.Fail("Scheme not valid");
            }
        }

        public static void AreEqualByJson(object expected, object actual, string message = "")
        {
            var expectedJson = JsonConvert.SerializeObject(expected);
            var actualJson = JsonConvert.SerializeObject(actual);
            var errorMessage = string.IsNullOrEmpty(message) ? "Objects are not equals" : message;
            Assert.That(expectedJson, Is.EqualTo(actualJson), errorMessage);
        }
        #endregion

        #region before after
        [SetUp]
        public void SetUp()
        {
            allure.AllureBeforeTest();

            responses = new Dictionary<string, List<Response>>();
            schemesError = new List<string>();
            Console.WriteLine("SetUp");
        }

        [SetUp]
        public void TestInitialize()
        {
            Console.WriteLine($"================= Test Start {TestContext.CurrentContext.Test.MethodName} ===================");
            _cleanupActions.Clear();

            try
            {
                Initialize();
            }
            catch (Exception)
            {
                CallCleanupActions();
                throw;
            }
        }

        [TearDown]
        public void TearDown()
        {  
            Console.WriteLine("TearDown");
            allure.AllureAfterTest();
        }

        [TearDown]
        public void TestCleanup()
        {
            Console.WriteLine($"=================== Test Finished {TestContext.CurrentContext.Test.MethodName} ===================");
            Console.WriteLine();

            CallCleanupActions();
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            allure.AllureBeforeAllTestsInClass(); 
        }

        [OneTimeTearDown]
        public void OneTimeCleanup()
        {
            allure.AllureAfterAllTestsInClass();
            Console.WriteLine("=============================== Final Cleanup ===============================");
            Console.WriteLine();

           // allure.CreateEnvFile();

            CallCleanupActions(true);
        }

        #endregion

        #region CleanUp Helpers

        private void CallCleanupActions(bool oneTime = false)
        {
            List<Func<Task>> cleanupActions;
            if (oneTime)
                cleanupActions = _oneTimeCleanupActions;
            else
                cleanupActions = _cleanupActions;

            cleanupActions.Reverse();
            var exceptions = new List<Exception>();
            var startedTasks = new List<Task>();

            foreach (var action in cleanupActions)
            {
                try
                {
                    startedTasks.Add(action());
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                    Console.WriteLine("Cleanup action failed: " + ex);
                }
            }

            Task.WhenAll(startedTasks).Wait();

            if (exceptions.Count == 0)
                return;

            throw new AggregateException("Multiple exceptions occurred in Cleanup. See test log for more details", exceptions);
        }

        public void AddCleanupAction(Func<Task> cleanupAction)
        {
            _cleanupActions.Add(cleanupAction);
        }

        public void AddOneTimeCleanupAction(Func<Task> cleanupAction)
        {
            _oneTimeCleanupActions.Add(cleanupAction);
        }
        #endregion
    }

    [SetUpFixture]
    public class HelperClass
    {
        [OneTimeTearDown]
        public void AfterTests()
        {
            var context = TestContext.CurrentContext;
            Environment.SetEnvironmentVariable("failedTests", context.Result.FailCount.ToString());
            Environment.SetEnvironmentVariable("passedTests", context.Result.PassCount.ToString());
            Environment.SetEnvironmentVariable("skippedTests", context.Result.SkipCount.ToString());
        }
    }
}
