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

        Paging<Match> GetHist()
        {
            Players players = new Players(new Authorization("4e79b2b9-d008-45f1-89f3-b7b856e06412"));
            return players.GetPlayerHistory("15e248b6-64e0-44b6-8d51-df1888810aac", "csgo", limit: 5);
        }

        // stewie2kek 10lvl from russia 
        Paging<Hub> GetHubs()
        {
            IAuthorizable auth = new Authorization("4e79b2b9-d008-45f1-89f3-b7b856e06412");
            IPlayers players = new Players(auth);

            return players.GetPlayerHubs("b91bc8c5-b230-45a9-843a-72fddcc03084", limit: 5);
        }

        Statistic GetStats()
        {
            IAuthorizable auth = new Authorization("4e79b2b9-d008-45f1-89f3-b7b856e06412");
            IPlayers players = new Players(auth);

            return players.GetPlayerStatistic("b91bc8c5-b230-45a9-843a-72fddcc03084", "csgo");
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
            Assert.True(GetHist().Items.Length == 5);
        }

        [Fact]
        public void GetHistory_AnyMatchIdNotEmpty()
        {
            foreach (Match match in GetHist().Items)
            {
                Assert.NotEmpty(match.MatchId);
            }
        }

        [Fact]
        public void GetHistory_AllTeamsHaveNickname()
        {
            foreach (Match match in GetHist().Items)
            {
                Assert.NotEmpty(match.Teams.TeamA.Nickname);
                Assert.NotEmpty(match.Teams.TeamB.Nickname);
            }
        }

        [Fact]
        public void GetHistory_AllTeamHave5Players()
        {
            foreach (var m in GetHist().Items)
            {
                Team ta = m.Teams.TeamA;
                Team tb = m.Teams.TeamB;

                Assert.True(ta.Players.Length == 5 && tb.Players.Length == 5);
            }
        }

        [Fact]
        public void GetHubs_NotThrowsExceptions()
        {
            Exception exception = Record.Exception(() => GetHubs());
            Assert.Null(exception);
        }

        [Fact]
        public void GetHubs_ReturnsNotNull()
        {
            Assert.NotNull(GetHubs());
        }

        [Fact]
        public void GetHubs_ItemsHaveGoodLength()
        {
            var items = GetHubs().Items;

            Assert.False(items.Length > 5);
        }

        [Fact]
        public void GetHubs_ItemsFirstHaveGoodData()
        {
            var items = GetHubs().Items;
            var item = items.First();

            Assert.Equal("https://www.faceit.com/{lang}/hub/d74a35c6-8d22-442c-95e1-623d5649ad0c/", item.FaceitUrl);
            Assert.Equal("6e16a640-c737-462d-9b31-7369872e8de4", item.OrganizerId);
            Assert.Equal("MakeMyBet CIS Semi", item.Name);
        }

        [Fact]
        public void GetHubs_ItemsFromZeroToForNotNull()
        {
            var items = GetHubs().Items;

            for (int i = 0; i < items.Length; i++)
            {
                if (i == 4) break;
                Assert.NotNull(items[i]);
            }
        }

        [Fact]
        public void GetHubs_SimpleHubAllVariablesValid()
        {
            var item = GetHubs().Items.First();

            Assert.Equal("d74a35c6-8d22-442c-95e1-623d5649ad0c", item.HubId);
            Assert.Equal("MakeMyBet CIS Semi", item.Name);
            Assert.Equal("https://assets.faceit-cdn.net/hubs/avatar/d74a35c6-8d22-442c-95e1-623d5649ad0c_1551282148604.jpg", item.Avatar);
            Assert.Equal("csgo", item.GameId);
            Assert.Equal("6e16a640-c737-462d-9b31-7369872e8de4", item.OrganizerId);
            Assert.Equal("https://www.faceit.com/{lang}/hub/d74a35c6-8d22-442c-95e1-623d5649ad0c/", item.FaceitUrl);
        }

        [Fact]
        public void GetStats_NotThrowsExceptions()
        {
            var r = Record.Exception(() => GetStats());
            Assert.Null(r);
        }

        [Fact]
        public void GetStats_NotNull()
        {
            Assert.NotNull(GetStats());
        }

        [Fact]
        public void GetStats_ValidDatas()
        {
            var stats = GetStats();

            Assert.Equal("b91bc8c5-b230-45a9-843a-72fddcc03084", stats.PlayerId);
            Assert.Equal("csgo", stats.GameId);
        }
    }
}
