using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using FaceitAPI.Models;
using FaceitAPI.Types;
using Xunit;
using System.Linq;
using Xunit.Abstractions;

namespace FaceitAPI.Tests
{
    public class ChampionshipTests
    {
        #region CONSTRUCTOR // ITestOutputHelper = internal Out
        internal ITestOutputHelper Out;

        public ChampionshipTests(ITestOutputHelper helper)
        {
            Out = helper;
        }
        #endregion

        private ChampionshipDetails GetById()
        {
            Championship c = new Championship(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47"));
            var details = c.GetChampionship("4cc404ff-30f5-49f3-ba22-466b077d8b1c");

            return details;
        }

        /// <summary>GetMatches have another championship from GetById method. </summary>
        private ChampionshipMatches GetMatches()
        {
            Championship c = new Championship(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47"));
            var matches = c.GetMatches("052f66eb-d3d5-44fc-a024-d83a2c5b113c", limit: 3);

            return matches;
        }

        [Fact]
        public void GetById_NotThrowsAnyException()
        {
            Exception ex = Record.Exception(() => GetById());
            Assert.Null(ex);
        }

        [Fact]
        public void GetById_ReturnsNotNull()
        {
            Assert.NotNull(GetById());
        }

        [Fact]
        public void GetMatches_NotThrowsExceptions()
        {
            Exception ex = Record.Exception(() => GetMatches());
            Assert.Null(ex);
        }

        [Fact]
        public void GetMatches_ReturnsNotNull()
        {
            Assert.NotNull(GetMatches());
        }

        [Fact]
        public void GetMatches_ReturnsValidItemsLenght()
        {
            var matches = GetMatches().Items;

            Assert.True(matches.Length == 3);
        }

        [Fact]
        public void GetMatches_ReturnsValidFirstMatch()
        {
            var match = GetMatches().Items.First();

            string cid = "052f66eb-d3d5-44fc-a024-d83a2c5b113c";
            string cname = "DPL B cup 3 (LVL 6-9)";

            Assert.Equal(cid, match.CompetitionId);
            Assert.Equal(cname, match.CompetitionName);
        }

        [Fact]
        public void GetMatches_ReturnsNotNullTeams()
        {
            var teama = GetMatches().Items.First().Teams.TeamA;
            var teamb = GetMatches().Items.First().Teams.TeamB;

            Assert.NotNull(teama);
            Assert.NotNull(teamb);
        }

        [Fact]
        public void GetMatches_ReturnsValidTeamAId()
        {
            var matches = GetMatches();
            var team = matches.Items.First().Teams.TeamA;
            string id = team.Id;

            Assert.Equal("3320dae0-06e9-44f0-b884-3d35bda18e7d", id);
        }

        [Fact]
        public void GetMatches_ReturnsValidOrganizerId()
        {
            var organizerid = GetMatches().Items.First().OrganizerId;
            Assert.Equal("56db8bd0-3bb0-471e-a5ca-109dd79d817c", organizerid);
        }
    }
}
