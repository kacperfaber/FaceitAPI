using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Types;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Xunit
{
    public partial class AuthorizationTests
    {
        private IAuthorizable Get(string key)
        {
            IAuthorizable authorizable = new Authorization(key);
            return authorizable;
        }

        [Fact]
        public void NotThrowsExceptions()
        {
            Exception exception = Record.Exception(() => Get("kacpii"));
            Assert.Null(exception);
        }

        [Fact]
        public void NotNull()
        {
            Assert.NotNull(Get("kacpii"));
        }

        [Fact]
        public void GetBearer()
        {
            Assert.Equal("Bearer kacpii", Get("kacpii").GetBearer());
        }

        [Theory]
        [InlineData("010831")]
        public void ValidBearer(string key)
        {
            Assert.Equal("Bearer 010831", Get(key).GetBearer());
        }
    }

    public partial class AuthorizationTests
    {
        internal ITestOutputHelper Out;

        public AuthorizationTests(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
