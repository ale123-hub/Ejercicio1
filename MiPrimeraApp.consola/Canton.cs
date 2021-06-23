using System;
using System.Collections.Generic;

namespace MiPrimeraApp.consola
{
    class Canton
    {
        public int CantonId { get; set; }
        public string Nombre { get; set; }
        public List<Parroquia> Parroquia { get; set; } = new List<Parroquia>();

        public int ObtenerNumeroHabitantes()
        {
            int acumulador = 0;
            foreach (Parroquia actual in Parroquia)
            {
                acumulador = acumulador + actual.Habitantes;
            }
            return acumulador;
        }
    }

}
