using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Pag_124
{
    class Program
    {
        static void Main(string[] args)
        {

           
            int numero;


            Console.WriteLine("El polinomio es : P = 3x^5 - 5x^3 +  2x - 7");

            Console.WriteLine("Digite el valor que le quiere dar a x : ");
             numero = int.Parse(Console.ReadLine());


            double Ex1 = Math.Pow(numero, 5);
            double Ex2 = Math.Pow(numero, 3);
            double op = 2 * numero;

            double solucion = (3 * Ex1) - (5 * Ex2) + op - 7;

            Console.Write($"Para X={numero} 3x^5-5x^3+2x-7={solucion}");




            Console.ReadKey();









        }
    }
}
