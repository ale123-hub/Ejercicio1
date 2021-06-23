using CorreccionMiApp;
using System.Collections.Generic;

namespace CorrecionMiApp
{

    class Canton
    {
        public int CantonId {get; set;}

        public string Nombre {get; set;}

        public List<Parroquia> Parroquias {get; set;} = new List<Parroquia>();

        public int ObtenerNumeroDeHabitantes()

        {
            int acumulador = 0;
            foreach (Parroquia actual in Parroquias)
            {
                acumulador += actual.Habitantes;
            }
            return acumulador;
        }
    }


}