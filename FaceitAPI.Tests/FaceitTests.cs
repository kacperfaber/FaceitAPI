using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Types;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Tests
{
    public partial class FaceitTests
    {
        Faceit Get()
        {
            Faceit faceit = new Faceit(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47"));
            return faceit;
        }

        [Fact]
        public void NotThrowsExceptions()
        {
            Assert.Null(Record.Exception(() => Get()));
        }

        [Fact]
        public void ReturnsValidType()
        {
            var obj = Get().GetObject<Games>();

            Type type = obj.GetType();

            Assert.True(type == typeof(Games));
            Assert.False(type == typeof(Hubs));
        }

        [Fact]
        public void ReturnsNotNullObjectGames()
        {
            Assert.NotNull(Get().GetObject<Games>());
        }
    }

    public partial class FaceitTests
    {
        internal ITestOutputHelper Out;

        public FaceitTests(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
