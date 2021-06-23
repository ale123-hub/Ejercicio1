using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraApp.consola
{
    class Pais
    {
        public int PaisId { get; set; } //identificacion
        //get: se utiliza para obtener el valor de una propiedad
        //set:asignar el valor a una propiedad.
        public string Nombre { get; set; }
        //public List<String> Provincias { get; set; }
        public List<Provincia> Provincia { get; set; } = new List<Provincia>();
        //int[] Enteros;
        public int[] Enteros { get; set; } 
        public int ObtenerNumeroHabitantes()
        {
            int acumulador = 0;
            foreach (Provincia actual in Provincia)
            {
                acumulador = acumulador + actual.ObtenerNumeroHabitantes();
            }
            return acumulador;
        }
        
    }
}
