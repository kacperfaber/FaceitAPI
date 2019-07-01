using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;
using FaceitAPI.Types;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Xunit
{
    public partial class Championships_GetChampionship
    {
        private ChampionshipDetails Get(string id = "fabfea47-827f-4c99-9bfc-57bdab177e84")
        {
            Faceit faceit = new Faceit(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47"));
            return faceit.GetObject<Championships>().GetChampionship(id);
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
        public void ReflectionsNotNull()
        {
            var g = Get();

            foreach (var item in g.GetType().GetProperties())
            {
                Assert.NotNull(item.GetValue(g));
            }
        }

        [Fact]
        public void ValidRootData()
        {
            var g = Get();

            Assert.NotNull(g.AnticheatRequired);
            Assert.NotNull(g.Avatar);
            Assert.NotNull(g.BackgroundImage);
            Assert.NotNull(g.ChampionshipId);
            Assert.NotNull(g.ChampionshipStart);
            Assert.NotNull(g.CheckinClear);
            Assert.NotNull(g.CheckinEnabled);
            Assert.NotNull(g.CheckinStart);
            Assert.NotNull(g.CoverImage);
            Assert.NotNull(g.CurrentSubscriptions);
            Assert.NotNull(g.Description);
            Assert.NotNull(g.FaceitUrl);
            Assert.NotNull(g.Featured);
            Assert.NotNull(g.Full);
            Assert.NotNull(g.GameData);
            Assert.NotNull(g.GameId);
            Assert.NotNull(g.Id);
            Assert.NotNull(g.JoinChecks);
            Assert.NotNull(g.Name);
            Assert.NotNull(g.OrganizerData);
            Assert.NotNull(g.OrganizerId);
            Assert.NotNull(g.Region);
            Assert.NotNull(g.RulesId);
            Assert.NotNull(g.Schedule);
            Assert.NotNull(g.SeedingStrategy);
            Assert.NotNull(g.Slots);
            Assert.NotNull(g.Status);
            Assert.NotNull(g.SubscriptionEnd);
            Assert.NotNull(g.SubscriptionLocked);
            Assert.NotNull(g.SubscriptionStart);
            Assert.NotNull(g.SubstitutionConfiguration);
            Assert.NotNull(g.TotalGroups);
            Assert.NotNull(g.TotalRounds);
            Assert.NotNull(g.Type);
        }
    }

    public partial class Championships_GetChampionship
    {
        internal ITestOutputHelper Out;

        public Championships_GetChampionship(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
