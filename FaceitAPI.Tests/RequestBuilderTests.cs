using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Types;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Tests
{
    public class RequestBuilderTests
    {
        #region CONSTRUCTOR // ITestOutputHelper = internal Out
        internal ITestOutputHelper Out;

        public RequestBuilderTests(ITestOutputHelper helper)
        {
            Out = helper;
        }
        #endregion

        IAuthorization Authorization()
        {
            return new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47");
        }

        RequestBuilder Get()
        {
            return new RequestBuilder(Authorization());
        }

        Request Req()
        {
            return Get().CreateRequest("search/players?nickname=kacperf1234", HttpMethod.Get);
        }

        [Fact]
        public void DontThrowsAnyException()
        {
            Exception except = Record.Exception(() => Get().CreateRequest("search/players?nickname=kacperf1234", HttpMethod.Get));

            Assert.Null(except);
        }

        [Fact]
        public void ReturnsNotNullRequest()
        {
            Assert.NotNull(Get().CreateRequest("/", HttpMethod.Get));
        }
    }
}
