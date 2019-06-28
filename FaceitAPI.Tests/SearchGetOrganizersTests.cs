using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;
using FaceitAPI.Types;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Tests
{
    public partial class SearchGetOrganizersTests
    {
        private const int LIMIT = 3;

        private Paging<SimpleOrganizer> Get(string name = "faceit", string apikey = "316c922d-bfd4-4535-b68d-b8799fe96d47")
        {
            Faceit f = new Faceit(new Authorization(apikey));
            ISearch search = f.GetObject<Search>();

            return search.GetOrganizers(name, limit: LIMIT);
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
        public void ReturnsValidItemsCount()
        {
            Assert.True(Get().Items.Length == LIMIT);
        }

        [Fact]
        public void ReturnsItemsNotNull()
        {
            var items = Get().Items;

            foreach (var item in items)
            {
                Assert.NotNull(item);
            }
        }

        [Fact]
        public void ReturnsValidFirstItemRootData()
        {
            var r = Get().Items.First();

            Assert.Equal("a8a8b8d8-a26d-4ef5-ab1d-ad2d652d6b82", r.OrganizerId);
            Assert.Equal("FACEIT Insider", r.Name);
            Assert.True(r.Partner);
            Assert.Equal("https://assets.faceit-cdn.net/organizer_avatar/a8a8b8d8-a26d-4ef5-ab1d-ad2d652d6b82_1554280303138.jpg", r.Avatar);
            Assert.True(r.Active);
        }

        [Fact]
        public void ReturnsValidFirstItemGamesArray()
        {
            string[] games = Get().Items.First().Games;

            Assert.Contains("csgo", games);
            Assert.Contains("pubg", games);
        }
    }

    public partial class SearchGetOrganizersTests
    {
        internal ITestOutputHelper Out;

        public SearchGetOrganizersTests(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
