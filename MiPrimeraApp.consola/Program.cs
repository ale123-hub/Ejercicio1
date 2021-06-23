using System;
using System.Collections.Generic;

namespace MiPrimeraApp.consola //este nombre sirve para que si alguien quiere utilizar mi trabajo pueda acceder con ese nombre --> using MiPrimeraApp.consola
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Crear un objeto --> Instanciar la clase
            /*Console.WriteLine("Hello World!");
            Persona persona = new Persona();
            persona.Nombre = "Alaos";
            persona.Apellido = "Apellido1";
            persona.Saludar();*/
            Pais pais = new Pais()
            {
                Nombre = "Colombia",
                PaisId = 1
            };
            //var pais = "Ecuador";
            //Pais pais = new Pais();
            //Pais pais1;
            //var pais2; -->esta mal, no se identifica que quiere hacer. Mal declaracion de variable
            var ecuador = new Pais(); //Inferencia
            pais.Nombre = "Ecuador";
            pais.Provincia = new List<Provincia>();
            var provincia1 = new Provincia();
            provincia1.Nombre = "Guayas";
            var provincia2 = new Provincia();
            provincia2.Nombre = "Pinchincha";
            pais.Provincia = new List<Provincia>()
            {
                provincia1,
                provincia2
            };

            var canton1 = new Canton();
            canton1.Nombre = "Mejia";
            var canton2 = new Canton();
            canton2.Nombre = "Quito";
            provincia1.Canton = new List<Canton>();
            provincia1.Canton.Add(canton1);
            provincia1.Canton.Add(canton2);
            var parroquia1 = new Parroquia();
            parroquia1.Nombre = "La Arcadia";
            var parroquia2 = new Parroquia();
            parroquia2.Nombre = "Cutuglagua";
            parroquia1.Habitantes = 3000;
            parroquia2.Habitantes = 2300;
            canton1.Parroquia = new List<Parroquia>();
            canton1.Parroquia.Add(parroquia1);
            canton1.Parroquia.Add(parroquia2);

            Console.WriteLine($"Entre las dos parroquias hay: {pais.ObtenerNumeroHabitantes()}");
            //var provincia2 = new Provincia();
            /*provincia1.Nombre = "Tungurahua";
            var provincia3 = new Provincia();
            provincia1.Nombre = "El Oro";*/

            //coloco a la provincia dentro de la lista
            /*pais.Provincia.Add("Galapagos"); //Recibe un unico string/argumento.
            pais.Provincia.Add("Pichincha");
            pais.Provincia.Add("Loja");
            //Lista de cadena de caracteres, se coloca de diferente manera la sintaxis.
            //Nuevo modelo de asignacion.

            pais.Provincias = new List<string>()
            {
                "Carchi",
                "Zamora",
                "Pastaza",
                "Santo Domingo"
            };
            //arreglo y vector es lo mismo
            pais.Enteros = new int[10]
            {
                1,2,3,4,5,6,7,8,9,10
            };*/

        }
    }
}
