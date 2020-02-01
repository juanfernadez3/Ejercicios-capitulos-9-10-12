using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDelLibro.Capitulo10
{
    class Ejercicio4
    {
        public int lados { get; set; }
        public float perimetro { get; set; }
        public float valorLados { get; set; }
        public float apotema { get; set; }

        public Ejercicio4()
        {

        }

        public Ejercicio4(int lados, float valorLados)
        {
            lados = this.lados;
            valorLados = this.valorLados;
        }
        public Ejercicio4(int lados, float perimetro, float valorLados, float apotema)
        {
            lados = this.lados;
            perimetro = this.perimetro;
            valorLados = this.valorLados;
            apotema = this.apotema;
        }
        
        public float CalcularPerimetro(int lados, float valorlados)
        {
            return (lados * valorLados);
        }

        public float CalcularArea(float apotema, float perimetro)
        {
            return (apotema * perimetro) / 2;
        }
    }
}