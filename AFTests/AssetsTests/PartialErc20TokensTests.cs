﻿using System;
using System.Net;
using System.Threading.Tasks;
using NUnit.Framework;
using RestSharp;
using XUnitTestCommon;
using XUnitTestCommon.Utils;

namespace AFTests.AssetsTests
{
    [Category("FullRegression")]
    [Category("AssetsService")]
    public partial class AssetsTest
    {
        [Test]
        [Category("Smoke")]
        [Category("Erc20Tokens")]
        [Category("Erc20TokensGetAll")]
        public async Task GetAllErc20Tokens()
        {
            var url = ApiPaths.ERC20TOKENS_BASE_PATH;
            var response = await this.Consumer.ExecuteRequest(url, Helpers.EmptyDictionary, null, Method.GET);

            Assert.True(response.Status == HttpStatusCode.OK);
            Assert.NotNull(response.ResponseJson);
        }

        [Test]
        [Category("Smoke")]
        [Category("Erc20Tokens")]
        [Category("Erc20TokensGetAllWithAssets")]
        public async Task GetAllErc20TokensWithAssets()
        {
            var url = $"{ApiPaths.ERC20TOKENS_BASE_PATH}/with-assets";
            var response = await this.Consumer.ExecuteRequest(url, Helpers.EmptyDictionary, null, Method.GET);

            Assert.True(response.Status == HttpStatusCode.OK);
            Assert.NotNull(response.ResponseJson);
        }

        [Test]
        [Category("Smoke")]
        [Category("Erc20Tokens")]
        [Category("Erc20TokensGetByAddress")]
        public async Task GetErc20TokenByAddress()
        {
            var address = "0x+fake010447"; //TODO: Check if we should put this in constants
            var url = $"{ApiPaths.ERC20TOKENS_BASE_PATH}/{address}";

            var response = await this.Consumer.ExecuteRequest(url, Helpers.EmptyDictionary, null, Method.GET);

            Assert.True(response.Status == HttpStatusCode.OK);
            Assert.NotNull(response.ResponseJson);
        }

        [Test]
        [Category("Smoke")]
        [Category("Erc20Tokens")]
        [Category("Erc20TokensGetBySpecification")]
        public async Task GetErc20TokensBySpecifications()
        {
            var url = $"{ApiPaths.ERC20TOKENS_BASE_PATH}/__specification";
            var body = new 
            {
                Ids = new string[] { "a53c1e38-9128-416f-b976-19996abfc4dd", "0802abbd-da3b-42fe-93bb-83aec041997a" } //TODO: Check if we should put this in constants
            };

            var response = await this.Consumer.ExecuteRequest(url, Helpers.EmptyDictionary, JsonUtils.SerializeObject(body), Method.POST);

            Assert.True(response.Status == HttpStatusCode.OK);
            Assert.NotNull(response.ResponseJson);
        }
    }
}