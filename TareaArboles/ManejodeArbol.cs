using System.Linq;
using System;
using System.Collections.Generic;
using TareaArboles;

namespace ManejodeArbol
{
    internal class ManejadorArbol
    {
        internal int ContadorDeHojas(Nodo nodo)

        {
            int acumulador = 0;
            foreach (Nodo actual in nodo.Hijos)

            {
                acumulador += actual.Valor.Count() + actual.Hijos.Count();
            }

            return acumulador;
        }

        internal int ContadorDeNodos(Nodo nodo)
        {

            int acumulador = 0;
            acumulador += nodo.nodoRaiz + nodo.Hijos.Count();
            foreach (Nodo actual in nodo.Hijos)

            {

                acumulador += actual.Hijos.Count;
            }

            return acumulador;
        }
        internal int ContadorrDeNiveles(Nodo nodo)
        {

            int acumulador = 0;
            foreach (Nodo actual in nodo.Hijos)

            {

                acumulador += actual.Valor.Count();

            }

            return acumulador;
        }
       
    }
}