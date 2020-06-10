﻿using BattleTech;
using BattleTech.UI;
using Harmony;
using System;

namespace CBTBehaviors.Patches
{
    [HarmonyPatch(typeof(CombatHUD), "Init")]
    [HarmonyPatch(new Type[] { typeof(CombatGameState) })]
    static class CombatHUD_Init
    {
        static void Postfix(CombatHUD __instance)
        {
            Mod.Log.Info("Capturing reference to CombatHUD");
            ModState.CombatHUD = __instance;
        }
    }
}