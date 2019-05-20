using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_pag_124
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombre = "";
            int año = 0;


            Console.WriteLine(" Ingrese su nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine(" Ingrese su año de nacimiento:");
            año = int.Parse(Console.ReadLine());



            Console.WriteLine($" Bienvenido:{nombre} \n Usted nacio en el año: { año} \n En el año 2030 tendra:  {2030 - año}");
        



            Console.ReadKey();


        }
    }
}
