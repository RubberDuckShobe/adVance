using System;
using System.Collections;
using System.Linq;
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

        private bool showSettings = false;
        public Rect windowRect = new Rect(20, 20, 500, 600);

        public static string currentGameMode = null;

        void Awake()
        {
            StartCoroutine(GetRequired());
            Console.WriteLine("[adVance] OLDTVResources.Awake() ran");

            //Initialize Harmony
            var harmony = HarmonyInstance.Create("com.RubberDuckShobe.adVance.patches");
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
            if (currentGameMode == "Normal")
            {
                gameTextColorRGBA = gp.ColorText.GetComponent<TextMesh>().color;
            }
            if (currentGameMode == "Infinite")
            {
                gameTextColorRGBA = infinitemodegp.ColorText.GetComponent<TextMesh>().color;
            }
            if (currentGameMode == null)
            {
                gameTextColorRGBA = UnityEngine.Color.black;
            }


            currentFrequency = MonitorFreqTimer.currentFreq;
        }

        void OnGUI()
        {
            //Detect if player pressed O button
            if (Event.current.Equals(Event.KeyboardEvent("O")))
            {
                Console.WriteLine("[adVance] Player just pressed the O button");
                if (!showSettings) showSettings = true;
                else showSettings = false;
            }

            if (showSettings)
            {
                // Register the window
                windowRect = GUI.Window(0, windowRect, DrawSettingsWindow, "adVance In-Game menu");
            }
        }

        void DrawSettingsWindow(int windowID)
        {
            // Make a very long rect that is 20 pixels tall.
            // This will make the window be resizable by the top
            // title bar - no matter how wide it gets.
            GUI.DragWindow(new Rect(0, 0, 10000, 20));
            GUI.Label(new Rect(5, 25, 450, 20), "This menu is basically useless right now, but you can help change this!");
            if (GUI.Button(new Rect(5, 50, 185, 20), "Current OLDTV World Record"))
                Application.OpenURL("https://www.youtube.com/watch?v=WNYlOL77l9s");
            if (GUI.Button(new Rect(195, 50, 100, 20), "Report a bug"))
                Application.OpenURL("https://github.com/RubberDuckShobe/adVance/issues/new");
        }

        //Harmony stuff, this is what runs adVance code before or after game functions and can even replace them entirely
        [HarmonyPatch(typeof(GamePlay))]
        [HarmonyPatch("Fail")]
        class OnNormalModeFail
        {
            static void Prefix()
            {
                Console.WriteLine("[adVance] Player just failed a normal mode game");
                currentGameMode = null;
                if (currentGameMode == null)
                {
                    Console.WriteLine("[adVance] Current game mode is null");
                }
                else
                {
                    Console.WriteLine("[adVance] Current game mode is " + currentGameMode);
                }
            }
        }

        [HarmonyPatch(typeof(GamePlay))]
        [HarmonyPatch("Start")]
        class OnNormalModeStart
        {
            static void Prefix()
            {
                Console.WriteLine("[adVance] Player just started a normal mode game");
                currentGameMode = "Normal";
                if (currentGameMode == null)
                {
                    Console.WriteLine("[adVance] Current game mode is null");
                }
                else
                {
                    Console.WriteLine("[adVance] Current game mode is " + currentGameMode);
                }
            }
        }

        [HarmonyPatch(typeof(InfiniteModeGamePlay))]
        [HarmonyPatch("Fail")]
        class OnInfiniteModeFail
        {
            static void Prefix()
            {
                Console.WriteLine("[adVance] Player just failed an infinite mode game");
                currentGameMode = null;
                if (currentGameMode == null)
                {
                    Console.WriteLine("[adVance] Current game mode is null");
                }
                else
                {
                    Console.WriteLine("[adVance] Current game mode is " + currentGameMode);
                }
            }
        }

        [HarmonyPatch(typeof(InfiniteModeGamePlay))]
        [HarmonyPatch("Start")]
        class OnInfiniteModeStart
        {
            static void Prefix()
            {
                Console.WriteLine("[adVance] Player just started an infinite mode game");
                currentGameMode = "Infinite";
                if (currentGameMode == null)
                {
                    Console.WriteLine("[adVance] Current game mode is null");
                }
                else
                {
                    Console.WriteLine("[adVance] Current game mode is " + currentGameMode);
                }
            }
        }
    }
}