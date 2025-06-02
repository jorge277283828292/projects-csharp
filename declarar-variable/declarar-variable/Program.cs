using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Declarar una varariable tipo Datatime y da la hora y fecha actuales
namespace declarar_variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DateTime fechahora = DateTime.Now;
            Console.WriteLine(fechahora);
        }
    }
}
