using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;
using FaceitAPI.Types;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Tests
{
    public partial class ChampionshipGetChampionshipTests
    {
        ChampionshipDetails Get(string id = "8f71b250-d621-4bd5-8265-2d7ecd4508da", string apikey = "316c922d-bfd4-4535-b68d-b8799fe96d47")
        {
            return new Faceit(new Authorization(apikey)).GetObject<Championships>().GetChampionship(id);
        }

        [Fact]
        public void NotThrowsExceptions()
        {
            Exception e = Record.Exception(() => Get());
            Assert.Null(e);
        }

        [Fact]
        public void ReturnsNotNullResults()
        {
            Assert.NotNull(Get());
        }

        [Fact]
        public void ReturnsValidRootData()
        {
            var c = Get();

            Assert.Equal("8f71b250-d621-4bd5-8265-2d7ecd4508da", c.Id);
            Assert.Equal("8f71b250-d621-4bd5-8265-2d7ecd4508da", c.ChampionshipId);
            Assert.Equal("Faceit Points Cup", c.Name);
            Assert.Equal("faceit", c.OrganizerId);
            Assert.Equal("stage", c.Type);
            Assert.Equal("pubg", c.GameId);
            Assert.Equal("EU", c.Region);
            Assert.False(c.Featured);
            Assert.True(1543001460000 == c.SubscriptionStart);
            Assert.True(1543251300000 == c.CheckinStart);
            Assert.True(1543253100000 == c.CheckinClear);
            Assert.True(1543254900000 == c.SubscriptionEnd);
            Assert.True(1543255200000 == c.ChampionshipStart);
            Assert.True(64 == c.Slots);
            Assert.True(53 == c.CurrentSubscriptions);
            Assert.False(c.AnticheatRequired);
            Assert.Equal("0ba25cf1-af12-4bd8-90a8-b2bcc8423059", c.RulesId);
            Assert.False(c.Full);
            Assert.True(c.CheckinEnabled);
            Assert.True(2 == c.TotalRounds);
            Assert.True(1 == c.TotalGroups);
            Assert.True(c.SubscriptionLocked);
            Assert.Equal("https://www.faceit.com/{lang}/championship/8f71b250-d621-4bd5-8265-2d7ecd4508da/", c.FaceitUrl);

        }

        [Fact]
        public void ReturnsNotEmptyChildObjects()
        {
            var c = Get();

            Assert.NotNull(c.GameData);
            Assert.NotNull(c.OrganizerData);
            Assert.NotNull(c.JoinChecks);
            Assert.NotNull(c.SubstitutionConfiguration);
        }
    }

    public partial class ChampionshipGetChampionship
    {
        internal ITestOutputHelper Out;

        public ChampionshipGetChampionship(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
