using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Upgrades;
using Assets.Scripts.Unity;
using Assets.Scripts.Unity.Bridge;
using Harmony;
using MelonLoader;
using Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;

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
	[HarmonyPatch(typeof(TowerSelectionMenu), "UpdateHeroBooster")]
	public class FreeHeroUpgrade_Patch
	{
		[HarmonyPostfix]
		public static void Prefix(TowerToSimulation tower)
		{
			tower.hero.hero.heroModel.costPerXpToLevel = 0;
		}
	}
}