using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_pg_74
{
    class Program
    {
        static void Main(string[] args)
        {

            // Escriba las sentencias necesarias para evaluar la siguiente ecuacion para valores de a= 5,b  =-1.7,c = 2,d = 3.5 , k = 3 y x = 10.5 //


            int a = 5, c = 2, k = 3 ;

            double b = -1.7, d = 3.5, x = 10.5  , cua, res, tri, doc ;


            cua = Math.Pow(x, 4);
            tri = Math.Pow(x, 3);  //Se uso la herramienta matematica "math" para sacar la potenciacion de los valores de la ecuacion//
            doc = Math.Pow(x, 2);

            res = (a*cua+ b*tri -c*doc+ d*x+k);  //ax4 + bx3 - cx + dx + k//
            
            Console.WriteLine($"{res}");

            Console.ReadLine();



            





















        }
    }
}
