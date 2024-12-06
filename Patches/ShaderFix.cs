﻿using System;
using HarmonyLib;
using UnityEngine;
using static VapeMenu.Menu.Main;

namespace VapeMenu.Patches
{
    [HarmonyPatch(typeof(GameObject), "CreatePrimitive")]
    public class ShaderFix
    {
        private static void Postfix(GameObject __result)
        {
            __result.GetComponent<Renderer>().material.shader = Shader.Find(shinymenu ? "Universal Render Pipeline/Lit" : "GorillaTag/UberShader");
            __result.GetComponent<Renderer>().material.color = bgColorA;
        }
    }
}