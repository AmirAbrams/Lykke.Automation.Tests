﻿using LykkePay.Api;
using LykkePay.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using XUnitTestCommon.RestRequests.Interfaces;
using XUnitTestCommon.TestsCore;

namespace LykkePay.Resources.GenerateAddress
{
    public class GenerateAddress : LykkePayApi
    {
        private string resource = "/generateAddress";

        public IResponse<GetGenerateAddressResponseModel> GetGenerateAddress(string id)
        {
            string urlToSign = (BaseURL + $"{resource}/{id}").Replace("https:", "http:");
            var merchant = new MerchantModel(urlToSign);

            return Request.Get($"{resource}/{id}").
                WithHeaders("Lykke-Merchant-Id", merchant.LykkeMerchantId).
                WithHeaders("Lykke-Merchant-Sign", merchant.LykkeMerchantSign).
                Build().Execute<GetGenerateAddressResponseModel>();
        }
    }
}
