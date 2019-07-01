using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;
using FaceitAPI.Types;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Xunit
{
    public partial class Hubs_GetHub
    {
        private HubDetails Get(string hub = "66059536-896b-4ce6-968c-3efaac136cd3")
        {
            Faceit faceit = new Faceit(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47"));
            return faceit.GetObject<Hubs>().GetHub(hub);
        }

        [Fact]
        public void NotThrows()
        {
            Assert.Null(Record.Exception(() => Get()));
        }

        [Fact]
        public void NotNull()
        {       
            Assert.NotNull(Get());
        }

        [Fact]
        public void ValidRootData()
        {
            var r = Get();

            Assert.NotNull(r.Avatar);
            Assert.NotNull(r.BackgroundImage);
            Assert.NotNull(r.ChatRoomId);
            Assert.NotNull(r.CoverImage);
            Assert.NotNull(r.Description);
            Assert.NotNull(r.FaceitUrl);
            Assert.NotNull(r.GameData);
            Assert.NotNull(r.GameId);
            Assert.NotNull(r.HubId);
            Assert.NotNull(r.JoinPermission);
            Assert.NotNull(r.MaxSkillLevel);
            Assert.NotNull(r.MinSkillLevel);
            Assert.NotNull(r.Name);
            Assert.NotNull(r.OrganizerData);
            Assert.NotNull(r.OrganizerId);
            Assert.NotNull(r.PlayersJoined);
            Assert.NotNull(r.Region);
            Assert.NotNull(r.RuleId);
        }

        [Fact]
        public void ValidGameData()
        {
            GameData a = Get().GameData;

            Assert.NotNull(a.Assets);
            Assert.NotNull(a.GameId);
            Assert.NotNull(a.LongLabel);
            Assert.NotNull(a.Order);
            Assert.NotNull(a.ParentGameId);
            Assert.NotNull(a.Platforms);
            Assert.NotNull(a.Regions);
            Assert.NotNull(a.ShortLabel);
        }

        [Fact]
        public void ValidOrganizerData()
        {
            var g = Get().OrganizerData;

            Assert.NotNull(g.Avatar);
            Assert.NotNull(g.Cover);
            Assert.NotNull(g.Description);
            Assert.NotNull(g.Facebook);
            Assert.NotNull(g.FaceitUrl);
            Assert.NotNull(g.Name);
            Assert.NotNull(g.OrganizerId);
            Assert.NotNull(g.Twitch);
            Assert.NotNull(g.Twitter);
            Assert.NotNull(g.Type);
            Assert.NotNull(g.Vk);
            Assert.NotNull(g.Website);
            Assert.NotNull(g.Youtube);
        }
    }

    public partial class Hubs_GetHub
    {
        internal ITestOutputHelper Out;

        public Hubs_GetHub(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
