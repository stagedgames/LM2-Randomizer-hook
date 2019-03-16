using LaMulana2Randomizer.Core.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaMulana2Randomizer.Core.ItemEnums
{
    public enum ItemEnum
    {
        [Description("H Scanner")]
        [ShouldRandomize(true)]
        HandyScanner = 0,
        [Description("Djed Pillar")]
        [ShouldRandomize(true)]
        DjedPillar,
        [Description("Mjolnir")]
        [ShouldRandomize(true)]
        Mjonir,
        [Description("Beherit")]
        [ShouldRandomize(true)]
        Beherit,
        [Description("Battery")]
        [ShouldRandomize(true)]
        Battery,
        [Description("Lamp")]
        [ShouldRandomize(true)]
        Lamp,
        [Description("P Key")]
        [ShouldRandomize(true)]
        PoshetKey,
        [Description("Crystal P")]
        [ShouldRandomize(true)]
        CrystalPiramid,
        [Description("Crystal S")]
        [ShouldRandomize(true)]
        CrystalSkull,
        [Description("Vessel")]
        [ShouldRandomize(true)]
        Vessel,
        [Description("Pepper")]
        [ShouldRandomize(true)]
        Pepper,
        [Description("Egg")]
        [ShouldRandomize(true)]
        Egg,
        [Description("G Pipe")]
        [ShouldRandomize(true)]
        GPipe,
        [Description("Gear")]
        [ShouldRandomize(true)]
        Gear,
        [Description("M Talisman")]
        [ShouldRandomize(true)]
        MTalisman,
        [Description("MSX")]
        [ShouldRandomize(true)]
        MSX,
        [Description("Shell Horn")]
        [ShouldRandomize(true)]
        ShellHorn,
        [Description("Holy Grail")]
        [ShouldRandomize(true)]
        HolyGrail,
        [Description("F Pass")]
        [ShouldRandomize(true)]
        FPass,
        [Description("Glove")]
        [ShouldRandomize(true)]
        Glove,
        [Description("D Figure")]
        [ShouldRandomize(true)]
        DFigure,
        [Description("G Band")]
        [ShouldRandomize(true)]
        GBand,
        [Description("F Torque")]
        [ShouldRandomize(true)]
        FTorque,
        [Description("Vajra")]
        [ShouldRandomize(true)]
        Vajra,
        [Description("Power Band")]
        [ShouldRandomize(true)]
        PowerBand,
        [Description("B Mirror")]
        [ShouldRandomize(true)]
        BMirror,
        [Description("Perfume")]
        [ShouldRandomize(true)]
        Perfume,
        [Description("Ice Cape")]
        [ShouldRandomize(true)]
        IceCape,
        [Description("Fur")]
        [ShouldRandomize(true)]
        Fur,
        [Description("Gauntlet")]
        [ShouldRandomize(true)]
        Gauntlet,
        [Description("Anchor")]
        [ShouldRandomize(true)]
        Anchor,
        [Description("F Pendant")]
        [ShouldRandomize(true)]
        FPendant,
        [Description("T Pole")]
        [ShouldRandomize(true)]
        TotemPole,
        [Description("G Claw")]
        [ShouldRandomize(true)]
        GClaw,
        [Description("Spaulder")]
        [ShouldRandomize(true)]
        Spaulder,
        [Description("Scalesphere")]
        [ShouldRandomize(true)]
        Scalesphere,
        [Description("Crucifix")]
        [ShouldRandomize(true)]
        Crucifix,
        [Description("Gold Bangle")]
        [ShouldRandomize(true)]
        GoldBangle,
        [Description("M Feather")]
        [ShouldRandomize(true)]
        MFeather,
        [Description("Ring")]
        [ShouldRandomize(true)]
        Ring,
        [Description("Bracelet")]
        [ShouldRandomize(true)]
        Bracelet,
        [Description("Feather")]
        [ShouldRandomize(true)]
        Feather,
        [Description("Scriptures")]
        [ShouldRandomize(true)]
        Scriptures,
        [Description("F Ship")]
        [ShouldRandomize(true)]
        FShip,
        [Description("Pandora Box")]
        [ShouldRandomize(true)]
        PandoraBox,
        [Description("Snow Shoes")]
        [ShouldRandomize(true)]
        SnowShoes,
        [Description("Harp")]
        [ShouldRandomize(true)]
        Harp,
        [Description("Book")]
        [ShouldRandomize(true)]
        Book,
        [Description("L Scythe")]
        [ShouldRandomize(true)]
        LScythe,
        [Description("Destiny Tablet")]
        [ShouldRandomize(true)]
        DestinyTablet,
        [Description("Secret Treasure")]
        [ShouldRandomize(true)]
        SecretTreasure,
        [Description("Origin Seal")]
        [ShouldRandomize(true)]
        OriginSeal,
        [Description("Birth Seal")]
        [ShouldRandomize(true)]
        BirthSeal,
        [Description("Life Seal")]
        [ShouldRandomize(true)]
        LifeSeal,
        [Description("Death Seal")]
        [ShouldRandomize(true)]
        DeathSeal,
        [Description("Rebirth Seal")]
        [ShouldRandomize(true)]
        RebirthSeal,
        [Description("Clay Doll")]
        [ShouldRandomize(true)]
        ClayDoll,
        [Description("Kimono Cowgirl")]
        [ShouldRandomize(false)]
        KimonoCowgirl,
        [Description("Valkyria")]
        [ShouldRandomize(false)]
        Valkyria,
        [Description("Little Devil")]
        [ShouldRandomize(false)]
        LittleDevil,
        [Description("Eastern Europe")]
        [ShouldRandomize(false)]
        EasternEurope,
        [Description("Fish Suit")]
        [ShouldRandomize(false)]
        FishSuit,
        [Description("Whip")]
        [ShouldRandomize(false)]
        Whip,
        [Description("Knife")]
        [ShouldRandomize(true)]
        Knife,
        [Description("Rapier")]
        [ShouldRandomize(true)]
        Rapier,
        [Description("Axe")]
        [ShouldRandomize(true)]
        Axe,
        [Description("Katana")]
        [ShouldRandomize(true)]
        Katana,
        [Description("Shuriken")]
        [ShouldRandomize(true)]
        Shuriken,
        [Description("R-Shuriken")]
        [ShouldRandomize(true)]
        RShuriken,
        [Description("E-Spear")]
        [ShouldRandomize(true)]
        ESpear,
        [Description("Flare Gun")]
        [ShouldRandomize(true)]
        FlareGun,
        [Description("Bomb")]
        [ShouldRandomize(true)]
        Bomb,
        [Description("Chakram")]
        [ShouldRandomize(true)]
        Chakram,
        [Description("Caltrops")]
        [ShouldRandomize(true)]
        Caltrops,
        [Description("Pistol")]
        [ShouldRandomize(true)]
        Pistol,
        [Description("Shield")]
        [ShouldRandomize(true)]
        Shield,
        [Description("Ankh Jewel")]
        [ShouldRandomize(true)]
        AnkhJewel,
        [Description("Xelputter")]
        [ShouldRandomize(true)]
        Xelputter,
        [Description("G Map")]
        [ShouldRandomize(true)]
        GMap,
        [Description("G Street")]
        [ShouldRandomize(true)]
        GStreet,
        [Description("TextTrax")]
        [ShouldRandomize(true)]
        TextTrax,
        [Description("R Book")]
        [ShouldRandomize(true)]
        RBook,
        [Description("Mantra")]
        [ShouldRandomize(true)]
        Mantra,
        [Description("Guild")]
        [ShouldRandomize(true)]
        Guild,
        [Description("Research")]
        [ShouldRandomize(true)]
        Research,
        [Description("Enga Musica")]
        [ShouldRandomize(true)]
        EngaMusica,
        [Description("Beo Eg-Lana")]
        [ShouldRandomize(true)]
        BeoEgLana,
        [Description("Alarm")]
        [ShouldRandomize(true)]
        Alarm,
        [Description("Snapshots")]
        [ShouldRandomize(true)]
        Snapshots,
        [Description("Skull")]
        [ShouldRandomize(true)]
        Skull,
        [Description("Reace Reader")]
        [ShouldRandomize(true)]
        RaceReader,
        [Description("Death Village")]
        [ShouldRandomize(true)]
        DeathVillage,
        [Description("R and C")]
        [ShouldRandomize(true)]
        RoseAndCameria,
        [Description("Capstar II")]
        [ShouldRandomize(true)]
        CapstarII,
        [Description("L House Moving")]
        [ShouldRandomize(true)]
        LonelyHouseMoving,
        [Description("Mekuri Master")]
        [ShouldRandomize(true)]
        MekuriMaster,
        [Description("Bounce Shot")]
        [ShouldRandomize(true)]
        BounceShot,
        [Description("Miracle Witch")]
        [ShouldRandomize(true)]
        MiracleWitch,
        [Description("Future DC")]
        [ShouldRandomize(true)]
        FutureDC,
        [Description("La-Mulana")]
        [ShouldRandomize(true)]
        LaMulana,
        [Description("La-Mulana2")]
        [ShouldRandomize(true)]
        LaMulana2,
        [Description("Sacred Orb0")]
        [ShouldRandomize(true)]
        SacredOrb0,
        [Description("Sacred Orb1")]
        [ShouldRandomize(true)]
        SacredOrb1,
        [Description("Sacred Orb2")]
        [ShouldRandomize(true)]
        SacredOrb2,
        [Description("Sacred Orb3")]
        [ShouldRandomize(true)]
        SacredOrb3,
        [Description("Sacred Orb4")]
        [ShouldRandomize(true)]
        SacredOrb4,
        [Description("Sacred Orb5")]
        [ShouldRandomize(true)]
        SacredOrb5,
        [Description("Sacred Orb6")]
        [ShouldRandomize(true)]
        SacredOrb6,
        [Description("Sacred Orb7")]
        [ShouldRandomize(true)]
        SacredOrb7,
        [Description("Sacred Orb8")]
        [ShouldRandomize(true)]
        SacredOrb8,
        [Description("Sacred Orb9")]
        [ShouldRandomize(true)]
        SacredOrb9,
        [Description("Map1")]
        [ShouldRandomize(true)]
        Map1,
        [Description("Map2")]
        [ShouldRandomize(true)]
        Map2,
        [Description("Map3")]
        [ShouldRandomize(true)]
        Map3,
        [Description("Map4")]
        [ShouldRandomize(true)]
        Map4,
        [Description("Map5")]
        [ShouldRandomize(true)]
        Map5,
        [Description("Map6")]
        [ShouldRandomize(true)]
        Map6,
        [Description("Map7")]
        [ShouldRandomize(true)]
        Map7,
        [Description("Map8")]
        [ShouldRandomize(true)]
        Map8,
        [Description("Map9")]
        [ShouldRandomize(true)]
        Map9,
        [Description("Map10")]
        [ShouldRandomize(true)]
        Map10,
        [Description("Map11")]
        [ShouldRandomize(true)]
        Map11,
        [Description("Map12")]
        [ShouldRandomize(true)]
        Map12,
        [Description("Map13")]
        [ShouldRandomize(true)]
        Map13,
        [Description("Map14")]
        [ShouldRandomize(true)]
        Map14,
        [Description("Map15")]
        [ShouldRandomize(true)]
        Map15,
        [Description("Map16")]
        [ShouldRandomize(true)]
        Map16,
        [Description("Map17")]
        [ShouldRandomize(true)]
        Map17,
        [Description("Map18")]
        [ShouldRandomize(true)]
        Map18,
        [Description("Map19")]
        [ShouldRandomize(true)]
        Map19,
        [Description("Map20")]
        [ShouldRandomize(true)]
        Map20,
        [Description("Ankh Jewel1")]
        [ShouldRandomize(true)]
        AnkhJewel1,
        [Description("Ankh Jewel2")]
        [ShouldRandomize(true)]
        AnkhJewel2,
        [Description("Ankh Jewel3")]
        [ShouldRandomize(true)]
        AnkhJewel3,
        [Description("Ankh Jewel4")]
        [ShouldRandomize(true)]
        AnkhJewel4,
        [Description("Ankh Jewel5")]
        [ShouldRandomize(true)]
        AnkhJewel5,
        [Description("Ankh Jewel6")]
        [ShouldRandomize(true)]
        AnkhJewel6,
        [Description("Ankh Jewel7")]
        [ShouldRandomize(true)]
        AnkhJewel7,
        [Description("Ankh Jewel8")]
        [ShouldRandomize(true)]
        AnkhJewel8,
        [Description("Ankh Jewel9")]
        [ShouldRandomize(true)]
        AnkhJewel9,
        [Description("Crystal S1")]
        [ShouldRandomize(true)]
        CrystalS1,
        [Description("Crystal S2")]
        [ShouldRandomize(true)]
        CrystalS2,
        [Description("Crystal S3")]
        [ShouldRandomize(true)]
        CrystalS3,
        [Description("Crystal S4")]
        [ShouldRandomize(true)]
        CrystalS4,
        [Description("Crystal S5")]
        [ShouldRandomize(true)]
        CrystalS5,
        [Description("Crystal S6")]
        [ShouldRandomize(true)]
        CrystalS6,
        [Description("Crystal S7")]
        [ShouldRandomize(true)]
        CrystalS7,
        [Description("Crystal S8")]
        [ShouldRandomize(true)]
        CrystalS8,
        [Description("Crystal S9")]
        [ShouldRandomize(true)]
        CrystalS9,
        [Description("Crystal S10")]
        [ShouldRandomize(true)]
        CrystalS10,
        [Description("Crystal S11")]
        [ShouldRandomize(true)]
        CrystalS11,
        [Description("Crystal S12")]
        [ShouldRandomize(true)]
        CrystalS12,
        [Description("Whip1")]
        [ShouldRandomize(false)]
        Whip1,
        [Description("Whip2")]
        [ShouldRandomize(true)]
        Whip2,
        [Description("Whip3")]
        [ShouldRandomize(true)]
        Whip3,
        [Description("Shield1")]
        [ShouldRandomize(true)]
        Shield1,
        [Description("Shield2")]
        [ShouldRandomize(true)]
        Shield2,
        [Description("Shield3")]
        [ShouldRandomize(true)]
        Shield3,
        [Description("Gold")]
        [ShouldRandomize(false)]
        Gold,
        [Description("Orbs")]
        [ShouldRandomize(false)]
        Orbs,
        [Description("A_Jewel")]
        [ShouldRandomize(false)]
        A_Jewel,
        [Description("Shuriken-b")]
        [ShouldRandomize(false)]
        Shuriken_b,
        [Description("R-Shuriken-b")]
        [ShouldRandomize(false)]
        RShuriken_b,
        [Description("E-Spear-b")]
        [ShouldRandomize(false)]
        ESpear_b,
        [Description("Flare Gun-b")]
        [ShouldRandomize(false)]
        FlareGun_b,
        [Description("Caltrops-b")]
        [ShouldRandomize(false)]
        Caltrops_b,
        [Description("Chakram-b")]
        [ShouldRandomize(false)]
        Chakram_b,
        [Description("Bomb-b")]
        [ShouldRandomize(false)]
        Bomb_b,
        [Description("Pistol-b")]
        [ShouldRandomize(false)]
        Pistol_b,
        [Description("Crystal S-b")]
        [ShouldRandomize(false)]
        CrystalS_b,
        [Description("weight")]
        [ShouldRandomize(false)]
        weight,
        [Description("Sacred Orb")]
        [ShouldRandomize(false)]
        SacredOrb,
        [Description("Map")]
        [ShouldRandomize(false)]
        Map,
        [Description("Crystal S")]
        [ShouldRandomize(false)]
        CrystalS,
        [Description("R Chip")]
        [ShouldRandomize(false)]
        RChip,
        [Description("MSX3")]
        [ShouldRandomize(false)]
        MSX3,
        [Description("MSX3p")]
        [ShouldRandomize(false)]
        MSX3p,
        [Description("N Chip")]
        [ShouldRandomize(false)]
        NChip,
        [Description("Pepper2")]
        [ShouldRandomize(false)]
        Pepper2,
        [Description("Vessel2")]
        [ShouldRandomize(false)]
        Vessel2,
        [Description("Vessel3")]
        [ShouldRandomize(false)]
        Vessel3,
        [Description("UR Chip")]
        [ShouldRandomize(false)]
        URChip,
        [Description("SR Chip")]
        [ShouldRandomize(false)]
        SRChip,
        [Description("Pepper-b")]
        [ShouldRandomize(false)]
        Pepper_b,
        NOTHING

    }
}
