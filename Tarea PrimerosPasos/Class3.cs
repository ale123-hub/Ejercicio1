using System;
namespace Tarea_PrimerosPasos

{
    class ABomb
    {
        public string nombre4;
        public string apellido4;
        public int edad4;
        public float peso4;
        public string cabelloColor4;
        string emociones;
        string estado;
        int caminar;
        string golpear;

        public void Caminar4()
        {
            Console.Write("¿Cuantos pasos a dado A-bomb?: ");
            caminar = int.Parse(Console.ReadLine());
            caminar = caminar + 0;
            Console.WriteLine("A-bomb ha caminado " + caminar + " pasos y se acaba de encontrar con integrantes de la mano ");
            this.Dormir4();
        }

        public void Pelear4()
        {
            Console.Write("¿A cuantos integrantes de la Mano golpeo A-bomb ");
            golpear = Console.ReadLine();
            var entretenimiento = "A cuantos integrantes de la Mano acaba de golpear " + golpear;
            Console.WriteLine(entretenimiento);
            Console.WriteLine("Ha golpeado " + golpear + " A-bomb ha asustado a los integrantes de Hydra");
        }

        public void Hablar4()
        {
            Console.WriteLine("Mi Nombre es: " + this.nombre4 + " Mi apellido es " + this.apellido4 + "\ntengo " + this.edad4 + " años, mi cabello es de color " + this.cabelloColor4);
            this.Caminar4();
        }
        public void Dormir4()
        {
            estado = "A-bomb esta divirtiendose grabando videos para Internet";
            Console.WriteLine(estado);
            this.Atacar();
        }

        public void Atacar()
        {
            emociones = "Estoy enojado por que nadie ve la gran persona que es Hulk ";
            Console.WriteLine(emociones);
            this.Pelear4();
        }
    }
}