using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora
{
    public class ComponentesInternos : FuentePoder
    {
        public ComponentesInternos(bool encendido) : base(encendido)
        {
        }
        public override void CambiarEstado(bool estado)
        {
            Encendido = estado;
        }
        public void VerificarInternos()
        {
            if (Encendido == true)
            {
                Console.WriteLine("Todos los componentes internos están funcionando correctamente.");
            }
            else
            {
                Console.WriteLine("El equipo está apagado. No se puede verificar componentes.");
            }
        }
    }
}
// Verifica si los componentes internos están disponibles dependiendo del estado de encendido.
