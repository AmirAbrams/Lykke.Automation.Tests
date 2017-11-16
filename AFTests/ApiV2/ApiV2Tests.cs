﻿using ApiV2Data.Fixtures;
using Xunit;

namespace AFTests.ApiV2
{
    [Trait("Category", "FullRegression")]
    [Trait("Category", "ApiV2Service")]
    public partial class ApiV2Tests : IClassFixture<ApiV2TestDataFixture>
    {
        private ApiV2TestDataFixture fixture;

        public ApiV2Tests(ApiV2TestDataFixture fixture)
        {
            this.fixture = fixture;
        }
    }
}