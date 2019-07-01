using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;
using FaceitAPI.Types;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Xunit
{
    public partial class Championships_GetSubscriptions
    {
        private const int LIMIT = 5;

        private Paging<ChampionshipSubscription> Get(string id = "fabfea47-827f-4c99-9bfc-57bdab177e84")
        {
            return new Faceit(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47")).GetObject<Championships>().GetSubscriptions(id, limit: LIMIT);
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
        public void ValidRootData()
        {
            foreach (var s in Get().Items)
            {
                Assert.NotNull(s.Coach);
                Assert.NotNull(s.Coleader);
                Assert.NotNull(s.Group);
                Assert.NotNull(s.Leader);
                Assert.NotNull(s.Roster);
                Assert.NotNull(s.Status);
                Assert.NotNull(s.Substitutes);
                Assert.NotNull(s.Team);
            }
        }
    }

    public partial class Championships_GetSubscriptions
    {
        internal ITestOutputHelper Out;

        public Championships_GetSubscriptions(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
