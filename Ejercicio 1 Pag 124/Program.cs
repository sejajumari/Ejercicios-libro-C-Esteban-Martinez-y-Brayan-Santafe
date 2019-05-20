using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Pag_124
{
    class Program
    {
        static void Main(string[] args)

        {

            double radio ;
            double resultado;

            Console.WriteLine("Digite el radio de la esfera :");
            radio = double.Parse( Console.ReadLine());



             double r1 = Math.Pow(radio, 3);
            resultado = ( (4) * (Math.PI )* r1 / 3)  ;


            Console.WriteLine($" El Volumen de la esfera es: {resultado}cm3");
            Console.ReadLine();





            Console.ReadLine();
                














        }
    }
}
