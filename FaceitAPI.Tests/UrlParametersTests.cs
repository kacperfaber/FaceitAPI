using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using FaceitAPI.Requests;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Tests
{
    public class UrlParametersTests
    {
        #region CONSTRUCTOR // ITestOutputHelper = internal Out
        internal ITestOutputHelper Out;

        public UrlParametersTests(ITestOutputHelper helper)
        {
            Out = helper;
        }
        #endregion

        [Fact]
        public void ReturnsNotEmptyString()
        {
            #pragma warning disable IDE0028
            UrlParametersBuilder p = new UrlParametersBuilder();
            p.Add("x", 0);
            p.Add("y", 5);
            p.Add("method", "get");

            UrlBuilder url = new UrlBuilder();
            url.BaseUrl = "https://www.google.com";
            url.Segments.Add("controller");
            url.Segments.Add("action");
            url.UrlParameters = p;

            string getstring = url.GetString();
            Debugger.Break();
        }
    }
}
