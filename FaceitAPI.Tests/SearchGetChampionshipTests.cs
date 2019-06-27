using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;
using FaceitAPI.Types;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Tests
{
    public partial class SearchGetChampionshipTests
    {
        private Paging<SimpleChampionship> Get(string name = "faceit", string game = "csgo", string apikey = "316c922d-bfd4-4535-b68d-b8799fe96d47")
        {
            Faceit faceit = new Faceit(new Authorization(apikey));
            ISearch search = faceit.GetObject<Search>();

            return search.GetChampionship(name, game, limit: 5);
        }

        [Fact]
        public void NotThrowsExcetpions()
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
            var get = Get();

            Assert.True(get.Items.Length == 5);
            Assert.True(get.End - get.Start == 5);
        }

        [Fact]
        public void ReturnsItemsNotNull()
        {
            foreach (var item in Get().Items)
            {
                Assert.NotNull(item);
            }
        }

        [Fact]
        public void ReturnsGoodDataInSecondItem()
        {
            var r = Get().Items[1];

            Assert.Equal("ec308970-756b-49eb-b7ce-bf7f64eaf52b", r.CompetitionId);
            Assert.Equal("championship", r.CompetitionType);
            Assert.Equal("Faceit Swiss System Cup Cache & Germany only BETA TEST 2", r.Name);
            Assert.Equal("csgo", r.Game);
            Assert.Equal("EU", r.Region);
            Assert.Equal("140d34b0-af8c-449e-ac76-f8ae44f0eb98", r.OrganizerId);
            Assert.Equal("FACEIT Beta", r.OrganizerName);
            Assert.Equal("organization", r.OrganizerType);
            Assert.Equal("finished", r.Status);
            Assert.True(1554390600 == r.StartedAt);
            Assert.True(32 == r.Slots);
            Assert.True(8 >= r.NumberOfMembers);
        }
    }

    public partial class SearchGetChampionshipTests
    {
        internal ITestOutputHelper Out;

        public SearchGetChampionshipTests(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
