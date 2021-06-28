using ManejodeArbol;
using System;
using TareaArboles;

namespace TareaArbol
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new Nodo()
            {

                Valor = "/",
                nivel = 0,
                Hijos =
                {
                    new Nodo
                    {
                        Valor = "*",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "1"
                            },
                            new Nodo
                            {
                                Valor = "2"
                            }
                        }
                    },
                    new Nodo
                    {
                        Valor = "-",
                        Hijos = 
                        {
                            new Nodo
                            {
                                Valor = "4"
                            },
                            new Nodo
                            {
                                Valor = "6"
                            }
                        }
                    },
                    new Nodo
                    {
                        Valor = "+",
                        Hijos = 
                        {
                            new Nodo 
                            {
                                Valor = "1"
                            },
                            new Nodo
                            {
                                Valor = "8"
                            }

                        }
                    }



                },
            };

            ManejadorArbol controladorArbol = new ManejadorArbol();

            Console.WriteLine($"El numero de hojas del arbol es : {controladorArbol.ContadorDeHojas(raiz)}");

            Console.WriteLine($"El numero de niveles del arbol es : {controladorArbol.ContadorrDeNiveles(raiz)}");

            Console.WriteLine($"El numero de nodos del arbol es : {controladorArbol.ContadorDeNodos(raiz)}");

        }
    }
}