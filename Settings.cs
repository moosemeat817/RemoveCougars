using ModSettings;

namespace RemoveCougars
{
    internal class RemoveCougars : JsonModSettings
    {


        //DESCRIPTION
        //[Section("General Information")]
        //[Name("Disable Cougar Regions 1, 2 & 3")]
        //[Description("If you disable the 1st cougar territory in a region, then ALL cougar territories will be disabled for that region.  If you disable the 2nd cougar territory in a region, then the 3rd cougar territory will also be disabled for that region.  If you disable the 3rd cougar territory for a region, then only the 3rd cougar territory will be disabled.")]


        //ASH CANYON
        [Section("Ash Canyon")]

        [Name("Disable Cougar All Cougar Territories")]
        //[Description("Disable Cougar Territory Near Stone Shelf Cave")]
        public bool DisableAC1 = false;

        [Name("Disable Cougar Territories 2 & 3")]
        [Description("Disable Cougar Territory Near Angler's Den & Cougar Territory Near Fishing Hut")]
        public bool DisableAC2 = false;

        [Name("Disable Cougar Territory 3")]
        [Description("Disable Cougar Territory Near Fishing Hut")]
        public bool DisableAC3 = false;


        //BLACKROCK
        [Section("Blackrock Mountain")]

        [Name("Disable Cougar All Cougar Territories")]
        //[Description("Disable Cougar Territory Near Preppers Cache")]
        public bool DisableBRM1 = false;

        [Name("Disable Cougar Territories 2 & 3")]
        [Description("Disable Cougar Territory Near Forager's Remnant & Cougar Territory Near Foreman's Clearcut")]
        public bool DisableBRM2 = false;

        [Name("Disable Cougar Territory 3")]
        [Description("Disable Cougar Territory Near Foreman's Clearcut")]
        public bool DisableBRM3 = false;


        //BLEAK INLET
        [Section("Bleak Inlet")]

        [Name("Disable Cougar All Cougar Territories")]
        //[Description("Disable Cougar Territory Near Alpha Bunker")]
        public bool DisableBI1 = false;

        [Name("Disable Cougar Territories 2 & 3")]
        [Description("Disable Cougar Territory Near Cannery Worker Residence & Cougar Territory Near Washed Out Trailers")]
        public bool DisableBI2 = false;

        [Name("Disable Cougar Territory 3")]
        [Description("Disable Cougar Territory Near Washed Out Trailers")]
        public bool DisableBI3 = false;


        //COASTAL HIGHWAY
        [Section("Coastal Highway")]

        [Name("Disable Cougar All Cougar Territories")]
        //[Description("Disable Cougar Territory Near Ravine Transition")]
        public bool DisableCH1 = false;

        [Name("Disable Cougar Territories 2 & 3")]
        [Description("Disable Cougar Territory Near Quonset Garage & Cougar Territory Near Bear Creek Campground")]
        public bool DisableCH2 = false;

        [Name("Disable Cougar Territory 3")]
        [Description("Disable Cougar Territory Near Bear Creek Campground")]
        public bool DisableCH3 = false;


        //FORSAKEN AIRFIELD
        [Section("Forsaken Airfield")]

        [Name("Disable Cougar All Cougar Territories")]
        //[Description("Disable Cougar Territory Near Brittle Cave")]
        public bool DisableFA1 = false;

        [Name("Disable Cougar Territories 2 & 3")]
        [Description("Disable Cougar Territory Near Mindful Cabin & Cougar Territory Near Fallow Dugout")]
        public bool DisableFA2 = false;

        [Name("Disable Cougar Territory 3")]
        [Description("Disable Cougar Territory Near Fallow Dugout")]
        public bool DisableFA3 = false;


        //HUSHED RIVER VALLEY
        [Section("Hushed River Valley")]

        [Name("Disable Cougar All Cougar Territories")]
        //[Description("Disable Cougar Territory in NW Corner")]
        public bool DisableHRV1 = false;

        [Name("Disable Cougar Territories 2 & 3")]
        [Description("Disable Cougar Territory Near Stairsteps Lake & the third one")]
        public bool DisableHRV2 = false;

        [Name("Disable Cougar Territory 3")]
        [Description("Disable Cougar Territory Near ")]
        public bool DisableHRV3 = false;


        //MOUNATIN TOWN
        [Section("Mountain Town")]

        [Name("Disable Cougar All Cougar Territories")]
        //[Description("Disable Cougar Territory Near Farmhouse")]
        public bool DisableMT1 = false;

        [Name("Disable Cougar Territories 2 & 3")]
        [Description("Disable Cougar Territory Near Church & Cougar Territory Near the Orca")]
        public bool DisableMT2 = false;

        [Name("Disable Cougar Territory 3")]
        [Description("Disable Cougar Territory Near the Orca")]
        public bool DisableMT3 = false;


        //MYSTERY LAKE
        [Section("Mystery Lake")]

        [Name("Disable Cougar All Cougar Territories")]
        //[Description("Disable Cougar Territory Near the Clearcut")]
        public bool DisableML1 = false;

        [Name("Disable Cougar Territories 2 & 3")]
        [Description("Disable Cougar Territory Near the Logging Area & Disable Cougar Territory Near Camp Office")]
        public bool DisableML2 = false;

        [Name("Disable Cougar Territory 3")]
        [Description("Disable Cougar Territory Near Camp Office")]
        public bool DisableML3 = false;


        //PLEASANT VALLEY
        [Section("Pleasant Valley")]

        [Name("Disable Cougar All Cougar Territories")]
        //[Description("Disable Cougar Territory Near Pensive Pond")]
        public bool DisablePV1 = false;

        [Name("Disable Cougar Territories 2 & 3")]
        [Description("Disable Cougar Territory Near Farmhouse & Cougar Territory Near Thompson's Crossing")]
        public bool DisablePV2 = false;

        [Name("Disable Cougar Territory 3")]
        [Description("Disable Cougar Territory Near Thompson's Crossing")]
        public bool DisablePV3 = false;


        //SUNDERED PASS
        [Section("Sundered Pass")]

        [Name("Disable Cougar All Cougar Territories")]
        //[Description("Disable Cougar Territory Near Giant's Thumbprint")]
        public bool DisableSP1 = false;

        [Name("Disable Cougar Territories 2 & 3")]
        [Description("Disable Cougar Territory Near Seeding Spring & the third one")]
        public bool DisableSP2 = false;

        [Name("Disable Cougar Territory 3")]
        [Description("Disable Cougar Territory Near ")]
        public bool DisableSP3 = false;


        //TIMBERWOLF MOUNTAIN
        [Section("Timberwolf Mountain")]

        [Name("DDisable Cougar All Cougar Territories")]
        //[Description("Disable Cougar Territory Near the Wing")]
        public bool DisableTWM1 = false;

        [Name("Disable Cougar Territories 2 & 3")]
        [Description("Disable Cougar Territory Near Mountaineer's Hut & Cougar Territory Near Blackrock Transition")]
        public bool DisableTWM2 = false;

        [Name("Disable Cougar Territory 3")]
        [Description("Disable Cougar Territory Near Blackrock Transition")]
        public bool DisableTWM3 = false;


        protected override void OnConfirm()
        {
            base.OnConfirm();

            Patches.DisableCougars();
        }

    }

    internal static class Settings
    {
        public static RemoveCougars options;

        public static void OnLoad()
        {
            options = new RemoveCougars();
            options.AddToModSettings("Remove Cougars", MenuType.Both);
        }
    }

}