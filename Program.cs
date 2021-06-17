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
            Console.Write ("Ingrese su peso: ");
            float peso = float.Parse(Console.ReadLine());
            Console.Write("Ingrese su estatura: ");
            float estatura = float.Parse(Console.ReadLine());
            Console.Write("Ingrese su Numero de Cedula: ");
            string cedula = Console.ReadLine();
            int cedula1 = int.Parse(cedula);
            Console.Write("Ingrese su Numero de Hermanos: ");
            string hermano = Console.ReadLine();
            int hermano1 = int.Parse(hermano);
            Console.Write("Ingrese su el Numero de celulares en tu hogar: ");
            string celular = Console.ReadLine();
            int celular1 = int.Parse(celular);
            Console.Write("Cuantas personas viven en tu casa: ");
            string personas = Console.ReadLine();
            int personas1 = int.Parse(personas);
            Console.Write("Cuanto dinero tienes en tu banco ");
            float dinero = float.Parse(Console.ReadLine());
            Console.Write("Cuantas veces comes al dia : ");
            string comer = Console.ReadLine();
            int comer1 = int.Parse(comer);
            var persona = new Persona();
            persona.nombre = nombre;
            persona.edad = edad1;
            persona.peso = peso;
            persona.personas = personas1;
            persona.estatura = estatura;
            persona.cedula = cedula1;
            persona.celular = celular1;
            persona.hermano = hermano1;
            persona.dinero = dinero;
            persona.comer = comer1;
            Console.WriteLine("Usted ingreso lo siguiente... ");
            Console.Write("Nombre: " + persona.nombre + "\n");
            Console.Write("Su edad es: " + persona.edad + "\n");
            Console.Write("Su Peso es : " + persona.peso + "\n\n");
            Console.Write("Su estatura es la siguiente : " + persona.estatura + "\n\n");
            Console.Write("Su numero de cedula es : " + persona.cedula + "\n\n");
            Console.Write("Su numero de hermanos son: " + persona.hermano + "\n\n");
            Console.Write("El numero de celulares en su hogar son: " + persona.celular + "\n\n");
            Console.Write("El numero de personas que viven en su hogar son: " + persona.personas + "\n\n");
            Console.Write("Tu dinero en el banco es : " + persona.dinero + "\n\n");
            Console.Write("Las veces que comes al dia son : " + persona.comer + "\n\n");
            Console.Write("Muchas Gracias :) , \nDigite cualquier tecla para terminar. ");
            Console.ReadKey();
        }
        public void metodo(string[] args)
        {
    
            if (args.Length > 0)
            {
                Console.WriteLine("hola {0} {1} {0} " + args[0] , args[1]);
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
        void SaludoInicial(){

        }
    }
}