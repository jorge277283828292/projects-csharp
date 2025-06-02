using System;
using tareas; 

namespace tareas 
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuarios usuario = new Usuarios();
            usuario.PedirNombre();

            Proyecto proyecto = new Proyecto();

            string respuesta;
            do
            {
                proyecto.AgregarTarea();
                Console.Write("¿Desea agregar otra tarea? (s/n): ");
                respuesta = Console.ReadLine().ToLower();
            }
            while (respuesta == "s");

            Console.WriteLine("\n--- Resumen ---");
            Console.WriteLine($"Usuario: {usuario.Name} (ID: {usuario.Id})");
            Console.WriteLine($"Proyecto: {proyecto.Nombre} (ID: {proyecto.Id})");
            Console.WriteLine("Tareas:");

            foreach (var tarea in proyecto.Tareas)
            {
                Console.WriteLine($"- ID {tarea.Id}: {tarea.Descripcion}");
            }

            Console.WriteLine("Gracias por usar el sistema. Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
//Declaracion de instancias, de Usuarios y Proyectos.
