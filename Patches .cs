using UnityEngine;
using Il2Cpp;

namespace RemoveCougars
{
    public class Patches : MonoBehaviour                               //public class Patches:MonoBehaviour
    {


        public static string[,] itemDataArray =
        {
            //COUGARS
            {"0_Scene",              "1_Name" },


            //ASH CANYON
            {"AshCanyonRegion_DLC01",        "CougarTerritoryZone_a_T1"},
            {"AshCanyonRegion_DLC01",        "CougarTerritoryZone_a_T2"},
            {"AshCanyonRegion_DLC01",        "CougarTerritoryZone_a_T3"},

            //BLACKROCK
            {"BlackrockRegion_DLC01",        "CougarTerritoryZone_a_T1"},
            {"BlackrockRegion_DLC01",        "CougarTerritoryZone_a_T2"},
            {"BlackrockRegion_DLC01",        "CougarTerritoryZone_a_T3"},

            //BLEAK INLET
            {"CanneryRegion_DLC01",        "CougarTerritoryZone_a_T1"},
            {"CanneryRegion_DLC01",        "CougarTerritoryZone_a_T2"},
            {"CanneryRegion_DLC01",        "CougarTerritoryZone_a_T3"},

            //COASTAL HIGHWAY
            {"CoastalRegion_DLC01",        "CougarTerritoryZone_a_T1"},
            {"CoastalRegion_DLC01",        "CougarTerritoryZone_a_T2"},
            {"CoastalRegion_DLC01",        "CougarTerritoryZone_a_T3"},

            //FORSAKEN AIRFIELD
            {"AirfieldRegion_WILDLIFE",        "CougarTerritoryZone_a_T1"},
            {"AirfieldRegion_WILDLIFE",        "CougarTerritoryZone_a_T2"},
            {"AirfieldRegion_WILDLIFE",        "CougarTerritoryZone_a_T3"},

            //HUSHED RIVER VALLEY
            {"RiverValleyRegion_DLC01",        "CougarTerritoryZone_a_T1"},
            {"RiverValleyRegion_DLC01",        "CougarTerritoryZone_a_T2"},
            {"RiverValleyRegion_DLC01",        "CougarTerritoryZone_a_T3"},

            //MOUNATIN TOWN
            {"MountainTownRegion_DLC01",        "CougarTerritoryZone_a_T1"},
            {"MountainTownRegion_DLC01",        "CougarTerritoryZone_a_T2"},
            {"MountainTownRegion_DLC01",        "CougarTerritoryZone_a_T3"},

            //MYSTERY LAKE
            {"LakeRegion_DLC01",        "CougarTerritoryZone_a_T1"},
            {"LakeRegion_DLC01",        "CougarTerritoryZone_a_T2"},
            {"LakeRegion_DLC01",        "CougarTerritoryZone_a_T3"},

            //PLEASANT VALLEY
            {"RuralRegion_DLC01",        "CougarTerritoryZone_a_T1"},
            {"RuralRegion_DLC01",        "CougarTerritoryZone_a_T2"},
            {"RuralRegion_DLC01",        "CougarTerritoryZone_a_T3"},

            //SUNDERED PASS
            {"MountainPassRegion_WILDLIFE",        "CougarTerritoryZone_a_T1"},
            {"MountainPassRegion_WILDLIFE",        "CougarTerritoryZone_a_T2"},
            {"MountainPassRegion_WILDLIFE",        "CougarTerritoryZone_a_T3"},

            //TIMBERWOLF MOUNTAIN
            {"CrashMountainRegion_DLC01",        "CougarTerritoryZone_a_T1"},
            {"CrashMountainRegion_DLC01",        "CougarTerritoryZone_a_T2"},
            {"CrashMountainRegion_DLC01",        "CougarTerritoryZone_a_T3"},


        };

        public static void DisableCougars()
        {

            GameObject findTargetGO = new GameObject();



            for (int i = 1; i < itemDataArray.GetLength(0); i++)
            {
                // ----- Find Name -----------------------------------------------------------------
                if (GameObject.Find(itemDataArray[i, 1]) == null)
                {
                    //MelonLogger.Msg("ChangeObjcet is null.");
                    continue;
                }
                else
                {
                    findTargetGO = GameObject.Find(itemDataArray[i, 1]);
                    // GameObject.Find cannot find for already inactive game objects. So this needs to be reloaded after confermation.
                }
                // ---------------------------------------------------------------------------------------


                if (findTargetGO != null)
                {
                    // ----- Scene check -----------------------------------------------------------------
                    if (findTargetGO.scene.name != itemDataArray[i, 0]) // Scene 
                    {
                        //MelonLogger.Msg("Scene name does not match.");
                        continue;
                    }
                    // -------------------------------------------------------------------------------------


                    // ==============================================================================================================
                    // ASH CANYON
                    // ==============================================================================================================
                    if (itemDataArray[i, 0] == "AshCanyonRegion_DLC01")
                    {


                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T1")
                        {
                            if (Settings.options.DisableAC1)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T2")
                        {
                            if (Settings.options.DisableAC2)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T3")
                        {
                            if (Settings.options.DisableAC3)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                    }

                    // ==============================================================================================================
                    // BLACKROCK
                    // ==============================================================================================================
                    if (itemDataArray[i, 0] == "BlackrockRegion_DLC01")
                    {


                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T1")
                        {
                            if (Settings.options.DisableBRM1)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T2")
                        {
                            if (Settings.options.DisableBRM2)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T3")
                        {
                            if (Settings.options.DisableBRM3)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }


                    }

                    // ==============================================================================================================
                    // BLEAK INLET
                    // ==============================================================================================================
                    if (itemDataArray[i, 0] == "CanneryRegion_DLC01")
                    {


                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T1")
                        {
                            if (Settings.options.DisableBI1)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T2")
                        {
                            if (Settings.options.DisableBI2)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T3")
                        {
                            if (Settings.options.DisableBI3)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }


                    }

                    // ==============================================================================================================
                    // COASTAL HIGHWAY
                    // ==============================================================================================================
                    if (itemDataArray[i, 0] == "CoastalRegion_DLC01")
                    {


                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T1")
                        {
                            if (Settings.options.DisableCH1)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T2")
                        {
                            if (Settings.options.DisableCH2)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T3")
                        {
                            if (Settings.options.DisableCH3)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }


                    }

                    // ==============================================================================================================
                    // FORSAKEN AIRFIELD
                    // ==============================================================================================================
                    if (itemDataArray[i, 0] == "AirfieldRegion_WILDLIFE")
                    {


                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T1")
                        {
                            if (Settings.options.DisableFA1)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T2")
                        {
                            if (Settings.options.DisableFA2)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T3")
                        {
                            if (Settings.options.DisableFA3)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }


                    }

                    // ==============================================================================================================
                    // HUSHED RIVER VALLEY
                    // ==============================================================================================================
                    if (itemDataArray[i, 0] == "RiverValleyRegion_DLC01")
                    {


                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T1")
                        {
                            if (Settings.options.DisableHRV1)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T2")
                        {
                            if (Settings.options.DisableHRV2)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T3")
                        {
                            if (Settings.options.DisableHRV3)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }


                    }

                    // ==============================================================================================================
                    // MOUNATIN TOWN
                    // ==============================================================================================================
                    if (itemDataArray[i, 0] == "MountainTownRegion_DLC01")
                    {


                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T1")
                        {
                            if (Settings.options.DisableMT1)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T2")
                        {
                            if (Settings.options.DisableMT2)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T3")
                        {
                            if (Settings.options.DisableMT3)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }


                    }

                    // ==============================================================================================================
                    // MYSTERY LAKE
                    // ==============================================================================================================
                    if (itemDataArray[i, 0] == "LakeRegion_DLC01")
                    {


                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T1")
                        {
                            if (Settings.options.DisableML1)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T2")
                        {
                            if (Settings.options.DisableML2)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T3")
                        {
                            if (Settings.options.DisableML3)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }


                    }

                    // ==============================================================================================================
                    // PLEASANT VALLEY
                    // ==============================================================================================================
                    if (itemDataArray[i, 0] == "RuralRegion_DLC01")
                    {


                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T1")
                        {
                            if (Settings.options.DisablePV1)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T2")
                        {
                            if (Settings.options.DisablePV2)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T3")
                        {
                            if (Settings.options.DisablePV3)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }


                    }

                    // ==============================================================================================================
                    // SUNDERED PASS
                    // ==============================================================================================================
                    if (itemDataArray[i, 0] == "MountainPassRegion_WILDLIFE")
                    {


                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T1")
                        {
                            if (Settings.options.DisableSP1)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T2")
                        {
                            if (Settings.options.DisableSP2)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T3")
                        {
                            if (Settings.options.DisableSP3)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }


                    }

                    // ==============================================================================================================
                    // TIMBERWOLF MOUNTAIN
                    // ==============================================================================================================
                    if (itemDataArray[i, 0] == "CrashMountainRegion_DLC01")
                    {


                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T1")
                        {
                            if (Settings.options.DisableSP1)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T2")
                        {
                            if (Settings.options.DisableSP2)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 1] == "CougarTerritoryZone_a_T3")
                        {
                            if (Settings.options.DisableSP3)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }


                    }



                }
            }
        }

    }
}