using System;

namespace MiPrimeraApp.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            SaludoInicial(args);
            Console.WriteLine("Bienvenido");
            Console.Write("Ingrese su nombre: ");
            var nombre = Console.ReadLine();

            int edad = IngresarEdad();

            Console.Write("Ingrese su peso: ");
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

            var persona = new Persona()
            {
                nombre = nombre,
                edad = edad,
                peso = peso,
                personas = personas1,
                estatura = estatura,
                cedula = cedula1,
                celular = celular1,
                hermano = hermano1,
                dinero = dinero,
                comer = comer1,
            };

            Console.WriteLine("Usted ingreso lo siguiente... ");
            Console.Write($"Nombre: {persona.nombre} ");
            Console.Write($"Su Edad: {persona.edad} ");
            Console.Write($"Su Peso: {persona.peso} ");
            Console.Write($"Su estatura es : {persona.estatura} ");
            Console.Write($"Su nuemero de cedula es : {persona.cedula} ");
            Console.Write($"Su numero de hermanos son:  {persona.hermano}");
            Console.Write($"El numero de celulares en su hogar son:  {persona.celular }");
            Console.Write($"El numero de personas que viven en su hogar son: {persona.personas} ");
            Console.Write($"Tu dinero en el banco es :  {persona.dinero } ");
            Console.Write($"Las veces que comes al dia son : {persona.comer }");
            Console.Write("Muchas Gracias :) , \nDigite cualquier tecla para terminar. ");
            Console.ReadKey();
        }
        public static void SaludoInicial(string[] args)
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

        static int IngresarEdad()
        {
            Console.Write("Ingrese su edad: ");
            int edad1;
            while (true)
            {
                string edad = Console.ReadLine();

                if (!int.TryParse(edad, out edad1))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };
            };
            return edad1;
        }

    }
}