using CitizenFX.Core;
using CitizenFX.Core.Native;
using System;
using System.Collections.Generic;
using Config.Reader;

namespace Client
{
    public class Main : BaseScript {

        // If its already toggled then it will be untoggled and so on
        private bool isNightVisionToggled = false;
        private bool isThermalVisionToggled = false;

        // Clothing variables
        private bool hasHelmetOn = false;

        public Main() {
            EventHandlers["hasHelmetOn1"] += new Action<string, bool>(hasCorrectHelmet1);
            EventHandlers["hasHelmetOn2"] += new Action<string, bool>(hasCorrectHelmet2);

            
            // Commands
            API.RegisterCommand("nightvision", new Action<int, List<object>, string>((src, args, raw)=> {
                checkRequirements("nightvision");
            }), false);
            API.RegisterCommand("thermalvision", new Action<int, List<object>, string>((src, args, raw) => {
                checkRequirements("thermalvision");
            }), false);

            // KEYBINDINGS //

            API.RegisterKeyMapping("nightvision", "Nattesyn", "keyboard", "");
            API.RegisterKeyMapping("thermalvision", "Termisksyn", "keyboard", "");
        }
        private void checkRequirements(string type) {
            TriggerEvent("hasPlayerItem", type);
        }

        void NightVision() {
            int playerped = API.GetPlayerPed(-1);
            if (hasHelmetOn == true) {
                if (isThermalVisionToggled == false) {
                    if (isNightVisionToggled == false) {
                        API.SetNightvision(true);
                        isNightVisionToggled = true;
                        hasHelmetOn = false;
                        shownoti("Tænder nattesyn", true, -40);
                        API.SetPedPropIndex(playerped, 0, 116, 0, true);
                    }
                    else if (isNightVisionToggled == true) {
                        API.SetNightvision(false);
                        isNightVisionToggled = false;
                        hasHelmetOn = false;
                        shownoti("Slukker nattesyn", true, -40);
                        API.ClearPedProp(playerped, 0);
                        
                    }
                    }
                }
            }

        void ThermalVision() {
            int playerped = API.GetPlayerPed(-1);
            if (hasHelmetOn == true) {
                if (isNightVisionToggled == false) {
                    if (isThermalVisionToggled == false) {
                        API.SetSeethrough(true);
                        isThermalVisionToggled = true;
                        hasHelmetOn = false;
                        shownoti("Tænder termisksyn", true, -40);
                        API.SetPedPropIndex(playerped, 0, 116, 0, true);
                    }
                    else if (isThermalVisionToggled == true) {
                        API.SetSeethrough(false);
                        isThermalVisionToggled = false;
                        hasHelmetOn = false;
                        shownoti("Slukker termisksyn", true, -40);
                        API.ClearPedProp(playerped, 0);
                    }
                }
            }
        }

        // Will work on optimizing this.
        private void hasCorrectHelmet1(string param1, bool param2) {
            hasHelmetOn = true;
            NightVision();
        }
        private void hasCorrectHelmet2(string param1, bool param2) {
            hasHelmetOn = true;
            ThermalVision();
        }

        public static void shownoti(string message, bool beep, int duration) {
            API.AddTextEntry("CH_ALERT", message);
            API.BeginTextCommandDisplayHelp("CH_ALERT");
            API.EndTextCommandDisplayHelp(0, false, beep, duration);
        }
    }
}


