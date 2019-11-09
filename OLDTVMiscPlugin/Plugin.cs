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
        public string Name => "adVance";
        public string Version => "0.0.1";

        public void OnApplicationStart()
        {
            //Code to execute when the game starts

            SceneManager.activeSceneChanged += SceneManagerOnActiveSceneChanged;
            SceneManager.sceneLoaded += SceneManager_sceneLoaded;

            Console.WriteLine("[" + Name + "] OnApplicationStart is running");
        }

        private void SceneManagerOnActiveSceneChanged(Scene oldScene, Scene newScene)
        {
            Console.WriteLine("[" + Name + "] SceneManagerOnActiveSceneChanged is running, oldScene is " + oldScene.name + " and newScene is " + newScene.name);
            if (newScene.name == "SceneNameHere")
            {
                //Code to execute when entering a certain scene
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

            //Sets the game's maximum refresh rate to 300.
            if (Application.targetFrameRate != 300)
            {
                Application.targetFrameRate = 300;
            }
        }

        public void OnFixedUpdate()
        {
            //Code to execute whenever the physics are updated
        }
    }
}
