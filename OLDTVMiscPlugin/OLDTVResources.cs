using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace adVance
{
    class OLDTVResources : MonoBehaviour
    {
        //Responsible for interfacing with game variables, objects etc.
        private GamePlay gp;
        private Monitor_FreqTimer MonitorFreqTimer;

        public static Color gameTextColorRGBA;
        public static float currentFrequency;

        void Awake()
        {
            StartCoroutine(GetRequired());
            Console.WriteLine("[adVance] OLDTVResources.Awake() ran");
        }

        IEnumerator GetRequired()
        {
            yield return new WaitUntil(() => Resources.FindObjectsOfTypeAll<GamePlay>().Any());
            gp = Resources.FindObjectsOfTypeAll<GamePlay>().FirstOrDefault();

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