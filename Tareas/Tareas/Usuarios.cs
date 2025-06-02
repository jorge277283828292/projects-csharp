using System;

namespace tareas
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void PedirNombre()
        {
            Console.Write("Por favor, ingrese su nombre: ");
            string nombreIngresado = Console.ReadLine();

            Random random = new Random();
            Id = random.Next(1, 100);

            if (!string.IsNullOrWhiteSpace(nombreIngresado))
            {
                Name = nombreIngresado;
                Console.WriteLine($"Nombre asignado: {Name} ID: {Id}");
            }
            else
            {
                Console.WriteLine("Error: El nombre no puede estar vacío.");
            }
        }
    }
}
//Declaracion de Nombre y ID randoms en un rango de 1 al 100.