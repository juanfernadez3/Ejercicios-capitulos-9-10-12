using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDelLibro.Capitulo9
{
    public struct Propietario //Estructura a enlazar
    {
        public string nombrep;
        public string Apellidop;
        public string telefonop;
        public string direccionp;
    }

    public struct Mascota 
    {
        public string nombrem;
        public string marcam;
        public Propietario informacionp;
    }
    class Ejercicio3
    {
        public void Accion()
        {
            Mascota m = new Mascota();

            m.nombrem = "perro";
            m.marcam = "perro";
            m.informacionp.nombrep = "yolanda";
            m.informacionp.Apellidop = "saldivar";
            m.informacionp.direccionp = "sfm";
            m.informacionp.telefonop = "000-111-2222";

            Console.WriteLine("Nombre Mascota: {0},  Marca  o raza: {1} Nombre Propietario: {3}, telefono Propietario = {4}", m.nombrem, m.marcam, m.informacionp.nombrep, m.informacionp.telefonop);
        }

    }
}