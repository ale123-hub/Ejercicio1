using System;
namespace Tarea_PrimerosPasos

{   
    class RedHulk
    {
        public string nombre2;
        public string apellido2;
        public int edad2;
        public float peso2;
        public string cabelloColor2;
        string emociones;
        string estado;
        int saltos;
        string golpear;

        public void Caminar2()
        {
            Console.Write("¿Cuantos saltos a dado RedHulk?: ");
            saltos = int.Parse(Console.ReadLine());
            saltos = saltos + 0;
            Console.WriteLine("RedHulk ha caminado " + saltos + " saltos y se a encontrado con Hulk. " + "Empieza a pelear");
            this.Dormir2();
        }

        public void Pelear2()
        {
            Console.Write("¿Cuantos golpes le dio a Hulk: ");
            golpear = Console.ReadLine();
            var entretenimiento = "Cuantos golpes a resibido Hulk  " + golpear;
            Console.WriteLine(entretenimiento);
            Console.WriteLine("Ha golpeado " + golpear + " RedHulk se ha divertido, Hulk esta muy debil para pelear");
        }

        public void Hablar2()
        {
            Console.WriteLine("Mi Nombre es: " + this.nombre2 + " Mi apellido es " + this.apellido2 + "\ntengo " + this.edad2 + " años, mi cabello es de color " + this.cabelloColor2);
            this.Caminar2();
        }
        public void Dormir2()
        {
            estado = "Hulk esta entrenando. No molestar a RedHulk";
            Console.WriteLine(estado);
            this.Atacar();
        }

        public void Atacar()
        {
            emociones = "Estoy feliz por obtener un poder igual al de Hulk, creo que puedo vencerlo en combate";
            Console.WriteLine(emociones);
            this.Pelear2();
        }
    }
}