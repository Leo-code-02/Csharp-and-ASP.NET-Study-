using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_Objects_K_and_L
{
    public class Habitacion
    {
        private int Numero = 10;
        protected double Tarifa = 2550.0;
        public bool EstaOcupada = false;

        public Habitacion(int numero, double tarifa ) {

            Numero = numero;
            Tarifa = tarifa;
            EstaOcupada = false;
        }

        public void Reservar() { 
            
            EstaOcupada = true;
            Console.WriteLine("Habitación reservada: " + EstaOcupada);
        }
    }

}
