using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablas_multiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Bienvenido a la tabla de multiplicar===");
            Console.WriteLine("Elige la tabla de multiplicar que desees: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero < 1 || numero > 13)
            {
                Console.WriteLine("Tabla de multiplar invalida, solo es posible del 1 al 12");
            }
            else
            {
                for (int i = 1; i <= 10; i++)
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}
