using MelonLoader;
using UnityEngine;


namespace RemoveCougars
{
    internal class Implementation : MelonMod
    {
        [Obsolete]
        public override void OnInitializeMelon()
        {
            Settings.OnLoad();/// ModSettings
            LoggerInstance.Msg($"Version {BuildInfo.Version}");

        }

        public override void OnSceneWasInitialized(int level, string name)
        {
           
            Patches.DisableCougars();

        }

        public static void Aaa()
        {
            MelonLogger.Msg("Debug Log ========================== Aaa = ");

        }

    }
}