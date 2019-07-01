using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;
using FaceitAPI.Types;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Xunit
{
    public partial class Games_GetGames
    {
        private const int LIMIT = 10;

        private Paging<GameDetails> Get()
        {
            return new Faceit(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47")).GetObject<Games>().GetGames();
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
            foreach (var g in Get().Items)
            {
                Assert.NotNull(g.Assets);
                Assert.NotNull(g.GameId);
                Assert.NotNull(g.LongLabel);
                Assert.NotNull(g.Order);
                Assert.NotNull(g.ParentGameId);
                Assert.NotNull(g.Platforms);
                Assert.NotNull(g.Regions);
                Assert.NotNull(g.ShortLabel);
            }
        }
    }

    public partial class Games_GetGames
    {
        internal ITestOutputHelper Out;

        public Games_GetGames(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
