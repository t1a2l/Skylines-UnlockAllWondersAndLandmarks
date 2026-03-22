using System.Collections.Generic;
using System.Linq;
using ICities;
using UnlockAllWondersAndLandmarks.OptionsFramework;

namespace UnlockAllWondersAndLandmarks
{
    public class MilestonesExtension : MilestonesExtensionBase
    {
        public override void OnRefreshMilestones()
        {
            milestonesManager.UnlockMilestone("Basic Road Created");

            UnlockBuidlingsIfFlagIsSet(nameof(Options.UnlockUniqueBuildings), new[]
            {
                //UB-I
                "Statue of Industry",
                "Statue of Wealth",
                "Lazaret Plaza",
                "Statue of Shopping",
                "Plaza of the Dead",
                //UB-II
                "Fountain of LifeDeath",
                "Friendly Neighborhood",
                "Transport Tower",
                "Trash Mall",
                "Posh Mall",
                //UB-III
                "Colossal Offices",
                "Official Park",
                "CourtHouse",
                "Grand Mall",
                "Cityhall",
                //UB-IV
                "Business Park",
                "Library",
                "Observatory",
                "Opera House",
                "Oppression Office",
                //UB-V
                "Academic Library",
                "ScienceCenter",
                "Servicing Services",
                "SeaWorld",
                "Expocenter",
                "High Interest Tower",
                //UB-VI
                "Cathedral of Plentitude",
                "Stadium",
                "Modern Art Museum",
                "SeaAndSky Scraper",
                "Theater of Wonders"
            });

            UnlockBuidlingsIfFlagIsSet(nameof(Options.UnlockDeluxeLandmarks), new[]
            {
                //Deluxe
                "Eiffel Tower",
                "Statue of Liberty",
                "Grand Central Terminal",
                "Brandenburg Gate",
                "Arc de Triomphe"
            });

            UnlockBuidlingsIfFlagIsSet(nameof(Options.UnlockEuroLandmarks), new[]
            {
                //European
                "Arena",
                "Shopping Center",
                "Theatre",
                "London Eye",
                "Cinema",
                "City Hall",
                "Amsterdam Palace",
                "Cathedral",
                "Government Offices",
                "Hypermarket",
                "Department Store",
                "Gherkin"
            });

            UnlockBuidlingsIfFlagIsSet(nameof(Options.UnlockWonders), new[]
            {
                //Wonders
                "Hadron Collider",
                "Medical Center",
                "Space Elevator",
                "Eden Project",
                "Fusion Power Plant"
            });

            milestonesManager.UnlockMilestone("Countdown Clock Built");

            UnlockBuidlingsIfFlagIsSet(nameof(Options.UnlockTreasureHuntLandmarks), new[]
            {
                "Plaza of the Future"
            }, "");


            if (ColossalFramework.PlatformServices.PlatformService.IsDlcInstalled((uint)SteamHelper.DLC.AfterDarkDLC))
            {
                UnlockBuidlingsIfFlagIsSet(nameof(Options.UnlockAfterDarkLandmarks), new[]
                {
                    "Fancy Fountain",
                    "Casino",
                    "Driving Range",
                    "Luxury Hotel",
                    "Zoo"
                });
            }

            if (ColossalFramework.PlatformServices.PlatformService.IsDlcInstalled((uint)SteamHelper.DLC.SnowFallDLC))
            {
                UnlockBuidlingsIfFlagIsSet(nameof(Options.UnlockSnowfallLandmarks), new[]
                {
                    "Ice Hockey Arena",
                    "Sleigh Ride",
                    "Spa Hotel",
                    "Snowcastle Restaurant",
                    "Ski Resort",
                    "Santa Claus Workshop",
                    "Christmas Tree",
                    "Arena",
                    "Driving Range",
                    "Igloo Hotel"
                });
            }

            if (ColossalFramework.PlatformServices.PlatformService.IsDlcInstalled((uint)SteamHelper.DLC.NaturalDisastersDLC))
            {
                UnlockBuidlingsIfFlagIsSet(nameof(Options.UnlockNaturalDisastersLandmarks), new[]
                {
                    "Unicorn Park",
                    "Sphinx Of Scenarios",
                    "Pyramid Of Safety",
                    "Doomsday Vault",
                    "Disaster Memorial",
                    "Helicopter Park",
                    "Meteor Park"
                });
            }

            if (ColossalFramework.PlatformServices.PlatformService.IsDlcInstalled((uint)SteamHelper.DLC.InMotionDLC))
            {
                UnlockBuidlingsIfFlagIsSet(nameof(Options.UnlockMassTransitLandmarks), new[]
                {
                    "Boat Museum",
                    "Traffic Park",
                    "Steam Train"
                });
            }

            if (ColossalFramework.PlatformServices.PlatformService.IsDlcInstalled((uint)SteamHelper.DLC.GreenCitiesDLC))
            {
                UnlockBuidlingsIfFlagIsSet(nameof(Options.UnlockGreenCitiesLandmarks), new[]
                {
                    "Bird And Bee Haven",
                    "Floating Gardens",
                    "Central Park",
                    "Ziggurat Garden",
                    "Climate Research Station",
                    "Lungs of the City",
                    "Ultimate Recycling Plant"
                });
            }

            if (ColossalFramework.PlatformServices.PlatformService.IsDlcInstalled((uint)SteamHelper.DLC.MusicFestival))
            {
                UnlockBuidlingsIfFlagIsSet(nameof(Options.UnlockConcertsLandmarks), new[]
                {
                    //concerts
                    "Festival Fan Zone",
                    "Broadcasting Studios",
                    "Live Music Venue",
                    "Festival Area"
                });
            }

            if (ColossalFramework.PlatformServices.PlatformService.IsDlcInstalled((uint)SteamHelper.DLC.ParksDLC))
            {
                milestonesManager.UnlockMilestone("Park Gate Requirements");
                milestonesManager.UnlockMilestone("City Park Requirements 1");
                milestonesManager.UnlockMilestone("City Park Requirements 2");
                milestonesManager.UnlockMilestone("City Park Requirements 3");
                milestonesManager.UnlockMilestone("City Park Requirements 4");
                milestonesManager.UnlockMilestone("City Park Requirements 5");
                milestonesManager.UnlockMilestone("Amusement Park Requirements 1");
                milestonesManager.UnlockMilestone("Amusement Park Requirements 2");
                milestonesManager.UnlockMilestone("Amusement Park Requirements 3");
                milestonesManager.UnlockMilestone("Amusement Park Requirements 4");
                milestonesManager.UnlockMilestone("Amusement Park Requirements 5");
                milestonesManager.UnlockMilestone("Nature Reserve Requirements 1");
                milestonesManager.UnlockMilestone("Nature Reserve Requirements 2");
                milestonesManager.UnlockMilestone("Nature Reserve Requirements 3");
                milestonesManager.UnlockMilestone("Nature Reserve Requirements 4");
                milestonesManager.UnlockMilestone("Nature Reserve Requirements 5");
                milestonesManager.UnlockMilestone("Zoo Requirements 1");
                milestonesManager.UnlockMilestone("Zoo Requirements 2");
                milestonesManager.UnlockMilestone("Zoo Requirements 3");
                milestonesManager.UnlockMilestone("Zoo Requirements 4");
                milestonesManager.UnlockMilestone("Zoo Requirements 5");

                UnlockBuidlingsIfFlagIsSet(nameof(Options.UnlockParklifeLandmarks), new[]
                {
                    "City Arch",
                    "Clock Tower",
                    "Old Market Street",
                    "Sea Fortress",
                    "Observation Tower",
                    "Statue Of Colossalus",
                    "Chirpwick Castle"
                });
            }

            if (ColossalFramework.PlatformServices.PlatformService.IsDlcInstalled((uint)SteamHelper.DLC.IndustryDLC))
            {
                milestonesManager.UnlockMilestone("Main Building Requirements");
                milestonesManager.UnlockMilestone("Farming Requirements 1");
                milestonesManager.UnlockMilestone("Farming Requirements 2");
                milestonesManager.UnlockMilestone("Farming Requirements 3");
                milestonesManager.UnlockMilestone("Farming Requirements 4");
                milestonesManager.UnlockMilestone("Farming Requirements 5");
                milestonesManager.UnlockMilestone("Forestry Requirements 1");
                milestonesManager.UnlockMilestone("Forestry Requirements 2");
                milestonesManager.UnlockMilestone("Forestry Requirements 3");
                milestonesManager.UnlockMilestone("Forestry Requirements 4");
                milestonesManager.UnlockMilestone("Forestry Requirements 5");
                milestonesManager.UnlockMilestone("Oil Requirements 1");
                milestonesManager.UnlockMilestone("Oil Requirements 2");
                milestonesManager.UnlockMilestone("Oil Requirements 3");
                milestonesManager.UnlockMilestone("Oil Requirements 4");
                milestonesManager.UnlockMilestone("Oil Requirements 5");
                milestonesManager.UnlockMilestone("Ore Requirements 1");
                milestonesManager.UnlockMilestone("Ore Requirements 2");
                milestonesManager.UnlockMilestone("Ore Requirements 3");
                milestonesManager.UnlockMilestone("Ore Requirements 4");
                milestonesManager.UnlockMilestone("Ore Requirements 5");
            }

            if (ColossalFramework.PlatformServices.PlatformService.IsDlcInstalled((uint)SteamHelper.DLC.CampusDLC))
            {
                milestonesManager.UnlockMilestone("Campus Main Building Requirements");
                milestonesManager.UnlockMilestone("TradeSchool Requirements 1");
                milestonesManager.UnlockMilestone("TradeSchool Requirements 2");
                milestonesManager.UnlockMilestone("TradeSchool Requirements 3");
                milestonesManager.UnlockMilestone("TradeSchool Requirements 4");
                milestonesManager.UnlockMilestone("TradeSchool Requirements 5");
                milestonesManager.UnlockMilestone("LiberalArts Requirements 1");
                milestonesManager.UnlockMilestone("LiberalArts Requirements 2");
                milestonesManager.UnlockMilestone("LiberalArts Requirements 3");
                milestonesManager.UnlockMilestone("LiberalArts Requirements 4");
                milestonesManager.UnlockMilestone("LiberalArts Requirements 5");
                milestonesManager.UnlockMilestone("University Requirements 1");
                milestonesManager.UnlockMilestone("University Requirements 2");
                milestonesManager.UnlockMilestone("University Requirements 3");
                milestonesManager.UnlockMilestone("University Requirements 4");
                milestonesManager.UnlockMilestone("University Requirements 5");
            }
            
            if (ColossalFramework.PlatformServices.PlatformService.IsDlcInstalled((uint)SteamHelper.DLC.UrbanDLC))
            {
                milestonesManager.UnlockMilestone("Fishing Boat Harbor 02 Requirements");
                milestonesManager.UnlockMilestone("Fishing Boat Harbor 03 Requirements");
                milestonesManager.UnlockMilestone("Fishing Boat Harbor 04 Requirements");
                milestonesManager.UnlockMilestone("Fishing Boat Harbor 05 Requirements");
                milestonesManager.UnlockMilestone("Fish Farm 02 Requirements");
                milestonesManager.UnlockMilestone("Fish Farm 03 Requirements");
                milestonesManager.UnlockMilestone("Seafood Factory Requirements");

                UnlockBuidlingsIfFlagIsSet(nameof(Options.UnlockUniqueBuildings), new[]
                {
                    "Aviation Club"
                }, "Prerequisites");
            }

            if (ColossalFramework.PlatformServices.PlatformService.IsDlcInstalled((uint)SteamHelper.DLC.AirportDLC))
            {
                milestonesManager.UnlockMilestone("Airport Requirements 1");
                milestonesManager.UnlockMilestone("Airport Requirements 2");
                milestonesManager.UnlockMilestone("Airport Requirements 3");
                milestonesManager.UnlockMilestone("Airport Terminal Requirements");
            }

            if (ColossalFramework.PlatformServices.PlatformService.IsDlcInstalled((uint)SteamHelper.DLC.PlazasAndPromenadesDLC))
            {
                milestonesManager.UnlockMilestone("Pedestrian Zone Created");
                milestonesManager.UnlockMilestone("Service Point Created");
                milestonesManager.UnlockMilestone("Flower Plaza Reqs");
                milestonesManager.UnlockMilestone("Large Fountain Plaza Reqs");
                milestonesManager.UnlockMilestone("Large PedArea Plaza Reqs");
                milestonesManager.UnlockMilestone("First SP Requirements");
                milestonesManager.UnlockMilestone("Large Cargo SP Reqs");
                milestonesManager.UnlockMilestone("Large Garbage SP Reqs");
                milestonesManager.UnlockMilestone("Large Service Point Reqs");
                milestonesManager.UnlockMilestone("Small Cargo SP Reqs");
                milestonesManager.UnlockMilestone("Small Garbage SP Reqs");
                milestonesManager.UnlockMilestone("Landmark Market Hall Reqs");
                milestonesManager.UnlockMilestone("Landmark MOPMA Reqs");
                milestonesManager.UnlockMilestone("Landmark Shopping Mall Reqs");
                milestonesManager.UnlockMilestone("Landmark Commercial");
                milestonesManager.UnlockMilestone("Landmark Office");
                milestonesManager.UnlockMilestone("Landmark Residential");
            }

            if (ColossalFramework.PlatformServices.PlatformService.IsDlcInstalled((uint)SteamHelper.DLC.FinancialDistrictsDLC))
            {
                milestonesManager.UnlockMilestone("Stock Exchange Level 2 Created");
                milestonesManager.UnlockMilestone("Stock Exchange Level 3 Created");
                milestonesManager.UnlockMilestone("Stock Exchange Level 4 Created");
                milestonesManager.UnlockMilestone("Stock Exchange Level 5 Created");
                milestonesManager.UnlockMilestone("SE Localized Level 2");
                milestonesManager.UnlockMilestone("SE Localized Level 3");
                milestonesManager.UnlockMilestone("SE Localized Level 4");
                milestonesManager.UnlockMilestone("SE Localized Level 5");

                UnlockBuidlingsIfFlagIsSet(nameof(Options.UnlockFinanceLandmarks), new[]
                {
                    "Bronze Cow",
                    "Bronze Panda",
                    "Elevated Plaza",
                    "Underground Garden Plaza"
                });

                UnlockBuidlingsIfFlagIsSet(nameof(Options.UnlockFinanceBanks), new[]
                {
                    "Small Bank",
                    "Large Bank",
                    "Skyscraper Bank"
                });
            }

            if (ColossalFramework.PlatformServices.PlatformService.IsDlcInstalled((uint)SteamHelper.DLC.HotelDLC))
            {
                milestonesManager.UnlockMilestone("2-Star Average Popularity");
                milestonesManager.UnlockMilestone("2-Star Hotel");
                milestonesManager.UnlockMilestone("2-Star Hotel Pofit");
                milestonesManager.UnlockMilestone("3-Star Average Popularity");
                milestonesManager.UnlockMilestone("3-Star Hotel");
                milestonesManager.UnlockMilestone("3-Star Hotel Pofit");
                milestonesManager.UnlockMilestone("4-Star Average Popularity");
                milestonesManager.UnlockMilestone("4-Star Hotel");
                milestonesManager.UnlockMilestone("4-Star Hotel Pofit");
                milestonesManager.UnlockMilestone("5-Star Average Popularity");
                milestonesManager.UnlockMilestone("5-Star Hotel");
                milestonesManager.UnlockMilestone("5-Star Hotel Pofit");
            }

            if (ColossalFramework.PlatformServices.PlatformService.IsDlcInstalled(4031130))
            {
                milestonesManager.UnlockMilestone("Stand Prerequisites");
                milestonesManager.UnlockMilestone("Event Park Created");
                milestonesManager.UnlockMilestone("Racing HQ Created");
            }
            
        }

        private void UnlockBuidlingsIfFlagIsSet(string flag, IEnumerable<string> buildingNames, string suffix = "Requirements")
        {
            if (!(bool) typeof(Options).GetProperty(flag).GetValue(OptionsWrapper<Options>.Options, null))
            {
                return;
            }

            foreach (var buildingName in buildingNames)
            {
                UnlockBuilding(buildingName, suffix);
            }
        }


        private void UnlockBuilding(string buildingName, string suffix)
        {
            var milestone = $"{buildingName} {suffix}";

            if (milestonesManager.EnumerateMilestones().Contains(milestone))
            {
                milestonesManager.UnlockMilestone(milestone);
            }
        }

        public override int OnGetPopulationTarget(int originalTarget, int scaledTarget)
        {
            return 0;
        }
    }
}