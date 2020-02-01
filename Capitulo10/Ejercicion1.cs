using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDelLibro.Capitulo10
{

    class Ejercicion1
    {
        private string nombre;
        private string marca;
        private decimal precio;
        private int existencia;

        public Ejercicion1()
        {
            nombre = "";
            marca = "";
            precio = 0;
            existencia = 0;
        }
        public void Accion()
        {
            Console.WriteLine("Ingrese nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese marca producto");
            marca = Console.ReadLine();

            Console.WriteLine("Ingrese precio");
            precio = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingrese existencia");
            precio = Convert.ToInt32(Console.ReadLine());
        }


       
    }
}