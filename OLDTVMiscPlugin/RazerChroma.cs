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

        public static void SetColorsToTextColor(ColoreColor color)
        {
            Chroma.Instance.Keyboard[Key.F1] = color;
            Chroma.Instance.Keyboard[Key.F2] = color;
            Chroma.Instance.Keyboard[Key.F3] = color;
            Chroma.Instance.Keyboard[Key.F4] = color;
            Chroma.Instance.Keyboard[Key.F5] = color;
            Chroma.Instance.Keyboard[Key.F6] = color;
            Chroma.Instance.Keyboard[Key.F7] = color;
            Chroma.Instance.Keyboard[Key.F8] = color;
            Chroma.Instance.Keyboard[Key.F9] = color;
            Chroma.Instance.Keyboard[Key.F10] = color;
            Chroma.Instance.Keyboard[Key.F11] = color;
            Chroma.Instance.Keyboard[Key.F12] = color;
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.ScrollWheel, color);
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.Backlight, color);
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.Logo, color);
            Chroma.Instance.Mousepad.SetAll(color);
            ChromaLink.Instance.SetAll(color);
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
                SetColorsToTextColor(ColoreColor.Red);
            }
            if (gameColor == "RGBA(0.000, 1.000, 0.000, 1.000)")
            {
                SetColorsToTextColor(ColoreColor.Green);
            }
            if (gameColor == "RGBA(0.000, 0.000, 1.000, 1.000)")
            {
                SetColorsToTextColor(ColoreColor.Blue);
            }
            if (gameColor == "RGBA(0.502, 0.502, 0.000, 1.000)")
            {
                SetColorsToTextColor(ColoreColor.Yellow);
            }
            if (gameColor == "RGBA(0.000, 0.600, 0.702, 1.000)")
            {
                SetColorsToTextColor(ColoreColor.FromRgb(0x00FFFF));
            }
            if (gameColor == "RGBA(0.349, 0.000, 0.800, 1.000)")
            {
                SetColorsToTextColor(ColoreColor.Purple);
            }
            if (gameColor == "RGBA(1.000, 0.200, 1.000, 1.000)")
            {
                SetColorsToTextColor(ColoreColor.Pink);
            }
            if (gameColor == "RGBA(1.000, 0.400, 0.200, 1.000)")
            {
                SetColorsToTextColor(ColoreColor.Orange);
            }

            //Set color display to off on game boot
            if (gameColor == "RGBA(0.698, 0.133, 0.133, 1.000)")
            {
                SetColorsToTextColor(ColoreColor.Black);
            }
            if (gameColor == "RGBA(0.000, 0.000, 0.000, 0.000)")
            {
                SetColorsToTextColor(ColoreColor.Black);
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