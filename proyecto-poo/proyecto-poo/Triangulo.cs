using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_poo
{
    internal class Triangulo
    {
        //Atributos
        private double _lado;
        private double _base;
        private double _altura;

        //Construtor para triangulo equilatero
        public Triangulo(double lado)
        {
            _lado = lado;
        }

        //Construtor para triangulo isosceles
        public Triangulo(double lado, double bas) {
            _lado = lado;
            _base = bas;
        }

        //Getter, obtener dato(poder leerlo)
        public double Altura { 
            get { return _altura; } // set { _altura = value; //Declarar Setter(Poder modificar este valor.
        }

        //Getter, obtener dato(poder leerlo)
        public double Lado { 
            get { return _lado; }
        }

        //Getter, obtener dato(poder leerlo)
        public double Base {
            get { return _base; }
        }

        //Metodo // Funcion
        public double CalcularPerimetro() {
            double perimetro = 0;

            if(_base == 0) {
                perimetro = _lado * 3; 
            } else {
                perimetro = (_lado * 2) + _base;
            }
            return perimetro;

        }

        //Metodo // Funcion
        public double CalcularAltura() { 
            double altura = 0;
            if(_base == 0) { 
                altura = Math.Sqrt(Math.Pow(_lado, 2) - Math.Pow(_lado / 2, 2));
            } else { 
                altura = Math.Sqrt(Math.Pow(_lado, 2) - Math.Pow(_base / 2, 2));
            }
                return altura;
        }

        //Metodo // Funcion
         public double CalcularArea() { 
            double area = 0;
            if(_base == 0) {
                area = (_lado * _altura) / 2;
            } else {
                area = (_base * _altura) / 2;
            }
            return area;
        }

    }
}
