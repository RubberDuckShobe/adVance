using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using IllusionPlugin;

namespace adVance
{
    public class Plugin : IPlugin
    {
        //Initialize variables
        public string Name => "adVance";
        public string Version => "0.5.0";

        public static bool arePeripheralsWhite = false;

        public int oldTargetFramerate;

        public int targetFramerate;
        public bool useCustomResolution;
        public int customResolutionWidth;
        public int customResolutionHeight;
        public bool customResolutionFullscreen;
        public bool showTrueBeautyOnStartup;

        public void OnApplicationStart()
        {
            //Code to execute when the game starts
            SceneManager.activeSceneChanged += SceneManagerOnActiveSceneChanged;
            SceneManager.sceneLoaded += SceneManager_sceneLoaded;

            Console.WriteLine("[" + Name + "] OnApplicationStart is running");

            //Initialize config and get values from config or use default value and write it to config if it doesn't exist
            Config ConfigVariable = new Config("adVance");
            targetFramerate = ConfigVariable.GetInt("Configuration", "FrameRateCap", 300, true);
            useCustomResolution = ConfigVariable.GetBool("Configuration", "UseCustomResolution", false, true);
            customResolutionWidth = ConfigVariable.GetInt("Configuration", "CustomResolutionWidth", 1920, true);
            customResolutionHeight = ConfigVariable.GetInt("Configuration", "CustomResolutionHeight", 1080, true);
            customResolutionFullscreen = ConfigVariable.GetBool("Configuration", "CustomResolutionFullscreen", true, true);
            showTrueBeautyOnStartup = ConfigVariable.GetBool("Fun", "ShowTrueBeautyOnStartup", false, true);

            if (useCustomResolution == true)
            {
                Screen.SetResolution(customResolutionWidth, customResolutionHeight, customResolutionFullscreen);
            }

            if (showTrueBeautyOnStartup == true)
            {
                Application.OpenURL("https://www.youtube.com/watch?v=WNYlOL77l9s");
            }
        }

        private void SceneManagerOnActiveSceneChanged(Scene oldScene, Scene newScene)
        {
            Console.WriteLine("[" + Name + "] SceneManagerOnActiveSceneChanged is running, oldScene is " + oldScene.name + " and newScene is " + newScene.name);
            if (newScene.name == "Main (PC)")
            {
                //Code to execute when the active scene switched to the main scene

                //Adds the OLDTVResources GameObject
                new GameObject().AddComponent<OLDTVResources>();
            }
        }

        private void SceneManager_sceneLoaded(Scene scene, LoadSceneMode arg1)
        {
            Console.WriteLine("[" + Name + "] SceneManager_sceneLoaded is running");

            if (scene.name == "Scene name here")
            {
                 //Code to execute when a certain scene is loaded
            }
        }

        public void OnApplicationQuit()
        {
            //Code to execute when the game quits
            Console.WriteLine("[" + Name + "] OnApplicationQuit is running");

            SceneManager.activeSceneChanged -= SceneManagerOnActiveSceneChanged;
            SceneManager.sceneLoaded -= SceneManager_sceneLoaded;
        }

        public void OnLevelWasLoaded(int level)
        {
            //Code to execute when a certain level was loaded
            Console.WriteLine("[" + Name + "] OnLevelWasLoaded is running, level is " + level);
        }

        public void OnLevelWasInitialized(int level)
        {
            //Code to execute when a certain level was initialized
            Console.WriteLine("[" + Name + "] OnLevelWasInitialized is running, level is " + level);
        }

        public void OnUpdate()
        {
            //Code to execute whenever a graphics update occurs

            //See RazerChroma.cs
            RazerChroma.Init();
            RazerChroma.UpdateColors();

            //Custom refresh rate cap - Sets the game's maximum refresh rate to 300.
            if (Application.targetFrameRate != targetFramerate)
            {
                oldTargetFramerate = Application.targetFrameRate;
                Application.targetFrameRate = targetFramerate;
                Console.WriteLine("[" + Name + "] Set maximum framerate to " + targetFramerate + ", old framerate was " + oldTargetFramerate);
            }
        }

        public void OnFixedUpdate()
        {
            //Code to execute whenever the physics are updated
        }
    }
}