using System;
using System.Collections.Generic;

namespace MiPrimeraApp.consola
{
    class Provincia
    {
        public int ProvinciaId {get; set;}
        public string Nombre { get; set; }
        public List<Canton> Canton { get; set; } = new List<Canton>();

        public int ObtenerNumeroHabitantes()
        {
            int acumulador = 0;
            foreach (Canton actual in Canton)
            {
                acumulador = acumulador + actual.ObtenerNumeroHabitantes();
            }
            return acumulador;
        }

    }

}
