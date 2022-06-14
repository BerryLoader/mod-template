using BerryLoaderNS;

namespace YourMod
{
	class Main : BerryLoaderMod
	{
		public override void Init()
		{
			BerryLoader.L.LogInfo("hello from YourMod.Main.Init");
		}
	}
}