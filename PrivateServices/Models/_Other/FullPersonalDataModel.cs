// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Linq;
    using XUnitTestCommon.TestsData;

    public partial class FullPersonalDataModel
    {
        /// <summary>
        /// Initializes a new instance of the FullPersonalDataModel class.
        /// </summary>
        public FullPersonalDataModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FullPersonalDataModel class.
        /// </summary>
        public FullPersonalDataModel(string passwordHint = default(string), System.DateTime? regitered = default(System.DateTime?), string id = default(string), string email = default(string), string fullName = default(string), string firstName = default(string), string lastName = default(string), System.DateTime? dateOfBirth = default(System.DateTime?), System.DateTime? dateOfExpiryOfID = default(System.DateTime?), string countryFromID = default(string), string country = default(string), string countryFromPOA = default(string), string zip = default(string), string city = default(string), string address = default(string), string contactPhone = default(string), string referralCode = default(string), string spotRegulator = default(string), string marginRegulator = default(string), string paymentSystem = default(string), string isp = default(string), System.DateTime? dateOfPoaDocument = default(System.DateTime?), string avatar = default(string), string website = default(string), string shortBio = default(string), string facebook = default(string), string twitter = default(string), string github = default(string))
        {
            PasswordHint = passwordHint;
            Regitered = regitered;
            Id = id;
            Email = email;
            FullName = fullName;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            DateOfExpiryOfID = dateOfExpiryOfID;
            CountryFromID = countryFromID;
            Country = country;
            CountryFromPOA = countryFromPOA;
            Zip = zip;
            City = city;
            Address = address;
            ContactPhone = contactPhone;
            ReferralCode = referralCode;
            SpotRegulator = spotRegulator;
            MarginRegulator = marginRegulator;
            PaymentSystem = paymentSystem;
            Isp = isp;
            DateOfPoaDocument = dateOfPoaDocument;
            Avatar = avatar;
            Website = website;
            ShortBio = shortBio;
            Facebook = facebook;
            Twitter = twitter;
            Github = github;
            CustomInit();
        }

        public FullPersonalDataModel Init()
        {   
            PasswordHint = TestData.GenerateString(5);
            Regitered = DateTime.Now.AddDays(-3).ToUniversalTime();
            Id = TestData.GenerateString(20);
            Email = TestData.GenerateEmail();
            FullName = TestData.FullName();
            FirstName = FullName.Split(' ')[0];
            LastName = FullName.Split(' ')[1];
            DateOfBirth = Regitered.Value.AddYears(-30).AddMonths(-5).AddDays(-3);
            DateOfExpiryOfID = Regitered.Value.AddYears(+3);
            CountryFromID = "USA";
            Country = "USA";
            CountryFromPOA = "USA";
            Zip = "12345";
            City = "LA";
            Address = "1A Avenuu";
            ContactPhone = TestData.GeneratePhone();
            ReferralCode = "15987423";
            SpotRegulator = "Autotest Spot Regulator";
            MarginRegulator = "Autotest Margin Regulator";
            PaymentSystem = "PayPal";
            Isp = "Autotest ISP";
            DateOfPoaDocument = Regitered.Value.AddDays(+2);
            Avatar = null;
            Website = "https://lykke.com";
            ShortBio = "Autotest Short bio";
            Facebook = "Autotest Facebook bio";
            Twitter = "Autotest twitter";
            Github = "Autotest github";
            return this;
        }

        public PersonalDataModel PersonalDataModel()
        {
            var pdm = new PersonalDataModel()
            {
                Regitered = Regitered,
                Id = Id,
                Email = Email,
                FullName = FullName,
                FirstName = FirstName,
                LastName = LastName,
                DateOfBirth = DateOfBirth,
                DateOfExpiryOfID = DateOfExpiryOfID,
                CountryFromID = CountryFromID,
                Country = Country,
                CountryFromPOA = CountryFromPOA,
                Zip = Zip,
                City = City,
                Address = Address,
                ContactPhone = ContactPhone,
                ReferralCode = ReferralCode,
                SpotRegulator = SpotRegulator,
                MarginRegulator = MarginRegulator,
                PaymentSystem = PaymentSystem,
                Isp = Isp,
                DateOfPoaDocument = DateOfPoaDocument,
                Avatar = Avatar,
                Website = Website,
                ShortBio = ShortBio,
                Facebook = Facebook,
                Twitter = Twitter,
                Github = Github
            };

            return pdm;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PasswordHint")]
        public string PasswordHint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Regitered")]
        public System.DateTime? Regitered { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FullName")]
        public string FullName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastName")]
        public string LastName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DateOfBirth")]
        public System.DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DateOfExpiryOfID")]
        public System.DateTime? DateOfExpiryOfID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CountryFromID")]
        public string CountryFromID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Country")]
        public string Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CountryFromPOA")]
        public string CountryFromPOA { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Zip")]
        public string Zip { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "City")]
        public string City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Address")]
        public string Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContactPhone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReferralCode")]
        public string ReferralCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SpotRegulator")]
        public string SpotRegulator { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MarginRegulator")]
        public string MarginRegulator { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PaymentSystem")]
        public string PaymentSystem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Isp")]
        public string Isp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DateOfPoaDocument")]
        public System.DateTime? DateOfPoaDocument { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Website")]
        public string Website { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ShortBio")]
        public string ShortBio { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Facebook")]
        public string Facebook { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Twitter")]
        public string Twitter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Github")]
        public string Github { get; set; }

    }
}
