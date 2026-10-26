using System;
using System.Collections.Generic;
using System.Text;

namespace Fields___Properties_K_and_L_2
{
    internal class SmartRoom
    {
        private int _temperature;
        private string? acMode;

        public int Temperature
        {
            get { return _temperature; }

            set
            {
                if (value >= 16 && value <= 30)
                {
                    _temperature = value;


                    if (_temperature < 20)

                        acMode = "Frío Maximo";

                    else if (_temperature >= 20 && _temperature <= 25)

                        acMode = "Modo Ecologico";

                    else

                        acMode = "Ventilacion Suave";
                }
            }
        }

        public string? RoomDashboard 
        {
            get 
            { 
                return $"La habitación está a: " + Temperature + " °C, Climatización: " + acMode
                ;
            }
        }
    }
}
