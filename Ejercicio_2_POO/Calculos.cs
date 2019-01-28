using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_2_POO
{
    class Calculos
    {
        //Definicion de variables privadas
        private double _Numero1;
        private double _Numero2;
        
        public double Numero1
        {
            get { return _Numero1; } //Me ayuda a obtener el valor de la variable
            set { _Numero1 = value; } //Me ayuda a asignarle el valor a la variable
        }
        public double Numero2
        {
            get { return _Numero2; }
            set { _Numero2 = value; }
        }
        public double Sumar()
        {
            return Numero1 + Numero2;
        }
        public double Restar()
        {
            return Numero1 - Numero2;
        }
        public double Multiplicar()
        {
            return Numero1 * Numero2;
        }
        public object Dividir()
        {
            if (Numero2 != 0)
            {
                return Numero1 / Numero2;
            }
            else
            {
                return "Jaja no funca si divides entre 0";
            }
        }


    }
}
