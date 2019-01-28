using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe en el numero de la operacion a realizar: \n1 - Sumar\n2 - Restar\n3 - " +
                "Multiplicar\n4 - Dividir");

            String opcion = Console.ReadLine();

            if (opcion.Equals("1") || opcion.Equals("2") || opcion.Equals("3") || opcion.Equals("4"))
            {
                Calculos Resultado = new Calculos();
                Console.Write("Ingrese el primer número: ");//Pide el primer numero
                Resultado.Numero1 = double.Parse(Console.ReadLine());//Leer el numero ingresado y asignarlo a la variable

                Console.Write("Ingrese el segundo número: ");//Pide el segundo numero
                Resultado.Numero2 = double.Parse(Console.ReadLine());//Leer el segundo numero 

                if (opcion.Equals("1"))
                {
                    Console.WriteLine(Resultado.Sumar());
                }
                if (opcion.Equals("2"))
                {
                    Console.WriteLine(Resultado.Restar());
                }
                if (opcion.Equals("3"))
                {
                    Console.WriteLine(Resultado.Multiplicar());
                }
                if (opcion.Equals("4"))
                {
                    Console.WriteLine(Resultado.Dividir());
                }
            }
            else
            {
                Console.WriteLine("Jajaja que pedo, ese numero no es opcion");
            }
            Console.ReadKey();
        }
    }
}
