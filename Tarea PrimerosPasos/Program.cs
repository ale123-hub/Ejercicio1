using System;

namespace Tarea_PrimerosPasos
{
    class Program1
    {
        static void Main (string[] args)
        {
            RedHulk(args);
            Hulka(args);
            ABomb(args);
            Skaar(args);
            Hulk rayosgama = new Hulk();
            rayosgama.nombre = "Bruce tambien conocido como Hulk";
            rayosgama.apellido = "Banner";
            rayosgama.edad = 47;
            rayosgama.peso = 540;
            rayosgama.cabelloColor = " de color negro y Hulk tiene el cabello verde";
            rayosgama.Hablar();

        }
        static void RedHulk(string[] args)
        {
            RedHulk rayosgama = new RedHulk();
            rayosgama.nombre2 = "Soy un General Thaddeus E. conocido como RedHulk";
            rayosgama.apellido2 = "Ross ";
            rayosgama.edad2 = 52;
            rayosgama.peso2 = 562;
            rayosgama.cabelloColor2 = " de color gris y RedHulk tiene el cabello negro";
            rayosgama.Hablar2();

        }
        static void Hulka(string[] args)
        {
            Hulka rayosgama = new Hulka();
            rayosgama.nombre3 = "Soy Jennifer, también llamada Hulka";
            rayosgama.apellido3 = "Walters";
            rayosgama.edad3 = 41;
            rayosgama.peso3 = 303;
            rayosgama.cabelloColor3 = " de color negro y Hulka tiene el cabello verde";
            rayosgama.Hablar3();

        }
        static void ABomb(string[] args)
        {
            ABomb rayosgama = new ABomb();
            rayosgama.nombre4 = "Mi nombre es Rick, Soy un nuevo integrante del equipo me conocen como A-Bomb";
            rayosgama.apellido4 = "Jones";
            rayosgama.edad4 = 15;
            rayosgama.peso4 = 520;
            rayosgama.cabelloColor4 = " de color cafe y ABomb no tiene cabello";
            rayosgama.Hablar4();

        }
        static void Skaar(string[] args)
        {
            Skaar rayosgama = new Skaar();
            rayosgama.nombre5 = "Mi nombre es Rick, Soy un nuevo integrante del equipo me conocen como A-Bomb";
            rayosgama.apellido5 = "Jones";
            rayosgama.edad5 = 15;
            rayosgama.peso5 = 520;
            rayosgama.cabelloColor5 = " de color cafe y ABomb no tiene cabello";
            rayosgama.Hablar5();

        }
    }

    class Hulk
    {
        public string nombre;
        public string apellido;
        public int edad;
        public float peso;
        public string cabelloColor;
        string emociones;
        string estado;
        int pasos;
        string golpear;

        public void Caminar()
        {
            Console.Write("¿Cuantos pasos a dado Hulk?: ");
            pasos = int.Parse(Console.ReadLine());
            pasos = pasos + 0;
            Console.WriteLine("Hulk ha caminado " + pasos + " pasos. ");
            this.Dormir();
        }

        public void Pelear()
        {
            Console.Write("¿Que villanos acaba de derrotar?: ");
            golpear = Console.ReadLine();
            var entretenimiento = "Ha cuantos enemigos a golpeado  " + golpear;
            Console.WriteLine(entretenimiento);
            Console.WriteLine("Ha golpeado " + golpear + " Hulk se ha divertido");
        }

        public void Hablar()
        {
            Console.WriteLine("Mi Nombre es: " + this.nombre + " Mi apellido es " + this.apellido + "\ntengo " + this.edad + " años, mi cabello es de color " + this.cabelloColor);
            this.Caminar();
        }
        public void Dormir()
        {
            estado = "Hulk esta durmiendo. No molestar a Hulk";
            Console.WriteLine(estado);
            this.Atacar();
        }

        public void Atacar()
        {
            emociones = "Estoy feliz, tengo muchas ganas de aplastar a mas villanos.";
            Console.WriteLine(emociones);
            this.Pelear();
        }
    }
}
