﻿using System.Collections.Generic;

namespace EjercicoClase2
{
    class Pais
    {
        public int PaisId {get; set;}

        public string Nombre{get; set;}

        public List<Provincia> Provincias
        {get; set;} = new List<Provincia>();

        public int ObtenerNumeroDeHabitantes()
        {
            int acumulador = 0;

            foreach (Provincia actual in Provincias)
            {
                acumulador += actual.ObtenerNumeroDeHabitantes();
            }
            return acumulador;
        }
    }
}
