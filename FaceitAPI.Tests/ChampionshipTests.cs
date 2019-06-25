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
    public partial class ChampionshipTests
    {
        public ChampionshipDetails GetById()
        {
            Faceit faceit = new Faceit(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47"));
            Championship ch = faceit.Get<Championship>();
            ChampionshipDetails details = ch.GetChampionship("a12aed14-2804-455e-a874-272b465b37c7");

            return details;
        }

        public Paging<Match> GetMatches()
        {
            Faceit faceit = new Faceit(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47"));
            Championship c = faceit.Get<Championship>();
            Paging<Match> m = c.GetMatches("a12aed14-2804-455e-a874-272b465b37c7", limit: 3);

            return m;
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
        public void GetById_ReturnsValidRoot()
        {
            var d = GetById();

            Assert.Equal("a12aed14-2804-455e-a874-272b465b37c7", d.Id);
            Assert.Equal("a12aed14-2804-455e-a874-272b465b37c7", d.ChampionshipId);
            Assert.Equal("Faceit Points cup Swiss System BETA TEST", d.Name);
            Assert.Equal("", d.CoverImage);
            Assert.Equal("", d.BackgroundImage);
            Assert.Equal("", d.Avatar);
            Assert.Equal("140d34b0-af8c-449e-ac76-f8ae44f0eb98", d.OrganizerId);
            Assert.Equal("- Everyone plays all 7 rounds. \n- You can still win even though you lost matches. \n- This tournament uses the Buchholz score as tiebreaker. The top 8 players receive prizes.\n- You need to play your matches to qualify for a prize.\n- All prizing is paid out 24hrs after the event concludes.\n\nEnjoy the games and have fun!", d.Description);
            Assert.Equal("swiss", d.Type);
            Assert.Equal("finished", d.Status);
            Assert.Equal("csgo", d.GameId);
            Assert.Equal("EU", d.Region);
            Assert.False(d.Featured);
            Assert.True(1553848380000 == d.SubscriptionStart);
            Assert.True(1553864100000 == d.CheckinStart);
            Assert.True(1553865900000 == d.CheckinClear);
            Assert.True(1553867700000 == d.SubscriptionEnd);
            Assert.True(1553868000000 == d.ChampionshipStart);
            Assert.True(256 == d.Slots);
            Assert.True(d.CurrentSubscriptions > 0);
            Assert.NotNull(d.JoinChecks);
            Assert.NotNull(d.SubstitutionConfiguration);
            Assert.NotNull(d.OrganizerData);
            Assert.NotNull(d.GameData);
            Assert.True(d.AnticheatRequired);
            Assert.Equal("", d.RulesId);
            Assert.True(d.CheckinEnabled);
            Assert.False(d.Full);
        }

        [Fact]
        public void GetMatches_NotThrowsExceptions()
        {
            Assert.Null(Record.Exception(() => GetMatches()));
        }

        [Fact]
        public void GetMatches_ReturnsNotNull()
        {
            Assert.NotNull(GetMatches());
        }

        [Fact]
        public void GetMatches_ReturnsValidItemsCount()
        {
            Assert.True(GetMatches().Items.Length == 3);
        }

        [Fact]
        public void GetMatches_ReturnsValidRoot()
        {
            var d = GetMatches().Items.First();

            Assert.Equal("1-e361b79c-a521-4118-889e-23af3fd328a7", d.MatchId);
            Assert.True(2 == d.Version);
            Assert.Equal("csgo", d.Game);
            Assert.Equal("EU", d.Region);
            Assert.Equal("a12aed14-2804-455e-a874-272b465b37c7", d.CompetitionId);
            Assert.Equal("championship", d.CompetitionType);
            Assert.Equal("140d34b0-af8c-449e-ac76-f8ae44f0eb98", d.OrganizerId);
            Assert.Equal("match-1-e361b79c-a521-4118-889e-23af3fd328a7", d.ChatRoomId);
            Assert.True(1553876068 == d.ScheduledAt);
            Assert.True(1553876378 == d.FinishedAt);
            Assert.True(1 == d.BestOf);
            Assert.Equal("FINISHED", d.Status);
            Assert.Equal("https://www.faceit.com/{lang}/csgo/room/1-e361b79c-a521-4118-889e-23af3fd328a7", d.FaceitUrl);
            Assert.True(7 == d.Round);
            Assert.NotNull(d.Teams);
            Assert.NotNull(d.MatchResults);
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
