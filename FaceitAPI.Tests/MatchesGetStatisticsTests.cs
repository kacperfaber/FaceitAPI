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
    public partial class MatchesGetStatisticsTests
    {
        MatchStatistics Get(string id = "1-ff7ddff1-21ad-48b2-b016-5d55596206d9", string apikey = "316c922d-bfd4-4535-b68d-b8799fe96d47")
        {
            Faceit faceit = new Faceit(new Authorization(apikey));
            IMatches matches = faceit.GetObject<Matches>();

            return matches.GetMatchStatistics(id);
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
        public void ReturnsRoundsHaveGoodLength()
        {
            Assert.True(Get().Rounds.Length == 1);
        }

        [Fact]
        public void ReturnsValidRootData()
        {
            var m = Get().Rounds[0];

            Assert.Equal("1", m.BestOf);
            Assert.Equal("csgo", m.GameId);
            Assert.Equal("5v5", m.GameMode);
            Assert.Equal("1-ff7ddff1-21ad-48b2-b016-5d55596206d9", m.MatchId);
            Assert.Equal("1", m.Played);
            Assert.Equal("1", m.RoundMatch);
        }

        [Fact]
        public void ReturnsValidRoundStatsDictionaryKeysCount()
        {
            var d = Get().Rounds[0].RoundStatistics;

            Assert.True(5 == d.Keys.Count);
        }

        [Fact]
        public void ReturnsValidRoundStatsDictionary()
        {
            var d = Get().Rounds[0].RoundStatistics;

            Assert.Equal("de_cache", d["Map"]);
            Assert.Equal("16 / 8", d["Score"]);
            Assert.Equal("24", d["Rounds"]);
            Assert.Equal("cfe33f5d-12b8-4f6e-bb90-c27ca9c4b39c", d["Winner"]);
        }

        [Fact]
        public void ReturnsValidTeamsCount()
        {
            var teams = Get().Rounds[0].Teams;

            Assert.True(teams.Length == 2);
        }

        [Fact]
        public void ReturnsValidTeamOne()
        {
            var team = Get().Rounds[0].Teams.Last();

            Assert.Equal("6f13ba5b-ded3-4cbf-89f8-c25ff70c5787", team.TeamId);
            Assert.False(team.Premade);
            Assert.NotEmpty(team.Players);
            Assert.Equal("b897eacc-5232-4732-a0ba-347fb10d5301", team.Players.First().PlayerId);
        }
    }

    public partial class MatchesGetStatistics
    {
        internal ITestOutputHelper Out;

        public MatchesGetStatistics(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
