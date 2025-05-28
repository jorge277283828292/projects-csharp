//Calcular Perimetro de triangulos, equilateros y isosceles.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo equilatero = new Triangulo(10);
            Triangulo isosceles = new Triangulo(10 , 3.14);

            Console.WriteLine($"El perimetro de el triangulo equilatero es {equilatero.CalcularPerimetro()}");
            Console.WriteLine($"El perimetro de el triangulo isosceles es {isosceles.CalcularPerimetro()}");

            equilatero.CalcularAltura();
            isosceles.CalcularAltura();

            Console.WriteLine($"El area de el triagulo equilatero es {equilatero.CalcularArea()}");
            Console.WriteLine($"El area de el triangulo isosceles es {equilatero.CalcularArea()}");
        }
    }
}
 