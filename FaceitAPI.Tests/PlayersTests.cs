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

        PlayerDetails GetById()
        {
            Players players = new Players(new Authorization("4e79b2b9-d008-45f1-89f3-b7b856e06412"));
            PlayerDetails details = players.GetPlayerDetails("15e248b6-64e0-44b6-8d51-df1888810aac");

            return details;
        }

        PlayerDetails GetByNickname()
        {
            Players players = new Players(new Authorization("4e79b2b9-d008-45f1-89f3-b7b856e06412"));
            PlayerDetails details = players.GetPlayerDetails(nickname: "Kacperf1234");

            return details;
        }

        History GetHist()
        {
            Players players = new Players(new Authorization("4e79b2b9-d008-45f1-89f3-b7b856e06412"));
            return players.GetPlayerHistory("15e248b6-64e0-44b6-8d51-df1888810aac", "csgo", limit: 5);
        }

        [Fact]
        public void GetById_NotThrowsException()
        {
            Assert.Null(Record.Exception(() => GetById()));
        }

        [Fact]
        public void GetById_ReturnsValidElo()
        {
            var faceitelo = GetById().Games.CounterStrike.FaceitElo;
            Assert.True(faceitelo > 500);
        }

        [Fact]
        public void GetById_ReturnsValidSkillLevel()
        {
            var skilllevel = GetById().Games.CounterStrike.SkillLevel;
            Assert.True(skilllevel == 1 || skilllevel > 1);
        }

        [Fact]
        public void GetById_ReturnsNotEmptyAvatar()
        {
            var avatar = GetById().Avatar;
            Assert.NotEmpty(avatar);
        }

        [Fact]
        public void GetByNickname_NotThrowsException()
        {
            Assert.Null(Record.Exception(() => GetByNickname()));
        }

        [Fact]
        public void GetByNickname_ReturnsNotNull()
        {
            Assert.NotNull(GetByNickname());
        }

        [Fact]
        public void GetByNickname_ReturnsValidPlayerId()
        {
            string id = GetByNickname().PlayerId;
            Assert.Equal("15e248b6-64e0-44b6-8d51-df1888810aac", id);
        }

        [Fact]
        public void GetByNickname_ReturnsValidFaceitUrl()
        {
            string url = GetByNickname().FaceitUrl;
            Assert.Equal("https://www.faceit.com/{lang}/players/Kacperf1234", url);
        }

        [Fact]
        public void GetByNickname_ReturnsFriendsIds()
        {
            var friends = GetByNickname().FriendsIds;
            int len = friends.Length;

            Assert.True(len > 20);
        }

        [Fact]
        public void GetByNickname_ReturnsValidElo()
        {
            var csgo = GetByNickname().Games.CounterStrike;

            Assert.True(csgo.FaceitElo > 500);
        }

        [Fact]
        public void GetByNickname_ReturnsValidSettingsLanguage()
        {
            var lang = GetByNickname().Settings.Language;
            Assert.Equal("pl", lang);
        }

        [Fact]
        public void GetHistory_NotThrowsException()
        {
            Assert.Null(Record.Exception(() => GetHist()));
        }

        [Fact]
        public void GetHistory_ReturnsNotNull()
        {
            Assert.NotNull(GetHist());
        }

        [Fact]
        public void GetHistory_ReturnsValidItemsCount()
        {
            Assert.True(GetHist().Matches.Length == 5);
        }

        [Fact]
        public void GetHistory_AnyMatchIdNotEmpty()
        {
            foreach (Match match in GetHist().Matches)
            {
                Assert.NotEmpty(match.MatchId);
            }
        }

        [Fact]
        public void GetHistory_AllTeamsHaveNickname()
        {
            foreach (Match match in GetHist().Matches)
            {
                Assert.NotEmpty(match.Teams.TeamA.Nickname);
                Assert.NotEmpty(match.Teams.TeamB.Nickname);
            }
        }
    }
}
