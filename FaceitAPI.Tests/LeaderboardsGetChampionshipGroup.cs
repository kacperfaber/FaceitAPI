using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;
using FaceitAPI.Types;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Tests
{
    public partial class LeaderboardsGetChampionshipGroup
    {
        private LeaderboardPaging<Ranking> Get(string ch = "a12aed14-2804-455e-a874-272b465b37c7", int g = 1, string apikey = "316c922d-bfd4-4535-b68d-b8799fe96d47")
        {
            Faceit faceit = new Faceit(new Authorization(apikey));
            ILeaderboards il = faceit.GetObject<Leaderboards>();

            return il.GetChampionshipGroup(ch, g, limit: 1);
        }

        [Fact]
        public void NotThrowExceptions()
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
        public void ReturnsLeaderboardObjectNotNull()
        {
            LeaderboardDetails ld = Get().Leaderboard;

            Assert.NotNull(ld);
        }

        [Fact]
        public void ReturnsValidFirstItemData()
        {
            var r = Get().Items.First();

            Assert.True(r.CurrentStreak == 7);
            Assert.True(r.Draw == 0);
            Assert.True(r.Lost == 0);
            Assert.True(r.Played == 7);
            Assert.NotNull(r.Player);
            Assert.True(r.Points == 21);
            Assert.True(r.Position == 0);
            Assert.True(r.WinRate == 1);
            Assert.True(r.Won == 7);
        }

        [Fact]
        public void ReturnsValidFirstItemDataPlayer()
        {
            var r = Get().Items.First().Player;

            Assert.Equal("https://assets.faceit-cdn.net/avatars/08e7d211-7251-4607-bfd1-36c755b06eb5_1555830682540.jpg", r.Avatar);
            Assert.Equal("kz", r.Country);
            Assert.Equal("https://www.faceit.com/{lang}/players/dukefissura", r.FaceitUrl);
            Assert.Equal("dukefissura", r.Nickname);
            Assert.True(r.SkillLevel > 0);
            Assert.Equal("08e7d211-7251-4607-bfd1-36c755b06eb5", r.UserId);
        }

        [Fact]
        public void ReturnsValidLeaderboardData()
        {
            var r = Get().Leaderboard;

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

    public partial class LeaderboardsGetChampionshipGroup
    {
        internal ITestOutputHelper Out;

        public LeaderboardsGetChampionshipGroup(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
