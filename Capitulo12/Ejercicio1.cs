
using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDelLibro.Capitulo12
{
    class Ejercicio1
    {
        public void Accion()
        {
            int n;

            n = 10;

            for (int i = n - 1; i > 1; i--)
            {
                n *= i;
                Console.WriteLine("\n" + n);
            }

            Console.WriteLine("El factorial es: " + n);
        }
    }
}