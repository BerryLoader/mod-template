using BepInEx;
using BerryLoaderNS;

namespace YourMod
{
	[BepInPlugin("EpicExampleModId", "Epic Example Mod", "0.0.1")]
	[BepInDependency("BerryLoader")]
	class Plugin : BaseUnityPlugin
	{
		public static BepInEx.Logging.ManualLogSource L;

		private void Awake()
		{
			L = Logger;
			L.LogInfo("hello from YourMod.Plugin.Awake");
		}
	}
}