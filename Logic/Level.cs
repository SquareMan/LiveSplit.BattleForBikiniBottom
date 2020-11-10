using System.Collections.Generic;

namespace LiveSplit.BattleForBikiniBottom.Logic
{
    public enum Level
    {
        //For Splitting Logic
        Any,

        // Menu
        MainMenu,
        IntroCutscene,

        // Bikini Bottom
        BikiniBottom,
        SpongebobHouse,
        SquidwardHouse,
        PatrickHouse,
        Treedome,
        ShadyShoals,
        PoliceStation,
        KrustyKrab,
        ChumBucket,
        Theater,

        // Hub Bosses
        Poseidome,
        IndustrialPark,

        // Jellyfish Fields
        JellyfishRock,
        JellyfishCaves,
        JellyfishLake,
        JellyfishMountain,

        // Downtown Bikini Bottom
        DowntownStreets,
        DowntownRooftops,
        DowntownLighthouse,
        DowntownSeaNeedle,

        // Goo Lagoon
        GooLagoonBeach,
        GooLagoonCaves,
        GooLagoonPier,

        // Mermalair
        MermalairEntranceArea,
        MermalairMainChamber,
        MermalairSecurityTunnel,
        MermalairBallroom,
        MermalairVillainContainment,

        // Rock Bottom
        RockBottomDowntown,
        RockBottomMuseum,
        RockBottomTrench,

        // Sand Mountain
        SandMountainHub,
        SandMountainSlide1,
        SandMountainSlide2,
        SandMountainSlide3,

        // Kelp Forest
        KelpForest,
        KelpForestSwamps,
        KelpForestCaves,
        KelpForestSlide,

        // Flying Dutchman's Graveyard
        GraveyardLake,
        GraveyardShipwreck,
        GraveyardShip,
        GraveyardBoss,

        // Spongebob's Dream
        SpongebobsDream,
        SandysDream,
        SquidwardsDream,
        KrabsDream,
        PatricksDream,

        //Chum Bucket Labs
        ChumBucketLab,
        ChumBucketBrain,

        //Endgame
        SpongeballArena
    }

    public static class LevelHelper
    {
        public static readonly Dictionary<string, Level> Paths = new Dictionary<string, Level>
        {
            {"MNU3", Level.MainMenu},
            {"HB00", Level.IntroCutscene},

            {"HB01", Level.BikiniBottom},
            {"HB02", Level.SpongebobHouse},
            {"HB03", Level.SquidwardHouse},
            {"HB04", Level.PatrickHouse},
            {"HB06", Level.ShadyShoals},
            {"HB09", Level.PoliceStation},
            {"HB05", Level.Treedome},
            {"HB07", Level.KrustyKrab},
            {"HB08", Level.ChumBucket},
            {"HB10", Level.Theater},

            {"B101", Level.Poseidome},
            {"B201", Level.IndustrialPark},

            {"JF01", Level.JellyfishRock},
            {"JF02", Level.JellyfishCaves},
            {"JF03", Level.JellyfishLake},
            {"JF04", Level.JellyfishMountain},

            {"BB01", Level.DowntownStreets},
            {"BB02", Level.DowntownRooftops},
            {"BB03", Level.DowntownLighthouse},
            {"BB04", Level.DowntownSeaNeedle},

            {"GL01", Level.GooLagoonBeach},
            {"GL02", Level.GooLagoonCaves},
            {"GL03", Level.GooLagoonPier},

            {"BC01", Level.MermalairEntranceArea},
            {"BC02", Level.MermalairMainChamber},
            {"BC03", Level.MermalairSecurityTunnel},
            {"BC04", Level.MermalairBallroom},
            {"BC05", Level.MermalairVillainContainment},

            {"RB01", Level.RockBottomDowntown},
            {"RB02", Level.RockBottomMuseum},
            {"RB03", Level.RockBottomTrench},

            {"SM01", Level.SandMountainHub},
            {"SM02", Level.SandMountainSlide1},
            {"SM03", Level.SandMountainSlide2},
            {"SM04", Level.SandMountainSlide3},

            {"KF01", Level.KelpForest},
            {"KF02", Level.KelpForestSwamps},
            {"KF03", Level.KelpForestCaves},
            {"KF04", Level.KelpForestSlide},

            {"GY01", Level.GraveyardLake},
            {"GY02", Level.GraveyardShipwreck},
            {"GY03", Level.GraveyardShip},
            {"GY04", Level.GraveyardBoss},

            {"DB01", Level.SpongebobsDream},
            {"DB02", Level.SandysDream},
            {"DB03", Level.SquidwardsDream},
            {"DB04", Level.KrabsDream},
            {"DB06", Level.PatricksDream},

            {"B302", Level.ChumBucketLab},
            {"B303", Level.ChumBucketBrain},

            {"PG12", Level.SpongeballArena}
        };

        public static Level GetLevelFromString(string levelString) => Paths.TryGetValue(levelString, out var currentLevel) ? currentLevel : Level.Any;
    }
}