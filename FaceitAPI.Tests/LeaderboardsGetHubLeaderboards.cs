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
    public partial class LeaderboardsGetHubLeaderboards
    {
        private Paging<LeaderboardDetails> Get(string hubid = "6107184a-8ac1-4240-8c84-7c5fd8a51331", string apikey = "316c922d-bfd4-4535-b68d-b8799fe96d47")
        {
            Faceit faceit = new Faceit(new Authorization(apikey));
            Leaderboards leaderboards = faceit.GetObject<Leaderboards>();
            return leaderboards.GetHubLeaderboards(hubid, limit: 1);
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
        public void ReturnsValidItemLength()
        {
            Assert.True(Get().Items.Length == 1);
        }

        [Fact]
        public void ReturnsNotNullItems()
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

            Assert.Equal("6107184a-8ac1-4240-8c84-7c5fd8a51331", r.CompetitionId);
            Assert.Equal("hub", r.CompetitionType);
            Assert.Equal("csgo", r.GameId);
            Assert.True(r.EndDate == 7840934559);
            Assert.Equal("5b2ba69f9d7d36000766fb69", r.LeaderboardId);
            Assert.Equal("classic", r.LeaderboardMode);
            Assert.Equal("All time Leaderboard", r.LeaderboardName);
            Assert.Equal("hub_general", r.LeaderboardType);
            Assert.True(r.MinMatches == 1);
            Assert.True(r.PointsPerDraw == 1);
            Assert.True(r.PointsPerLoss == -3);
            Assert.True(r.PointsPerWin == 3);
            Assert.Equal("flat", r.PointsType);
            Assert.True(r.RankingBoost == 1);
            Assert.Equal("solo", r.RankingType);
            Assert.Equal("EU", r.Region);
            Assert.True(r.StartDate == 1529587359);
            Assert.True(r.StartingPoints == 1000);
            Assert.Equal("ONGOING", r.Status);
        }
    }

    public partial class LeaderboardsGetHubLeaderboards
    {
        internal ITestOutputHelper Out;

        public LeaderboardsGetHubLeaderboards(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
