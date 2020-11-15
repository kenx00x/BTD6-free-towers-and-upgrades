using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Upgrades;
using Assets.Scripts.Unity;
using MelonLoader;
[assembly: MelonInfo(typeof(freeTowers.Class1), "free towers and upgrades", "1.0.0", "kenx00x")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace freeTowers
{
	public class Class1 : MelonMod
	{
		public override void OnUpdate()
		{
			foreach (TowerModel tower in Game.instance.model.towers)
			{
				tower.cost = 0;
			}
			foreach (UpgradeModel upgrade in Game.instance.model.upgrades)
			{
				upgrade.cost = 0;
			}
		}
		public override void OnApplicationStart()
		{
			MelonLogger.Log("Free towers and upgrades mod loaded");
		}
	}
}