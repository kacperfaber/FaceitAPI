using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;
using FaceitAPI.Types;
using Xunit;
using Xunit.Abstractions;
using System.Linq;

namespace FaceitAPI.Tests
{
    public partial class LeaderboardsGetChampionshipLeaderboards
    {
        private Paging<LeaderboardDetails> Get(string ch = "a12aed14-2804-455e-a874-272b465b37c7", string apikey = "316c922d-bfd4-4535-b68d-b8799fe96d47")
        {
            Faceit f = new Faceit(new Authorization(apikey));
            ILeaderboards l = f.GetObject<Leaderboards>();

            return l.GetChampionshipLeaderboards(ch, limit: 1);
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
        public void ReturnsValidItemsLen()
        {
            var paging = Get();

            Assert.True(paging.Items.Length == 1);
        }

        [Fact]
        public void ReturnsValidFirstItemData()
        {
            var r = Get().Items.First();

            Assert.Equal("a12aed14-2804-455e-a874-272b465b37c7", r.CompetitionId);
            Assert.Equal("championship", r.CompetitionType);
            Assert.Equal("csgo", r.GameId);
            Assert.True(1553876759 == r.EndDate);
            Assert.True(1 == r.Group);
            Assert.Equal("5c9e23ecf066890008bb481b", r.LeaderboardId);
            Assert.Equal("classic", r.LeaderboardMode);
            Assert.Equal("Group 1", r.LeaderboardName);
            Assert.Equal("flat", r.PointsType);
            Assert.True(1 == r.MinMatches);
            Assert.True(1 == r.PointsPerDraw);
            Assert.True(0 == r.PointsPerLoss);
            Assert.True(3 == r.PointsPerWin);
            Assert.True(10 == r.RankingBoost);
            Assert.Equal("solo", r.RankingType);
            Assert.Equal("EU", r.Region);
            Assert.True(1553864156 == r.StartDate);
            Assert.True(0 == r.StartingPoints);
            Assert.Equal("FINISHED", r.Status);
        }
    }

    public partial class LeaderboardsGetChampionshipLeaderboards
    {
        internal ITestOutputHelper Out;

        public LeaderboardsGetChampionshipLeaderboards(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
