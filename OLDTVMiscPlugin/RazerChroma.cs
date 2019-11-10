using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColoreColor = Corale.Colore.Core.Color;
using Corale.Colore.Core;
using Corale.Colore.Razer.Keyboard;

namespace adVance
{
    class RazerChroma
    {
        public static void Init()
        {
            //Razer Chroma integration
            //Set the colors of all peripherals to white if they aren't already set to white
            if (Plugin.arePeripheralsWhite == false)
            {
                Chroma.Instance.SetAll(ColoreColor.White);
                Plugin.arePeripheralsWhite = true;
            }
        }

        public static void UpdateColors()
        {
            Chroma.Instance.Keyboard[Key.Left] = ColoreColor.Green;
            Chroma.Instance.Keyboard[Key.Right] = ColoreColor.Red;

            //Set first LED strip of the mouse to red
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.Strip1, ColoreColor.Red);

            //Set second LED strip of the mouse to green
            Chroma.Instance.Mouse.SetLed(Corale.Colore.Razer.Mouse.Led.Strip2, ColoreColor.Green);
        }
    }
}