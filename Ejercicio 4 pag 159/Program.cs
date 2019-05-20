using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_pag_159
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next();


            Console.WriteLine("Numeros a evaluar: {0} ", num);

             Console.WriteLine("Digite un Numero ");
                      int nu = int.Parse(Console.ReadLine());

            Console.WriteLine(" \n ");

                      int numf = rnd.Next(0, 10);

              Console.WriteLine(" Numero entre 0 y 10: {0} ", numf);

                         if (nu == numf)
            {
                Console.WriteLine("// Gano // ");

            }
                         else
            {
                Console.WriteLine("// Perdio // ");
            }


            Console.ReadKey();
        }
    }
}
