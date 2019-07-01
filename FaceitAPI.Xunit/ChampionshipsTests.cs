using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;
using FaceitAPI.Types;
using Xunit;
using Xunit.Abstractions;

namespace FaceitAPI.Xunit
{
    public partial class ChampionshipsTests
    {
        public class GetChampionship
        {
            public class GameData
            {
                public class Assets
                {
                    private Models.Assets get;

                    private Models.Assets Get(string id = "fabfea47-827f-4c99-9bfc-57bdab177e84")
                    {
                        if (get == null)
                        {
                            Faceit faceit = new Faceit(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47"));
                            IChampionships championship = faceit.GetObject<Championships>();

                            get = championship.GetChampionship(id).GameData.Assets;
                        }

                        return get;
                    }

                    [Fact]
                    public void Cover()
                    {
                        Assert.NotNull(Get().Cover);
                    }

                    [Fact]
                    public void FeaturedImageL()
                    {
                        Assert.NotNull(Get().FeaturedImageL);
                    }

                    [Fact]
                    public void FeaturedImageM()
                    {
                        Assert.NotNull(Get().FeaturedImageM);
                    }

                    [Fact]
                    public void FeaturedImageS()
                    {
                        Assert.NotNull(Get().FeaturedImageS);
                    }

                    [Fact]
                    public void FlagImageL()
                    {
                        Assert.NotNull(Get().FlagImageL);
                    }

                    [Fact]
                    public void FlagImageM()
                    {
                        Assert.NotNull(Get().FlagImageM);
                    }

                    [Fact]
                    public void FlagImageS()
                    {
                        Assert.NotNull(Get().FlagImageS);
                    }

                    [Fact]
                    public void LandingPage()
                    {
                        Assert.NotNull(Get().LandingPage);
                    }
                }

                private Models.GameData get;

                private Models.GameData Get(string id = "fabfea47-827f-4c99-9bfc-57bdab177e84")
                {
                    if (get == null)
                    {
                        Faceit faceit = new Faceit(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47"));
                        IChampionships championship = faceit.GetObject<Championships>();

                        get = championship.GetChampionship(id).GameData;
                    }

                    return get;
                }

                [Fact]
                public void VAssets()
                {
                    Assert.NotNull(Get().Assets);
                }

                [Fact]
                public void GameId()
                {
                    Assert.NotNull(Get().GameId);
                }

                [Fact]
                public void LongLabel()
                {
                    Assert.NotNull(Get().LongLabel);
                }

                [Fact]
                public void Order()
                {
                    Assert.NotNull(Get().Order);
                }

                [Fact]
                public void ParentGameId()
                {
                    Assert.NotNull(Get().ParentGameId);
                }

                [Fact]
                public void Platforms()
                {
                    Assert.NotNull(Get().Platforms);
                }

                [Fact]
                public void Regions()
                {
                    Assert.NotNull(Get().Regions);
                }

                [Fact]
                public void ShortLabel()
                {
                    Assert.NotNull(Get().ShortLabel);
                }
            }

            public class JoinChecks
            { 
                private Models.JoinChecks get;

                private Models.JoinChecks Get(string id = "fabfea47-827f-4c99-9bfc-57bdab177e84")
                {
                    if (get == null)
                    {
                        Faceit faceit = new Faceit(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47"));
                        IChampionships championship = faceit.GetObject<Championships>();
                        
                        get = championship.GetChampionship(id).JoinChecks;
                    }

                    return get;
                }

                [Fact]
                public void AllowedTeamTypes()
                {
                    Assert.NotNull(Get().AllowedTeamTypes);
                }

                [Fact]
                public void BlacklistGeoCountries()
                {
                    Assert.NotNull(Get().BlacklistGeoCountries);
                }

                [Fact]
                public void JoinPolicy()
                {
                    Assert.NotNull(Get().JoinPolicy);
                }

                [Fact]
                public void MaxSkillLevel()
                {
                    Assert.NotNull(Get().MaxSkillLevel);
                }

                [Fact]
                public void MinSkillLevel()
                {
                    Assert.NotNull(Get().MinSkillLevel);
                }

                [Fact]
                public void MembershipType()
                {
                    Assert.NotNull(Get().MembershipType);
                }

                [Fact]
                public void WhitelistGeoCountries()
                {
                    Assert.NotNull(Get().WhitelistGeoCountries);
                }

                [Fact]
                public void WhitelistGeoCountriesMinPlayers()
                {
                    Assert.NotNull(Get().WhitelistGeoCountriesMinPlayers);
                }
            }

            public class OrganizerData
            {
                private Models.OrganizerDetails get;

                private OrganizerDetails Get(string id = "fabfea47-827f-4c99-9bfc-57bdab177e84")
                {
                    if (get == null)
                    {
                        Faceit faceit = new Faceit(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47"));
                        IChampionships championship = faceit.GetObject<Championships>();

                        get = championship.GetChampionship(id).OrganizerData;
                    }

                    return get;
                }

                [Fact]
                public void Avatar()
                {
                    Assert.NotNull(Get().Avatar);
                }

                [Fact]
                public void Cover()
                {
                    Assert.NotNull(Get().Cover);
                }

                [Fact]
                public void Description()
                {
                    Assert.NotNull(Get().Description);
                }

                [Fact]
                public void Facebook()
                {
                    Assert.NotNull(Get().Facebook);
                }

                [Fact]
                public void FaceitUrl()
                {
                    Assert.NotNull(Get().FaceitUrl);
                }

                [Fact]
                public void Name()
                {
                    Assert.NotNull(Get().Name);
                }

                [Fact]
                public void OrganizerId()
                {
                    Assert.NotNull(Get().OrganizerId);
                }

                [Fact]
                public void Twitch()
                {
                    Assert.NotNull(Get().Twitch);
                }

                [Fact]
                public void Twitter()
                {
                    Assert.NotNull(Get().Twitter);
                }

                [Fact]
                public void Type()
                {
                    Assert.NotNull(Get().Type);
                }

                [Fact]
                public void Vk()
                {
                    Assert.NotNull(Get().Vk);
                }

                [Fact]
                public void Website()
                {
                    Assert.NotNull(Get().Website);
                }

                [Fact]
                public void Youtube()
                {
                    Assert.NotNull(Get().Youtube);
                }
            }

            private ChampionshipDetails Get(string id = "fabfea47-827f-4c99-9bfc-57bdab177e84")
            {
                Faceit faceit = new Faceit(new Authorization("316c922d-bfd4-4535-b68d-b8799fe96d47"));
                IChampionships championship = faceit.GetObject<Championships>();
                return championship.GetChampionship(id);
            }

            [Fact]
            public void NotThrowsException()
            {
                Assert.Null(Record.Exception(() => Get()));
            }

            [Fact]
            public void NotNull()
            {
                Assert.NotNull(Get());
            }

            [Fact]
            public void AnticheatRequired()
            {
                Assert.NotNull(Get().AnticheatRequired);
            }

            [Fact]
            public void Avatar()
            {
                Assert.NotNull(Get().Avatar);
            }

            [Fact]
            public void BackgroundImage()
            {
                Assert.NotNull(Get().BackgroundImage);
            }

            [Fact]
            public void ChampionshipId()
            {
                Assert.NotNull(Get().ChampionshipId);
            }

            [Fact]
            public void ChampionshipStart()
            {
                Assert.NotNull(Get().ChampionshipStart);
            }

            [Fact]
            public void CheckinClear()
            {
                Assert.NotNull(Get().CheckinClear);
            }

            [Fact]
            public void CheckinEnabled()
            {
                Assert.NotNull(Get().CheckinEnabled);
            }

            [Fact]
            public void CoverImage()
            {
                Assert.NotNull(Get().CoverImage);
            }

            [Fact]
            public void CurrentSubscriptions()
            {
                Assert.NotNull(Get().CurrentSubscriptions);
            }

            [Fact]
            public void Description()
            {
                Assert.NotNull(Get().Description);
            }

            [Fact]
            public void FaceitUrl()
            {
                Assert.NotNull(Get().FaceitUrl);
            }

            [Fact]
            public void Featured()
            {
                Assert.NotNull(Get().Featured);
            }

            [Fact]
            public void Full()
            {
                Assert.NotNull(Get().Full);
            }

            [Fact]
            public void VGameData()
            {
                Assert.NotNull(Get().GameData);
            }

            [Fact]
            public void GameId()
            {
                Assert.NotNull(Get().GameId);
            }

            [Fact]
            public void Id()
            {
                Assert.NotNull(Get().Id);
            }

            [Fact]
            public void VJoinChecks()
            {
                Assert.NotNull(Get().JoinChecks);
            }

            [Fact]
            public void Name()
            {
                Assert.NotNull(Get().Name);
            }

            [Fact]
            public void VOrganizerData()
            {
                Assert.NotNull(Get().OrganizerData);
            }

            [Fact]
            public void OrganizerId()
            {
                Assert.NotNull(Get().OrganizerId);
            }

            [Fact]
            public void Region()
            {
                Assert.NotNull(Get().Region);
            }

            [Fact]
            public void RulesId()
            {
                Assert.NotNull(Get().RulesId);
            }

            [Fact]
            public void Schedule()
            {
                Assert.NotNull(Get().Schedule);
            }

            [Fact]
            public void SeedingStrategy()
            {
                Assert.NotNull(Get().SeedingStrategy);
            }

            [Fact]
            public void Slots()
            {
                Assert.NotNull(Get().Slots);
            }

            [Fact]
            public void Status()
            {
                Assert.NotNull(Get().Status);
            }

            [Fact]
            public void SubscriptionEnd()
            {
                Assert.NotNull(Get().SubscriptionEnd);
            }

            [Fact]
            public void SubscriptionStart()
            {
                Assert.NotNull(Get().SubscriptionStart);
            }

            [Fact]
            public void SubscriptionLocked()
            {
                Assert.NotNull(Get().SubscriptionLocked);
            }

            [Fact]
            public void SubstitutionConfiguration()
            {
                Assert.NotNull(Get().SubstitutionConfiguration);
            }

            [Fact]
            public void TotalGroups()
            {
                Assert.NotNull(Get().TotalGroups);
            }

            [Fact]
            public void TotalRounds()
            {
                Assert.NotNull(Get().TotalRounds);
            }

            [Fact]
            public void Type()
            {
                Assert.NotNull(Get().Type);
            }
        }
    }

    public partial class ChampionshipsTests
    {
        internal ITestOutputHelper Out;

        public ChampionshipsTests(ITestOutputHelper helper)
        {
            Out = helper;
        }
    }
}
