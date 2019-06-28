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
    public partial class SearchGetTournamentsTests
    {
        private Paging<SimpleTournament> Get(string t = "faceit points", string g = "csgo", string apikey = "316c922d-bfd4-4535-b68d-b8799fe96d47")
        {
            Faceit f = new Faceit(new Authorization(apikey));
            Search s = f.GetObject<Search>();

            return s.GetTournaments(t, g, limit: 1 );
        }

        [Fact]
        public void NotThrowsExceptions()
        {
            Assert.Null(Record.Exception(() => Get()));
        }

        [Fact]
        public void NotReturnsNull()
        {
            Assert.NotNull(Get());
        }

        [Fact]
        public void ReturnsValidItemsCount()
        {
            int len = Get().Items.Length;

            Assert.True(len == 1);
        }

        [Fact]
        public void ReturnItemsNotNull()
        {
            foreach (var item in Get().Items)
            {
                Assert.NotNull(item);
            }
        }
    }

    public partial class SearchGetTournamentsTests
    {
        internal ITestOutputHelper Out;

        public SearchGetTournamentsTests(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
