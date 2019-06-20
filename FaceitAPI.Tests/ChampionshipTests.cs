using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;
using FaceitAPI.Types;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Tests
{
    public class ChampionshipTests
    {
        #region CONSTRUCTOR // ITestOutputHelper = internal Out
        internal ITestOutputHelper Out;

        public ChampionshipTests(ITestOutputHelper helper)
        {
            Out = helper;
        }
        #endregion

        private ChampionshipDetails Get()
        {
            Championship c = new Championship(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47"));
            var details = c.GetChampionship("4cc404ff-30f5-49f3-ba22-466b077d8b1c");

            return details;
        }

        [Fact]
        public void NotThrowsAnyException()
        {
            Exception ex = Record.Exception(() => Get());
            Assert.Null(ex);
        }

        [Fact]
        public void ReturnsNotNull()
        {
            Assert.NotNull(Get());
        }
    }
}
