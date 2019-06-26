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
    public partial class ChampionshipGetSubscriptions
    {
        private Paging<ChampionshipSubscription> Get(string id = "8f71b250-d621-4bd5-8265-2d7ecd4508da", string apikey = "316c922d-bfd4-4535-b68d-b8799fe96d47")
        {
            Faceit faceit = new Faceit(new Authorization(apikey));
            var championship = faceit.GetObject<Championship>();

            return championship.GetSubscriptions(id, limit: 3);
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
        public void ReturnsGoodItemCount()
        {
            Assert.True(Get().Items.Length == 3);
        }

        [Fact]
        public void ReturnsGoodBetweenStartAndEnd()
        {
            var paging = Get();

            int start = paging.Start;
            int end = paging.End;
            int result = end - start;

            Assert.True(result == 3);
        }

        [Fact]
        public void ReturnsValidFirstItemRootData()
        {
            var i = Get().Items.First();

            Assert.Equal("", i.Coach);
            Assert.Equal("26903659-a8df-4f74-b5f6-1c6eaddc1471", i.Leader);
            Assert.Equal("f7f81b08-1887-4746-ac04-07608a9000c0", i.Coleader);
            Assert.True(1 == i.Group);
            Assert.Equal("checkedIn", i.Status);
        }

        [Fact]
        public void ReturnsValidRosterItemLen()
        {
            var roster = Get().Items.First().Roster;

            Assert.True(roster.Length >= 2);
        }

        [Fact]
        public void ReturnsValidRosterItems()
        {
            var roster = Get().Items.First().Roster;

            Assert.Equal("26903659-a8df-4f74-b5f6-1c6eaddc1471", roster[0]);
            Assert.Equal("f7f81b08-1887-4746-ac04-07608a9000c0", roster[1]);
        }

        [Fact]
        public void ReturnsValidTeam()
        {
            ChampionshipTeam t = Get().Items.First().Team;

            Assert.Equal("ae41d5d7-9790-42ca-a9fb-853d4738c42b", t.TeamId);
            Assert.Equal("", t.Nickname);
            Assert.Equal("", t.Description);
            Assert.Equal("Mbl C3adu", t.Name);
            Assert.Equal("", t.Game);
            Assert.Equal("", t.Avatar);
            Assert.Equal("", t.CoverImage);
            Assert.Equal("premade", t.TeamType);
            Assert.Equal("26903659-a8df-4f74-b5f6-1c6eaddc1471", t.Leader);
            Assert.Equal("https://www.faceit.com/{lang}/teams/ae41d5d7-9790-42ca-a9fb-853d4738c42b", t.FaceitUrl);
            Assert.Equal("team-ae41d5d7-9790-42ca-a9fb-853d4738c42b", t.ChatRoomId);
            
        }

        [Fact]
        public void ReturnsValidTeamMembersCount()
        {
            ChampionshipTeamMember[] member = Get().Items.First().Team.Members;

            Assert.True(2 == member.Length);
        }
    }

    public partial class ChampionshipGetSubscriptions
    {
        internal ITestOutputHelper Out;

        public ChampionshipGetSubscriptions(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
