using System;

namespace MiPrimeraApp.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.Write("Ingrese su nombre: ");
            var nombre = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            string edad = Console.ReadLine();
            int edad1 = int.Parse(edad);
            Console.Write("Ingrese su peso: ");
            float peso = float.Parse(Console.ReadLine());
            var persona = new Persona();
            persona.nombre = nombre;
            persona.edad = edad1;
            persona.peso = peso;
            Console.WriteLine("Usted ingreso lo siguiente... ");
            Console.Write("Nombre: " + persona.nombre);
            Console.Write("Su edad es: " + persona.edad + "\n");
            Console.Write("Su Peso es : " + persona.peso + "\n\n");
            Console.Write("Muchas Gracias :) , \nDigite cualquier tecla para terminar. ");
            Console.ReadKey();
        }
        public void metodo(string[] args)
        {

            if (args.Length > 0)
            {
                Console.WriteLine("hola {0} {1} {0} " + args[0], args[1]);
            }
            else
            {
                Console.WriteLine("Hola Desconocido ");
            }
            Console.WriteLine("Como estas?");
            var estado = Console.ReadLine();
            Console.WriteLine("mmmm, entiendo!");
            var date = new DateTime();
            Console.WriteLine(date);
        }
        void SaludoInicial()
        {

        }
    }
}