using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora
{
    internal class Program
    {
        static void Main(string[] args)
            {
                Console.WriteLine($"El estado de la computadora actualmente es ¿[Encendido] o [apagado]?");
                string respuesta = Console.ReadLine()?.Trim().ToLower();    

                bool estaEncendida = respuesta == "encendido";

                ComponentesInternos misInternos = new ComponentesInternos(estaEncendida);
                ElementosExternos misExternos = new ElementosExternos(estaEncendida);
                Console.WriteLine(new string('=', 60));
                MostrarEstado(misInternos, misExternos);
                Console.WriteLine(new string('=', 60));

                {
                Console.WriteLine($"¿El usuario esta sentado de forma correcta? [Si] o [No]");
                string posicion = Console.ReadLine()?.Trim().ToLower();

                if(posicion == "si")
                {
                    Console.WriteLine("Perfecto, ya puedes usar tu equipo perfectamente");
                    MostrarEstado(misInternos, misExternos);
                } else
                {
                    Console.WriteLine("Debes sentarte de forma correcta para usar el equipo");
                    Console.WriteLine("");
                    Console.WriteLine("¿Ya estas sentado de forma correcta? [Si] o [No]");
                    string respuestafinal = Console.ReadLine()?.Trim().ToLower();
                    switch(respuestafinal) {
                        case "si":
                            Console.WriteLine("Perfecto, ya puedes usar tu equipo perfectamente");
                            MostrarEstado(misInternos, misExternos);
                            break;
                        case "no":
                            Console.WriteLine("Lo siento pero no podras usar el equipo hoy");
                            break;
                    }
                }
            }
        }
        static void MostrarEstado(ComponentesInternos internos, ElementosExternos externos)
        {
            externos.VerificarExternos();
            internos.VerificarInternos();
        }

    }
}
