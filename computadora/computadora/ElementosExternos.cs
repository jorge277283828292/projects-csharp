using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora
{
    internal class ElementosExternos : FuentePoder
    {
        public ElementosExternos(bool encendido) : base(encendido)
        {
        }
        public override void CambiarEstado(bool estado)
        {
            Encendido = estado;
        }
        public void VerificarExternos()
        {
            if (Encendido == true)
            {
                Console.WriteLine("Todos los componentes externos están funcionando correctamente.");
            }
            else
            {
                Console.WriteLine("El equipo está apagado. No se puede verificar componentes externos.");
            }
        }
    }
}
// Verifica si los componentes externos están disponibles dependiendo del estado de encendido.