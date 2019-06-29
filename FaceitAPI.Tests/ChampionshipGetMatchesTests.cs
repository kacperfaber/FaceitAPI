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
    public partial class ChampionshipGetMatchesTests
    {
        private Paging<Match> Get(string id = "8f71b250-d621-4bd5-8265-2d7ecd4508da", string apikey = "316c922d-bfd4-4535-b68d-b8799fe96d47")
        {
            Faceit faceit = new Faceit(new Authorization(apikey));
            Championships championship = faceit.GetObject<Championships>();

            return championship.GetMatches(id, limit: 3);
        }

        [Fact]
        public void NotThrowsAnyExceptions()
        {
            Assert.Null(Record.Exception(() => Get()));
        }

        [Fact]
        public void ReturnsNotNullResponse()
        {
            Assert.NotNull(Get());
        }

        [Fact]
        public void ItemsCountIsValid()
        {
            int len = Get().Items.Length;

            Assert.True(len == 3);
        }

        [Fact]
        public void ItemsAreNotNull()
        {
            foreach (var item in Get().Items)
            {
                Assert.NotNull(item);
            }
        }

        [Fact]
        public void FirstMatchHaveGoodRootData()
        {
            var m = Get().Items.First();

            Assert.Equal("1-99cac21a-4bcf-4890-b263-f860027f90c9", m.MatchId);
            Assert.Equal("pubg", m.Game);
            Assert.True(2 == m.Version);
            Assert.Equal("EU", m.Region);
            Assert.Equal("8f71b250-d621-4bd5-8265-2d7ecd4508da", m.CompetitionId);
            Assert.Equal("Faceit Points Cup", m.CompetitionName);
            Assert.Equal("championship", m.CompetitionType);
            Assert.Equal("match-1-99cac21a-4bcf-4890-b263-f860027f90c9", m.ChatRoomId);
            Assert.True(1543257847 == m.ConfiguredAt);
            Assert.True(1543258163 == m.StartedAt);
            Assert.True(1543260580 == m.FinishedAt);
            Assert.True(1 == m.BestOf);
            Assert.Equal("FINISHED", m.Status);
            Assert.Equal("https://www.faceit.com/{lang}/pubg/room/1-99cac21a-4bcf-4890-b263-f860027f90c9", m.FaceitUrl);
            Assert.True(0 < m.DemoUrl.Length);
        }

        [Fact]
        public void FirstMatchChildObjectsNotNull()
        {
            var m = Get().Items.First();

            Assert.NotNull(m.MatchResults);
        }

        [Fact]
        public void FirstMatchResultsHaveGoodWinner()
        {
            var m = Get().Items.First();

            Assert.Equal("faction15", m.MatchResults.Winner);
            Assert.True(10 == m.MatchResults.Score["faction1"]);
            Assert.True(4 == m.MatchResults.Score["faction7"]);
            Assert.True(22 == m.MatchResults.Score["faction20"]);
        }
    }

    public partial class ChampionshipGetMatchesTests
    {
        internal ITestOutputHelper Out;

        public ChampionshipGetMatchesTests(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
