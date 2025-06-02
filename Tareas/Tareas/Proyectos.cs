using System;
using System.Collections.Generic;

namespace tareas
{
    public class Proyecto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Tarea> Tareas { get; set; }

        public Proyecto()
        {
            Random random = new Random();
            Id = random.Next(1, 100);

            Console.Write("Ingrese el nombre de su proyecto: ");
            Nombre = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(Nombre))
            {
                Console.WriteLine("Error: El nombre no puede estar vacío");
                Console.Write("Ingrese el nombre de su proyecto: ");
                Nombre = Console.ReadLine();
            }

            Tareas = new List<Tarea>();
            Console.WriteLine($"Proyecto '{Nombre}' creado con ID: {Id}");
        }

        public void AgregarTarea()
        {
            Console.WriteLine("\n--- Agregar Nueva Tarea ---");

            Console.Write("Ingrese la descripción de la tarea: ");
            string descripcion = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(descripcion))
            {
                Console.WriteLine("Error: La descripción no puede estar vacía");
                Console.Write("Ingrese la descripción de la tarea: ");
                descripcion = Console.ReadLine();
            }

            Tarea nuevaTarea = new Tarea
            {
                Id = Tareas.Count + 1,
                Descripcion = descripcion
            };

            Tareas.Add(nuevaTarea);
            Console.WriteLine($"Tarea agregada: ID {nuevaTarea.Id} - {nuevaTarea.Descripcion}");
        }
    }

    public class Tarea
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
//Declaracion de las tareas con sus respectivas caractersticas.