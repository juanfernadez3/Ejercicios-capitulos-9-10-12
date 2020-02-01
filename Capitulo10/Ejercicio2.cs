using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDelLibro.Capitulo10
{
    class Ejercicio2
    {
        private string Nombre;
        private int edad;
        private int curso;

        public Ejercicio2()
        {
            Nombre = "";
            edad = 0;
            curso = 0;
        }
        public void Accion()
        {
            Console.WriteLine("Ingrese Nombre");
            Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese edad");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese curso");
            curso = Convert.ToInt32(Console.ReadLine());
        }
    }
}