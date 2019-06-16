using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using FaceitAPI.Types;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Tests
{
    public class RequestTests
    {
        #region CONSTRUCTOR // ITestOutputHelper = internal Out
        internal ITestOutputHelper Out;

        public RequestTests(ITestOutputHelper helper)
        {
            Out = helper;
        }
        #endregion

        RequestResult Exec()
        {
            var builder = new RequestBuilder(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47"));
            var request = builder.CreateRequest("search/players?nickname=kacperf1234", HttpMethod.Get);
            return request.Execute();
        }

        [Fact]
        public void ExecuteReturnsNotNull()
        {
            
            Assert.NotNull(Exec());
        }

        [Fact]
        public void ExecuteContentNotEmpty()
        {
            Assert.NotEqual(string.Empty, Exec().Content);
        }

        [Fact]
        public void ExecuteReturnsSuccess()
        {
            Assert.True(Exec().Success);
        }
    }
}
