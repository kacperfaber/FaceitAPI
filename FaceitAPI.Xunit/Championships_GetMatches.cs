using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FaceitAPI.Models;
using FaceitAPI.Types;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Xunit
{
    public partial class Championships_GetMatches
    {
        private const int LIMIT = 5;

        private Paging<Match> Get(string id = "fabfea47-827f-4c99-9bfc-57bdab177e84")
        {
            Faceit faceit = new Faceit(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47"));
            return faceit.GetObject<Championships>().GetMatches(id, limit: LIMIT, type: "past");
        }

        [Fact]
        public void NotThrowsExceptions()
        {
            Assert.Null(Record.Exception(() => Get()));
        }

        [Fact]
        public void NotNull()
        {
            Assert.NotNull(Get());
        }

        [Fact]
        public void ValidItemsCount()
        {
            Assert.True(Get().Items.Length >= LIMIT);
        }

        [Fact]
        public void NotNullItems()
        {
            foreach (var item in Get().Items)
            {
                Assert.NotNull(item);
            }
        }

        [Fact]
        public void ValidRootDataFirstMatch()
        {
            var g = Get().Items[0];

            Assert.NotNull(g.BestOf);
            Assert.NotNull(g.CalculateElo);
            Assert.NotNull(g.ChatRoomId);
            Assert.NotNull(g.CompetitionId);
            Assert.NotNull(g.CompetitionName);
            Assert.NotNull(g.CompetitionType);
            Assert.NotNull(g.ConfiguredAt);
            Assert.NotNull(g.DemoUrl);
            Assert.NotNull(g.FaceitUrl);
            Assert.NotNull(g.FinishedAt);
            Assert.NotNull(g.Game);
            Assert.NotNull(g.Group);
            Assert.NotNull(g.MatchId);
            Assert.NotNull(g.MatchResults);
            Assert.NotNull(g.OrganizerId);
            Assert.NotNull(g.Region);
            Assert.NotNull(g.Round);
            Assert.NotNull(g.ScheduledAt);
            Assert.NotNull(g.StartedAt);
            Assert.NotNull(g.Status);
            Assert.NotNull(g.Teams);
            Assert.NotNull(g.Version);
        }

        [Fact]
        public void ValidTeamsCount()
        {
            Assert.True(Get().Items.First().Teams.Length > 0);
        }

        [Fact]
        public void ValidTeam()
        {
            MatchTeam r = Get().Items.First().Teams.First();

            Assert.NotNull(r.FactionId);
            Assert.NotNull(r.Leader);
            Assert.NotNull(r.Avatar);
            Assert.NotNull(r.Roster);
            Assert.NotNull(r.Substituted);
            Assert.NotNull(r.Type);
            Assert.NotNull(r.Name);
        }

        [Fact]
        public void ValidResults()
        {
            MatchResults r = Get().Items.First().MatchResults;

            Assert.NotNull(r.Winner);
            Assert.NotNull(r.Score);
        }
    }

    public partial class Championships_GetMatches
    {
        internal ITestOutputHelper Out;

        public Championships_GetMatches(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
