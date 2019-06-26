using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;
using FaceitAPI.Types;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Tests
{
    public partial class MatchesGetMatch
    {
        Match Get(string id = "1-ff7ddff1-21ad-48b2-b016-5d55596206d9", string apikey = "316c922d-bfd4-4535-b68d-b8799fe96d47")
        {
            Faceit faceit = new Faceit(new Authorization(apikey));
            IMatches matches = faceit.GetObject<Matches>();

            return matches.GetMatch(id);
        }

        [Fact]
        public void NotThrowsExceptionsWhenEveryoneIsGood()
        {
            var exception = Record.Exception(() => Get());
            Assert.Null(exception);
        }

        [Fact]
        public void ThrowsExceptionsWhenAuthorizationIsBad()
        {
            var exception = Record.Exception(() => Get(apikey: "helloworld"));
            Assert.NotNull(exception);
        }

        [Fact]
        public void ThrowsExceptionsWhenMatchIdIsBad()
        {
            var exception = Record.Exception(() => Get(id: "helloworld"));
            Assert.NotNull(exception);
        }

        [Fact]
        public void ReturnsNotNullResults()
        {
            Assert.NotNull(Get());
        }

        [Fact]
        public void ReturnsValidRootData()
        {
            Match m = Get();

            Assert.Equal("1-ff7ddff1-21ad-48b2-b016-5d55596206d9", m.MatchId);
            Assert.True(2 == m.Version);
            Assert.Equal("csgo", m.Game);
            Assert.Equal("EU", m.Region);
            Assert.Equal("42e160fc-2651-4fa5-9a9b-829199e27adb", m.CompetitionId);
            Assert.Equal("matchmaking", m.CompetitionType);
            Assert.Equal("CS:GO 5v5", m.CompetitionName);
            Assert.Equal("faceit", m.OrganizerId);
            Assert.True(m.CalculateElo);
            Assert.True(1561464427 == m.ConfiguredAt);
            Assert.True(1561464639 == m.StartedAt);
            Assert.True(1561467043 == m.FinishedAt);
            Assert.Equal("match-1-ff7ddff1-21ad-48b2-b016-5d55596206d9", m.ChatRoomId);
            Assert.True(1 == m.BestOf);
            Assert.Equal("https://www.faceit.com/{lang}/csgo/room/1-ff7ddff1-21ad-48b2-b016-5d55596206d9", m.FaceitUrl);
            Assert.Equal("FINISHED", m.Status);
        }

        [Fact]
        public void ReturnsNotNullChildrenObjects()
        {
            Match m = Get();

            Assert.NotNull(m.Teams);
            Assert.NotNull(m.Voting);
            Assert.NotNull(m.MatchResults);
        }

        [Fact]
        public void ReturnsVottingValidPick()
        {
            var vote = Get().Voting;

            Assert.Equal("de_cache", vote.Maps.Pick.First());
        }
    }

    public partial class MatchesGetMatches
    {
        internal ITestOutputHelper Out;

        public MatchesGetMatches(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
