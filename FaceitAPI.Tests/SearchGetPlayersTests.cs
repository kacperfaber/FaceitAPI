using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FaceitAPI.Models;
using FaceitAPI.Types;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Tests
{
    public partial class SearchGetPlayersTests
    {
        private Paging<SimplePlayer> Get(string nick = "kacperf1234", string apikey = "316c922d-bfd4-4535-b68d-b8799fe96d47")
        {
            Faceit faceit = new Faceit(new Authorization(apikey)); 

            return faceit.GetObject<Search>().GetPlayers(nick, "csgo", limit: 1);
        }

        [Fact]
        public void NotThrowsExceptions()
        {
            Assert.Null(Record.Exception(() => Get()));
        }

        [Fact]
        public void ReturnsNotNull()
        {
            Assert.NotNull(Get());
        }

        [Fact]
        public void ReturnsValidItemsCount()
        {
            Assert.True(Get().Items.Length == 1);
        }

        [Fact]
        public void ReturnItemsNotNull()
        {
            foreach (var item in Get().Items)
            {
                Assert.NotNull(item);
            }
        }

        [Fact]
        public void ReturnsValidRootData()
        {
            var r = Get().Items.First();

            Assert.Equal("15e248b6-64e0-44b6-8d51-df1888810aac", r.PlayerId);
            Assert.Equal("Kacperf1234", r.Nickname);
            Assert.Equal("AVAILABLE", r.Status);
            Assert.Equal("PL", r.Country);
            Assert.Equal("https://assets.faceit-cdn.net/avatars/15e248b6-64e0-44b6-8d51-df1888810aac_1557583084378.jpg", r.Avatar);
            Assert.False(r.Verified);
        }

        [Fact]
        public void ReturnsValidGamesArrayItemsCount()
        {
            Assert.True(Get().Items.First().Games.Length >= 1);
        }

        [Fact]
        public void ReturnsValidGameNameAndSkillLevel()
        {
            SimplePlayerGame game = Get().Items.First().Games.First();

            Assert.Equal("csgo", game.Name);
            Assert.True(Convert.ToInt32(game.SkillLevel) != 0);
        }
    }

    public partial class SearchGetPlayersTests
    {
        internal ITestOutputHelper Out;

        public SearchGetPlayersTests(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
