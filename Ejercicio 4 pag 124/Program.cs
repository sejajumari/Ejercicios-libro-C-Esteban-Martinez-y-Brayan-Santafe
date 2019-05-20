using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_pag_124
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;
            int a = 3;
            int b = 5;
            int c = 2;

            Console.WriteLine("El polinomio es : P = ax^5 - bx^3 +  cx - 7");

            Console.WriteLine("Digite el valor que le quiere dar a x : ");
            numero = int.Parse(Console.ReadLine());


            double Ex1 = Math.Pow(numero, b);
            double Ex2 = Math.Pow(numero, a);
            double op = c * numero;

            double solucion = (3 * Ex1) - (5 * Ex2) + op - 7;

            Console.Write($"Para X={numero} ax^5-bx^3+cx-7=  {solucion}");




            Console.ReadKey();

















        }
    }
}
