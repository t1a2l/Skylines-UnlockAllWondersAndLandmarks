using UnlockAllWondersAndLandmarks.OptionsFramework.Attibutes;

namespace UnlockAllWondersAndLandmarks
{
    [Options("UnlockAllWondersAndLandmarks.xml", "CSL-UnlockAllWondersAndLandmarks.xml")]
    public class Options
    {
        public Options()
        {
            UnlockUniqueBuildings = true;
            UnlockDeluxeLandmarks = true;
            UnlockEuroLandmarks = true;
            UnlockWonders = true;
            UnlockTreasureHuntLandmarks = false;
            UnlockAfterDarkLandmarks = false;
            UnlockSnowfallLandmarks = false;
            UnlockNaturalDisastersLandmarks = false;
            UnlockMassTransitLandmarks = false;
            UnlockGreenCitiesLandmarks = false;
            UnlockConcertsLandmarks = false;
            UnlockParklifeLandmarks = false;
            UnlockFinanceLandmarks = false;
            UnlockFinanceBanks = false;
        }

        [Checkbox("Unlock Unique Buildings(levels I - VI)")]
        public bool UnlockUniqueBuildings { set; get; }

        [Checkbox("Unlock Deluxe Landmarks (req. Deluxe Edition)")]
        public bool UnlockDeluxeLandmarks { set; get; }

        [Checkbox("Unlock European Landmarks \n(req. European biome / European Buildings Unlocker mod)")]
        public bool UnlockEuroLandmarks { set; get; }

        [Checkbox("Unlock Wonders (a.k.a Monuments)")]
        public bool UnlockWonders { set; get; }

        [Checkbox("Unlock Treasure Hunt Landmarks")]
        public bool UnlockTreasureHuntLandmarks { set; get; }

        [Checkbox("Unlock After Dark Landmarks (a.k.a Tourism & Leisure, req. After Dark DLC)")]
        public bool UnlockAfterDarkLandmarks { set; get; }

        [Checkbox("Unlock Snowfall Landmarks \n(req. Snowfall DLC + Winter biome/Winter Buildings Unlocker mod)")]
        public bool UnlockSnowfallLandmarks { set; get; }

        [Checkbox("Unlock Natural Disasters Landmarks (req. Natural Disasters DLC)")]
        public bool UnlockNaturalDisastersLandmarks { set; get; }

        [Checkbox("Unlock Mass Transit Landmarks (req. Mass Transit DLC)")]
        public bool UnlockMassTransitLandmarks { set; get; }

        [Checkbox("Unlock Green Cities Landmarks (req. Green Cities DLC)")]
        public bool UnlockGreenCitiesLandmarks { set; get; }

        [Checkbox("Unlock Concerts Landmarks (req. Concerts DLC)")]
        public bool UnlockConcertsLandmarks { set; get; }

        [Checkbox("Unlock Parklife Landmarks (req. Parklife DLC)")]
        public bool UnlockParklifeLandmarks { set; get; }

        [Checkbox("Unlock Finance Landmarks (req. Finance DLC)")]
        public bool UnlockFinanceLandmarks { set; get; }

        [Checkbox("Unlock Finance Banks (req. Finance DLC)")]
        public bool UnlockFinanceBanks { set; get; }
    }
}