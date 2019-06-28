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
    public partial class TeamsGetTeam
    {
        private ChampionshipTeam Get(string id = "83a5ed0b-ccc9-48f7-bcea-3bb6697a9dd5", string apikey = "316c922d-bfd4-4535-b68d-b8799fe96d47")
        {
            Faceit f = new Faceit(new Authorization(apikey));
            return f.GetObject<Types.Teams>().GetTeam(id);
        }

        [Fact]
        public void NotThrowsAnyExceptions()
        {
            Assert.Null(Record.Exception(() => Get()));
        }

        [Fact]
        public void ReturnsNotNull()
        {
            Assert.NotNull(Get());
        }

        [Fact]
        public void ReturnsValidRootData()
        {
            var r = Get();

            Assert.Equal("83a5ed0b-ccc9-48f7-bcea-3bb6697a9dd5", r.TeamId);
            Assert.Equal("XDDm8456", r.Nickname);
            Assert.Equal("nibfasfb asiofa", r.Name);
            Assert.Equal("", r.Description);
            Assert.Equal("", r.Avatar);
            Assert.Equal("", r.CoverImage);
            Assert.Equal("csgo", r.Game);
            Assert.Equal("premade", r.TeamType);
            Assert.Equal("15e248b6-64e0-44b6-8d51-df1888810aac", r.Leader);
            Assert.Equal("", r.Website);
            Assert.Equal("", r.Facebook);
            Assert.Equal("", r.Twitter);
            Assert.Equal("", r.Youtube);
            Assert.Equal("team-83a5ed0b-ccc9-48f7-bcea-3bb6697a9dd5", r.ChatRoomId);
            Assert.Equal("https://www.faceit.com/{lang}/teams/83a5ed0b-ccc9-48f7-bcea-3bb6697a9dd5", r.FaceitUrl);
        }

        [Fact]
        public void ReturnsValidMembersCount()
        {
            Assert.True(Get().Members.Length == 1);
        }

        [Fact]
        public void ReturnsMembersContainsKacperfProfile()
        {
            ChampionshipTeamMember member = Get().Members.Where(x => x.Country.Equals("pl")).Where(x => x.Nickname.Equals("Kacperf1234")).First();

            Assert.NotNull(member);
        }

        [Fact]
        public void ReturnsMemberValidWithKacperProfile()
        {
            var m = Get().Members.Where(x => x.Nickname == "Kacperf1234").First();

            Assert.Equal("Kacperf1234", m.Nickname);
            Assert.Equal("15e248b6-64e0-44b6-8d51-df1888810aac", m.UserId);
            Assert.Equal("https://assets.faceit-cdn.net/avatars/15e248b6-64e0-44b6-8d51-df1888810aac_1557583084378.jpg", m.Avatar);
            Assert.Equal("pl", m.Country);
            Assert.Equal("free", m.MembershipType);
            Assert.Equal("free", m.Memberships.First());
            Assert.Equal("https://www.faceit.com/{lang}/players/Kacperf1234", m.FaceitUrl);
        }
    }

    public partial class TeamsGetTeam
    {
        internal ITestOutputHelper Out;

        public TeamsGetTeam(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
