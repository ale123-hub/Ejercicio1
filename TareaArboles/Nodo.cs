using System.Collections.Generic;
namespace TareaArboles
{
    class Nodo
    {
        private static readonly List<Nodo> nodos = new List<Nodo>();

        public List < Nodo > Nodos

        {
            get; set;
        }   = nodos;
        
        public string Valor 
        { 
            get; set; 
        }

        public List < Nodo > Hijos
        {
            get; set;
        }  = new List < Nodo > ();
        
        public int nivel;

        public int nodoRaiz = 1;
    }
}