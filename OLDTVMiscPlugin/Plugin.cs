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
using ColoreColor = Corale.Colore.Core.Color;
using Corale.Colore.Core;
using Corale.Colore.Razer.Keyboard;

namespace adVance
{
    public class Plugin : IPlugin
    {
        public string Name => "adVance";
        public string Version => "0.1.1";
        public bool arePeripheralsWhite = false;
        public int oldTargetFramerate;

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

            //Razer Chroma integration
            //Set the colors of all peripherals to white if they aren't already set to white
            if (arePeripheralsWhite == false)
            {
                Console.WriteLine("[" + Name + "] Set all Razer peripheral colors to white");
                Chroma.Instance.SetAll(ColoreColor.White);
                arePeripheralsWhite = true;
            }
            
            Chroma.Instance.Keyboard[Key.Left] = ColoreColor.Green;
            Chroma.Instance.Keyboard[Key.Right] = ColoreColor.Red;

            //Set first LED strip of the mouse to red
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.Strip1, ColoreColor.Red);

            //Set second LED strip of the mouse to green
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.Strip2, ColoreColor.Green);

            //Custom refresh rate cap - Sets the game's maximum refresh rate to 300.
            if (Application.targetFrameRate != 300)
            {
                oldTargetFramerate = Application.targetFrameRate;
                Application.targetFrameRate = 300;
                Console.WriteLine("[" + Name + "] Set maximum framerate to " + Application.targetFrameRate + ", old framerate was " + oldTargetFramerate);
            }
        }

        public void OnFixedUpdate()
        {
            //Code to execute whenever the physics are updated
        }
    }
}