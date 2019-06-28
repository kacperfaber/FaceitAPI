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
    public partial class SearchGetTeamsTests
    {
        private Paging<SimpleTeam> Get(string teamname = "nibfasfb asiofa", int limit = 1, string apikey = "316c922d-bfd4-4535-b68d-b8799fe96d47")
        {
            Authorization auth = new Authorization(apikey);
            Faceit f = new Faceit(auth);
            Search s = f.GetObject<Search>();
            Paging<SimpleTeam> p = s.GetTeams(teamname, limit: limit);

            return p;
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
        public void ReturnsItemsNotNull()
        {
            foreach (var item in Get().Items)
            {
                Assert.NotNull(item);
            }
        }

        [Fact]
        public void ReturnsValidItemsCount()
        {
            Assert.True(Get().Items.Length == 1);
        }

        [Fact]
        public void ReturnsValidFirstItem()
        {
            var r = Get().Items.First();

            Assert.Equal("83a5ed0b-ccc9-48f7-bcea-3bb6697a9dd5", r.TeamId);
            Assert.Equal("nibfasfb asiofa", r.Name);
            Assert.Equal("csgo", r.Game);
            Assert.Equal("", r.Avatar);
            Assert.Equal("team-83a5ed0b-ccc9-48f7-bcea-3bb6697a9dd5", r.ChatRoomId);
            Assert.Equal("https://www.faceit.com/{lang}/teams/83a5ed0b-ccc9-48f7-bcea-3bb6697a9dd5", r.FaceitUrl);
            Assert.False(r.Verified);
        }
    }

    public partial class SearchGetTeamsTests
    {
        internal ITestOutputHelper Out;

        public SearchGetTeamsTests(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
