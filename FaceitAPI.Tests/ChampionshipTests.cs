using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;
using FaceitAPI.Tests.Tools;
using FaceitAPI.Types;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Tests
{
    public partial class ChampionshipTests
    {
        public ChampionshipDetails GetById()
        {
            Faceit faceit = new Faceit(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47"));
            Championship ch = faceit.Get<Championship>();
            ChampionshipDetails details = ch.GetChampionship("a12aed14-2804-455e-a874-272b465b37c7");

            return details;
        }

        [Fact]
        public void GetById_NotThrowsExceptions()
        {
            Assert.Null(Record.Exception(() => GetById()));
        }

        [Fact]
        public void GetById_ReturnsNotNull()
        {
            Assert.NotNull(GetById());
        }

        [Fact]
        public void GetById_ValidId()
        {
            Assert.Equal("a12aed14-2804-455e-a874-272b465b37c7", GetById().ChampionshipId);
        }

        [Fact]
        public void GetById_ValidName()
        {
            Assert.Equal("Faceit Points cup Swiss System BETA TEST", GetById().Name);
        }

        [Fact]
        public void GetById_ValidSubscriptionStart()
        {
            Assert.True(1553848380000 == GetById().SubscriptionStart);
        }

        [Fact]
        public void GetById_ValidJoinChecksJoinPolicy()
        {
            Assert.Equal("public", GetById().JoinChecks.JoinPolicy);
        }

        [Fact]
        public void GetById_ValidGameDataLongLabel()
        {
            Assert.Equal("Counter-Strike: Global Offensive", GetById().GameData.LongLabel);
        }
    }

    public partial class ChampionshipTests
    {
        internal ITestOutputHelper Out;

        public ChampionshipTests(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
