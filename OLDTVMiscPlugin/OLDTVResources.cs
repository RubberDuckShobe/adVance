using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Harmony;
using static Harmony.AccessTools;

namespace adVance
{
    class OLDTVResources : MonoBehaviour
    {
        //Responsible for interfacing with game variables, objects etc.
        private GamePlay gp;
        private InfiniteModeGamePlay infinitemodegp;
        private Monitor_FreqTimer MonitorFreqTimer;

        public static Color gameTextColorRGBA;
        public static float currentFrequency;

        void Awake()
        {
            StartCoroutine(GetRequired());
            Console.WriteLine("[adVance] OLDTVResources.Awake() ran");

            var harmony = HarmonyInstance.Create("com.rubberduckshobe.adVance.gamestate");
            harmony.PatchAll();
        }

        IEnumerator GetRequired()
        {
            yield return new WaitUntil(() => Resources.FindObjectsOfTypeAll<GamePlay>().Any());
            gp = Resources.FindObjectsOfTypeAll<GamePlay>().FirstOrDefault();

            yield return new WaitUntil(() => Resources.FindObjectsOfTypeAll<InfiniteModeGamePlay>().Any());
            infinitemodegp = Resources.FindObjectsOfTypeAll<InfiniteModeGamePlay>().FirstOrDefault();

            yield return new WaitUntil(() => Resources.FindObjectsOfTypeAll<Monitor_FreqTimer>().Any());
            MonitorFreqTimer = Resources.FindObjectsOfTypeAll<Monitor_FreqTimer>().FirstOrDefault();
        }

        void Update()
        {
            gameTextColorRGBA = gp.ColorText.GetComponent<TextMesh>().color;
            currentFrequency = MonitorFreqTimer.currentFreq;
        }
    }
}