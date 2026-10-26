using System;
using System.Collections.Generic;
using System.Text;



namespace Fields___Properties_K_and_L
{
    internal class Producto
    {
        private string? _codigoReferencia;
        private double _precio;
        private int _stock;
        public string? Nombre { get; set; }

        public string? CodigoReferencia
        {
            get { return _codigoReferencia; }
        }

        public double Precio
        {
            get { return _precio; }

            set
            {
                if (value >= 0)
                {
                    _precio = value;
                }

                else
                {
                    Console.WriteLine("Error: El precio no puede ser negativo.");
                }
            }
        }
        public int Stock
        {
            get { return _stock; }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: El stock no puede ser negativo");
                }
                else
                {
                    _stock = value;
                }

            }
        }


        public Producto(String nombre, String codigoReferencia, double precio, int stock) 
        {
            Nombre = nombre;
            Precio = precio;
            _codigoReferencia = codigoReferencia;
            Stock = stock;
        }
    }
}







