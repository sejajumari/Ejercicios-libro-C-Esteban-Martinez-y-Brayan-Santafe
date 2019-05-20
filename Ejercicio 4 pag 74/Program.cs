using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_pag_74
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Digite el valor de a");
            double r1= double.Parse(Console.ReadLine());     // Se convirtieron las variables en tipo decimal//

            Console.WriteLine("Digite el valor de b");
            double r2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor de c");
            double r3= double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor de d");
            double r4 = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite el valor de x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");





            Ejercicio4_pag_74 Ejer4 = new Ejercicio4_pag_74 (r1, r2, r3, r4);  //La clase o el constructor toma las variables y desarrollla las operaciones//

            Console.WriteLine($" Su resultado es :"+Ejer4.ValorPara(x));

            Console.ReadLine();




        }
    }
}
