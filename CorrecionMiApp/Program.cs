using CorrecionMiApp;
using System;
using System.Collections.Generic;


namespace CorreccionMiApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pais pais1 = new Pais
            {
                Nombre = "Ecuador",
                PaisId = 1
            };


            pais1.Provincias = new List<Provincia>();
            var provincia1 = new Provincia
            {
                Nombre = "Guayas"
            };


            var provincia2 = new Provincia
            {
                Nombre = "Pichincha"
            };


            pais1.Provincias = new List<Provincia>(){
                    provincia1,
                    provincia2
                };

            var canton1 = new Canton
            {
                Nombre = "Mejia"
            };

            var canton2 = new Canton
            {
                Nombre = "Cayambe"
            };

            provincia2.Cantones = new List<Canton>
            {
                canton1,
                canton2
            };

            var parroquia1 = new Parroquia
            {
                Nombre = "San Sebastian"
            };

            var parroquia2 = new Parroquia
            {
                Nombre = "Gonzales Suarez"
            };

            parroquia1.Habitantes = 200;
            parroquia2.Habitantes = 500;

            canton1.Parroquias = new List<Parroquia>
            {
                parroquia1,
                parroquia2
            };

            Console.WriteLine($" el resultado de los habitantes totales de las 2 parroquias es:{pais1.ObtenerNumeroDeHabitantes()}");

        }
    }
}