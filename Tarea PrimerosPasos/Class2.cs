using System;
namespace Tarea_PrimerosPasos

{
    class Hulka
    {
        public string nombre3;
        public string apellido3;
        public int edad3;
        public float peso3;
        public string cabelloColor3;
        string emociones;
        string estado;
        int caminar;
        string golpear;

        public void Caminar3()
        {
            Console.Write("¿Cuantos pasos a dado Hulka?: ");
            caminar = int.Parse(Console.ReadLine());
            caminar = caminar + 0;
            Console.WriteLine("Hulka ha caminado " + caminar + " pasos y se acaba de encontrar con integrantes de Hydra ");
            this.Dormir3();
        }

        public void Pelear3()
        {
            Console.Write("¿A cuantos integrantes de Hydra golpeo Hulka ");
            golpear = Console.ReadLine();
            var entretenimiento = "A cuantos integrantes de Hydra acaba de golpear " + golpear;
            Console.WriteLine(entretenimiento);
            Console.WriteLine("Ha golpeado " + golpear + " Hulka ha asustado a los integrantes de Hydra");
        }

        public void Hablar3()
        {
            Console.WriteLine("Mi Nombre es: " + this.nombre3 + " Mi apellido es " + this.apellido3 + "\ntengo " + this.edad3 + " años, mi cabello es de color " + this.cabelloColor3);
            this.Caminar3();
        }
        public void Dormir3()
        {
            estado = "Hulka esta descansando no la molesten o se pondra furiosa";
            Console.WriteLine(estado);
            this.Atacar();
        }

        public void Atacar()
        {
            emociones = "Estoy feliz gracias a Bruce, el me curo cuando iba a morir y me dio estas grandes habilidades ";
            Console.WriteLine(emociones);
            this.Pelear3();
        }
    }
}