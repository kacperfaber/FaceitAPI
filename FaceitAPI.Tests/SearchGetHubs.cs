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
    public partial class SearchGetHubs
    {
        Paging<SimpleHub> Get()
        {
            Faceit f = new Faceit(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47"));

            return f.GetObject<Search>().GetHubs("faceit", "csgo", limit: 4);
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
        public void ReturnsValidItemsCount()
        {
            var hubs = Get();

            Assert.True(hubs.Items.Length == 4);
            Assert.True(hubs.End - hubs.Start == 4);
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
        public void ReturnsValidFirstItemData()
        {
            var r = Get().Items.First();

            Assert.Equal("93221c41-10fc-44a1-92c2-12d7a3588782", r.CompetitionId);
            Assert.Equal("hub", r.CompetitionType);
            Assert.Equal("FACEIT Social", r.Name);
            Assert.Equal("csgo", r.Game);
            Assert.Equal("EU", r.Region);
            Assert.Equal("402c37eb-076e-46ff-8ac8-e4c5564bb6a6", r.OrganizerId);
            Assert.Equal("FACEIT Social", r.OrganizerName);
            Assert.Equal("organization", r.OrganizerType);
            Assert.True(10000 == r.Slots);
            Assert.True(5 == r.NumberOfMembers);
        }
    }

    public partial class SearchGetHubs
    {
        internal ITestOutputHelper Out;

        public SearchGetHubs(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}