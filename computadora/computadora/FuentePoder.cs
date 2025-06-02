using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora
{
    public abstract class FuentePoder
    {   
        public bool Encendido { get; set; }

        public FuentePoder(bool encendido)
        {
            Encendido = encendido;
        }

        public abstract void CambiarEstado(bool estado);
    }
}
//Aqui solo estaremos diciendo el estado del equipo.