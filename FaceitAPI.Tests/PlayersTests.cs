using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;
using FaceitAPI.Types;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Tests
{
    public class PlayersTests
    {
        #region CONSTRUCTOR // ITestOutputHelper = internal Out
        internal ITestOutputHelper Out;

        public PlayersTests(ITestOutputHelper helper)
        {
            Out = helper;
        }
        #endregion

        PlayerDetails Get()
        {
            Players players = new Players(new Authorization("4e79b2b9-d008-45f1-89f3-b7b856e06412"));
            PlayerDetails details = players.PlayerDetails("15e248b6-64e0-44b6-8d51-df1888810aac");

            return details;
        }

        [Fact]
        public void ReturnsNotThrowsExceptions()
        {
            Assert.Null(Record.Exception(() => Get()));
        }
    }
}
