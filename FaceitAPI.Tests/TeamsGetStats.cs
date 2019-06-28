using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;
using FaceitAPI.Types;
using Newtonsoft.Json.Linq;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Tests
{
    public partial class TeamsGetStats
    {
        private TeamStatistics Get(string id = "3d6220c0-4954-44a5-8b51-39cb64448d9c", string game = "csgo", string apikey = "316c922d-bfd4-4535-b68d-b8799fe96d47")
        {
            Faceit faceit = new Faceit(new Authorization(apikey));
            return faceit.GetObject<Types.Teams>().GetTeamStatistics(id, game);
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
        public void ReturnsValidRootData()
        {
            var r = Get();

            Assert.Equal("3d6220c0-4954-44a5-8b51-39cb64448d9c", r.TeamId);
            Assert.Equal("csgo", r.GameId);
            Assert.NotNull(r.Lifetime);
            Assert.NotNull(r.Segments);
        }

        [Fact]
        public void ReturnsValidHeadshotsPercentageFromDictionaryLifetime()
        {
            var r = Get();
            var d = r.Lifetime["Team Average Headshots %"];

            Assert.Equal("4732", d);
        }

        [Fact]
        public void RecentResultsCanConvertToJArrayAndToObject()
        {
            Action act = () =>
            {
                var d = (JArray) Get().Lifetime["Recent Results"];
                string[] arr = d.ToObject<string[]>();
            };

            Assert.Null(Record.Exception(act));
        }
    }

    public partial class TeamsGetStats
    {
        internal ITestOutputHelper Out;

        public TeamsGetStats(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
