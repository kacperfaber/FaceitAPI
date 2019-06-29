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

            Assert.NotNull(r.OrganizerId);
            Assert.NotNull(r.Name);
            Assert.NotNull(r.Avatar);
        }

        [Fact]
        public void ReturnsValidFirstItemGamesArray()
        {
            string[] games = Get().Items.First().Games;

            Assert.True(games.Length > 0);
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
