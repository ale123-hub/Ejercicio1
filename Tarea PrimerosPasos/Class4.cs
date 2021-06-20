using System;
namespace Tarea_PrimerosPasos

{
    class Skaar
    {
        public string nombre5;
        public string apellido5;
        public int edad5;
        public float peso5;
        public string cabelloColor5;
        string emociones;
        string estado;
        int caminar;
        string golpear;

        public void Caminar5()
        {
            Console.Write("¿Cuantos pasos a dado Skaar?: ");
            caminar = int.Parse(Console.ReadLine());
            caminar = caminar + 0;
            Console.WriteLine("Skaar ha caminado " + caminar + " pasos y se acaba de encontrar con el Doctor Siniestro ");
            this.Dormir5();
        }

        public void Pelear5()
        {
            Console.Write("¿Cuantos golpes le dio a Doctor Siniestro ");
            golpear = Console.ReadLine();
            var entretenimiento = "A cuantos sirvientes de la Siniestro acaba de golpear " + golpear;
            Console.WriteLine(entretenimiento);
            Console.WriteLine("Skaar ha golpeado " + golpear + " sirvientes de Siniestro");
        }

        public void Hablar5()
        {
            Console.WriteLine("Mi Nombre es: " + this.nombre5 + " Mi apellido es " + this.apellido5 + "\ntengo " + this.edad5 + " años, mi cabello es de color " + this.cabelloColor5);
            this.Caminar5();
        }
        public void Dormir5()
        {
            estado = "Skaar esta en busca de sus padres";
            Console.WriteLine(estado);
            this.Atacar();
        }

        public void Atacar()
        {
            emociones = "Estoy enojado por que no se de donde vengo ni quien fue mi padre ni mi madre";
            Console.WriteLine(emociones);
            this.Pelear5();
        }
    }
}