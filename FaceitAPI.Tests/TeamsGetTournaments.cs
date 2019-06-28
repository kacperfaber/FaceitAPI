using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;
using FaceitAPI.Types;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Tests
{
    public partial class TeamsGetTournaments
    {

        private Paging<Tournament> Get(string id = "3d6220c0-4954-44a5-8b51-39cb64448d9c", string apikey = "316c922d-bfd4-4535-b68d-b8799fe96d47")
        {
            Faceit f = new Faceit(new Authorization(apikey));
            ITeams teams = f.GetObject<Types.Teams>();

            return teams.GetTeamTournaments(id, limit: 3);
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
            const int expected = 3;
            var get = Get();
            
            int res1 = get.End - get.Start;

            Assert.True(res1 == expected);
        }

        [Fact]
        public void ReturnsValidFirstItemData()
        {
            var r = Get().Items.First();

            Assert.False(r.AnticheatRequired);
            Assert.False(r.Custom);
            Assert.Equal("https://www.faceit.com/{lang}/csgo/tournament/784490aa-20ac-4a04-865f-b577cdae72d3", r.FaceitUrl);
            Assert.Equal("csgo", r.GameId);
            Assert.Equal("", r.FeaturedImage);
            Assert.Equal("", r.InviteType);
            Assert.Equal("csgo 5v5", r.MatchType);
            Assert.True(10 == r.MaxSkill);
            Assert.True(0 == r.MinSkill);
            Assert.Equal("free", r.MembershipType);
            Assert.Equal("Faceit Major Finals", r.Name);
            Assert.True(8 == r.NumberOfPlayers);
            Assert.True(6 == r.NumberOfPlayersCheckedin);
            Assert.True(8 == r.NumberOfPlayersJoined);
            Assert.True(8 == r.NumberOfPlayersParticipants);
            Assert.Equal("8eeebefe-657c-4e76-8b9d-003527fc0c93", r.OrganizerId);
            Assert.Equal("points", r.PrizeType);
            Assert.Equal("EU", r.Region);
            Assert.Equal("paid", r.Status);
            Assert.True(1537349700 == r.StartedAt);
            Assert.True(0 == r.TeamSize);
            Assert.Equal("0", r.TotalPrize);
            Assert.Equal("784490aa-20ac-4a04-865f-b577cdae72d3", r.TournamentId);
            Assert.NotNull(r.WhitelistCountries);
        }
    }

    public partial class TeamsGetTournaments
    {
        internal ITestOutputHelper Out;

        public TeamsGetTournaments(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
