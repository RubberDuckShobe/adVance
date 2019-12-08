using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColoreColor = Corale.Colore.Core.Color;
using Corale.Colore.Core;
using Corale.Colore.Razer.Keyboard;
using UnityEngine;

namespace adVance
{
    class RazerChroma
    {
        static string gameColor = OLDTVResources.gameTextColorRGBA.ToString();

        public static void Init()
        {
            //Razer Chroma integration
            //Set the colors of all peripherals to white if they aren't already set to white
            if (Plugin.arePeripheralsWhite == false)
            {
                Chroma.Instance.SetAll(ColoreColor.White);
                ChromaLink.Instance.SetAll(ColoreColor.White);
                Plugin.arePeripheralsWhite = true;
                Console.WriteLine("[adVance] Set all Razer peripheral colors, including Chroma Link devices to white");
            }
        }

        public static void UpdateColors()
        {

            //Set Arrow key colors
            Chroma.Instance.Keyboard[Key.Left] = ColoreColor.Green;
            Chroma.Instance.Keyboard[Key.Right] = ColoreColor.Red;

            //Update gameColor
            gameColor = OLDTVResources.gameTextColorRGBA.ToString();

            //Make the F keys display text color
            //This is probably the worst-looking code I have ever written and I'm sorry
            if (gameColor == "RGBA(1.000, 0.000, 0.000, 1.000)")
            {
                Chroma.Instance.Keyboard[Key.F1] = ColoreColor.Red;
                Chroma.Instance.Keyboard[Key.F2] = ColoreColor.Red;
                Chroma.Instance.Keyboard[Key.F3] = ColoreColor.Red;
                Chroma.Instance.Keyboard[Key.F4] = ColoreColor.Red;
                Chroma.Instance.Keyboard[Key.F5] = ColoreColor.Red;
                Chroma.Instance.Keyboard[Key.F6] = ColoreColor.Red;
                Chroma.Instance.Keyboard[Key.F7] = ColoreColor.Red;
                Chroma.Instance.Keyboard[Key.F8] = ColoreColor.Red;
                Chroma.Instance.Keyboard[Key.F9] = ColoreColor.Red;
                Chroma.Instance.Keyboard[Key.F10] = ColoreColor.Red;
                Chroma.Instance.Keyboard[Key.F11] = ColoreColor.Red;
                Chroma.Instance.Keyboard[Key.F12] = ColoreColor.Red;
                ChromaLink.Instance.SetAll(ColoreColor.Red);
            }
            if (gameColor == "RGBA(0.000, 1.000, 0.000, 1.000)")
            {
                Chroma.Instance.Keyboard[Key.F1] = ColoreColor.Green;
                Chroma.Instance.Keyboard[Key.F2] = ColoreColor.Green;
                Chroma.Instance.Keyboard[Key.F3] = ColoreColor.Green;
                Chroma.Instance.Keyboard[Key.F4] = ColoreColor.Green;
                Chroma.Instance.Keyboard[Key.F5] = ColoreColor.Green;
                Chroma.Instance.Keyboard[Key.F6] = ColoreColor.Green;
                Chroma.Instance.Keyboard[Key.F7] = ColoreColor.Green;
                Chroma.Instance.Keyboard[Key.F8] = ColoreColor.Green;
                Chroma.Instance.Keyboard[Key.F9] = ColoreColor.Green;
                Chroma.Instance.Keyboard[Key.F10] = ColoreColor.Green;
                Chroma.Instance.Keyboard[Key.F11] = ColoreColor.Green;
                Chroma.Instance.Keyboard[Key.F12] = ColoreColor.Green;
                ChromaLink.Instance.SetAll(ColoreColor.Green);
            }
            if (gameColor == "RGBA(0.000, 0.000, 1.000, 1.000)")
            {
                Chroma.Instance.Keyboard[Key.F1] = ColoreColor.Blue;
                Chroma.Instance.Keyboard[Key.F2] = ColoreColor.Blue;
                Chroma.Instance.Keyboard[Key.F3] = ColoreColor.Blue;
                Chroma.Instance.Keyboard[Key.F4] = ColoreColor.Blue;
                Chroma.Instance.Keyboard[Key.F5] = ColoreColor.Blue;
                Chroma.Instance.Keyboard[Key.F6] = ColoreColor.Blue;
                Chroma.Instance.Keyboard[Key.F7] = ColoreColor.Blue;
                Chroma.Instance.Keyboard[Key.F8] = ColoreColor.Blue;
                Chroma.Instance.Keyboard[Key.F9] = ColoreColor.Blue;
                Chroma.Instance.Keyboard[Key.F10] = ColoreColor.Blue;
                Chroma.Instance.Keyboard[Key.F11] = ColoreColor.Blue;
                Chroma.Instance.Keyboard[Key.F12] = ColoreColor.Blue;
                ChromaLink.Instance.SetAll(ColoreColor.Blue);
            }
            if (gameColor == "RGBA(0.502, 0.502, 0.000, 1.000)")
            {
                Chroma.Instance.Keyboard[Key.F1] = ColoreColor.Yellow;
                Chroma.Instance.Keyboard[Key.F2] = ColoreColor.Yellow;
                Chroma.Instance.Keyboard[Key.F3] = ColoreColor.Yellow;
                Chroma.Instance.Keyboard[Key.F4] = ColoreColor.Yellow;
                Chroma.Instance.Keyboard[Key.F5] = ColoreColor.Yellow;
                Chroma.Instance.Keyboard[Key.F6] = ColoreColor.Yellow;
                Chroma.Instance.Keyboard[Key.F7] = ColoreColor.Yellow;
                Chroma.Instance.Keyboard[Key.F8] = ColoreColor.Yellow;
                Chroma.Instance.Keyboard[Key.F9] = ColoreColor.Yellow;
                Chroma.Instance.Keyboard[Key.F10] = ColoreColor.Yellow;
                Chroma.Instance.Keyboard[Key.F11] = ColoreColor.Yellow;
                Chroma.Instance.Keyboard[Key.F12] = ColoreColor.Yellow;
                ChromaLink.Instance.SetAll(ColoreColor.Yellow);
            }
            if (gameColor == "RGBA(0.000, 0.600, 0.702, 1.000)")
            {
                Chroma.Instance.Keyboard[Key.F1] = ColoreColor.FromRgb(0x00FFFF);
                Chroma.Instance.Keyboard[Key.F2] = ColoreColor.FromRgb(0x00FFFF);
                Chroma.Instance.Keyboard[Key.F3] = ColoreColor.FromRgb(0x00FFFF);
                Chroma.Instance.Keyboard[Key.F4] = ColoreColor.FromRgb(0x00FFFF);
                Chroma.Instance.Keyboard[Key.F5] = ColoreColor.FromRgb(0x00FFFF);
                Chroma.Instance.Keyboard[Key.F6] = ColoreColor.FromRgb(0x00FFFF);
                Chroma.Instance.Keyboard[Key.F7] = ColoreColor.FromRgb(0x00FFFF);
                Chroma.Instance.Keyboard[Key.F8] = ColoreColor.FromRgb(0x00FFFF);
                Chroma.Instance.Keyboard[Key.F9] = ColoreColor.FromRgb(0x00FFFF);
                Chroma.Instance.Keyboard[Key.F10] = ColoreColor.FromRgb(0x00FFFF);
                Chroma.Instance.Keyboard[Key.F11] = ColoreColor.FromRgb(0x00FFFF);
                Chroma.Instance.Keyboard[Key.F12] = ColoreColor.FromRgb(0x00FFFF);
                ChromaLink.Instance.SetAll(ColoreColor.FromRgb(0x00FFFF));
            }
            if (gameColor == "RGBA(0.349, 0.000, 0.800, 1.000)")
            {
                Chroma.Instance.Keyboard[Key.F1] = ColoreColor.Purple;
                Chroma.Instance.Keyboard[Key.F2] = ColoreColor.Purple;
                Chroma.Instance.Keyboard[Key.F3] = ColoreColor.Purple;
                Chroma.Instance.Keyboard[Key.F4] = ColoreColor.Purple;
                Chroma.Instance.Keyboard[Key.F5] = ColoreColor.Purple;
                Chroma.Instance.Keyboard[Key.F6] = ColoreColor.Purple;
                Chroma.Instance.Keyboard[Key.F7] = ColoreColor.Purple;
                Chroma.Instance.Keyboard[Key.F8] = ColoreColor.Purple;
                Chroma.Instance.Keyboard[Key.F9] = ColoreColor.Purple;
                Chroma.Instance.Keyboard[Key.F10] = ColoreColor.Purple;
                Chroma.Instance.Keyboard[Key.F11] = ColoreColor.Purple;
                Chroma.Instance.Keyboard[Key.F12] = ColoreColor.Purple;
                ChromaLink.Instance.SetAll(ColoreColor.Purple);
            }
            if (gameColor == "RGBA(1.000, 0.200, 1.000, 1.000)")
            {
                Chroma.Instance.Keyboard[Key.F1] = ColoreColor.Pink;
                Chroma.Instance.Keyboard[Key.F2] = ColoreColor.Pink;
                Chroma.Instance.Keyboard[Key.F3] = ColoreColor.Pink;
                Chroma.Instance.Keyboard[Key.F4] = ColoreColor.Pink;
                Chroma.Instance.Keyboard[Key.F5] = ColoreColor.Pink;
                Chroma.Instance.Keyboard[Key.F6] = ColoreColor.Pink;
                Chroma.Instance.Keyboard[Key.F7] = ColoreColor.Pink;
                Chroma.Instance.Keyboard[Key.F8] = ColoreColor.Pink;
                Chroma.Instance.Keyboard[Key.F9] = ColoreColor.Pink;
                Chroma.Instance.Keyboard[Key.F10] = ColoreColor.Pink;
                Chroma.Instance.Keyboard[Key.F11] = ColoreColor.Pink;
                Chroma.Instance.Keyboard[Key.F12] = ColoreColor.Pink;
                ChromaLink.Instance.SetAll(ColoreColor.Pink);
            }
            if (gameColor == "RGBA(1.000, 0.400, 0.200, 1.000)")
            {
                Chroma.Instance.Keyboard[Key.F1] = ColoreColor.Orange;
                Chroma.Instance.Keyboard[Key.F2] = ColoreColor.Orange;
                Chroma.Instance.Keyboard[Key.F3] = ColoreColor.Orange;
                Chroma.Instance.Keyboard[Key.F4] = ColoreColor.Orange;
                Chroma.Instance.Keyboard[Key.F5] = ColoreColor.Orange;
                Chroma.Instance.Keyboard[Key.F6] = ColoreColor.Orange;
                Chroma.Instance.Keyboard[Key.F7] = ColoreColor.Orange;
                Chroma.Instance.Keyboard[Key.F8] = ColoreColor.Orange;
                Chroma.Instance.Keyboard[Key.F9] = ColoreColor.Orange;
                Chroma.Instance.Keyboard[Key.F10] = ColoreColor.Orange;
                Chroma.Instance.Keyboard[Key.F11] = ColoreColor.Orange;
                Chroma.Instance.Keyboard[Key.F12] = ColoreColor.Orange;
                ChromaLink.Instance.SetAll(ColoreColor.Orange);
            }

            //Set color display to off on game boot
            if (gameColor == "RGBA(0.698, 0.133, 0.133, 1.000)")
            {
                Chroma.Instance.Keyboard[Key.F1] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F2] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F3] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F4] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F5] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F6] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F7] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F8] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F9] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F10] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F11] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F12] = ColoreColor.Black;
                ChromaLink.Instance.SetAll(ColoreColor.Black);
            }
            if (gameColor == "RGBA(0.000, 0.000, 0.000, 0.000)")
            {
                Chroma.Instance.Keyboard[Key.F1] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F2] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F3] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F4] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F5] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F6] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F7] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F8] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F9] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F10] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F11] = ColoreColor.Black;
                Chroma.Instance.Keyboard[Key.F12] = ColoreColor.Black;
                ChromaLink.Instance.SetAll(ColoreColor.Black);
            }

            //Set first LED strip of the mouse to red
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.Strip1, ColoreColor.Green);
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.Strip2, ColoreColor.Green);
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.Strip3, ColoreColor.Green);
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.Strip4, ColoreColor.Green);
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.Strip5, ColoreColor.Green);
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.Strip6, ColoreColor.Green);
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.Strip7, ColoreColor.Green);

            //Set second LED strip of the mouse to green
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.Strip8, ColoreColor.Red);
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.Strip9, ColoreColor.Red);
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.Strip10, ColoreColor.Red);
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.Strip11, ColoreColor.Red);
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.Strip12, ColoreColor.Red);
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.Strip13, ColoreColor.Red);
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.Strip14, ColoreColor.Red);
        }
    }
}