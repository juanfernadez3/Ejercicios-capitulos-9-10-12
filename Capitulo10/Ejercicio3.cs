using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDelLibro.Capitulo10
{

    class Ejercicio3
    {
        private int lados;
        private long total;
        public Ejercicio3()
        {
            lados = 4;
        }

        public Ejercicio3(int ld1)
        {
            total = ld1 + ld1;
        }

        public void Accion()
        {
            Ejercicio3 ejemplo = new Ejercicio3();
            Console.WriteLine(ejemplo.ToString());
        }
        
    }
}