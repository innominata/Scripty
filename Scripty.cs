using BepInEx;
using HarmonyLib;
using System;
using static GalacticScale.GS2;
using GalacticScale;
namespace GalacticScale
{
    [BepInPlugin("scripty", "Scripty", "1.0")]
    [BepInProcess("DSPGAME.exe")]
    public class Scripty : BaseUnityPlugin
    {
        private Harmony _harmony;
        private void Awake()
        {
            _harmony = new Harmony("scripty");
            Log("Scripty Awake");
            Execute();
        }
        private void OnDestroy()
        {
            Log("Destroying scripty");
            _harmony?.UnpatchSelf();
        }
        static void Execute()
        {
            Warn("Testigghng");
            UIRoot.instance.galaxySelect.EnterGame();
            //UIRoot.instance.galaxySelect._Open();
        }
    }
}
