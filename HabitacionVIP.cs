using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_Objects_K_and_L
{
    public class HabitacionVIP : Habitacion
    {
        public HabitacionVIP(int numero) : base(numero, 2550.0)
        {
            Tarifa = 5000.0;
        }

        public void MostrarBeneficios()
        {
            Console.WriteLine("Beneficios de la habitación VIP: Acceso a spa, desayuno incluido, vista al mar.");
        }
    }
}
