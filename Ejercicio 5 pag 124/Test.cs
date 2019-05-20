using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_pag_124
{
    class Test
    {

        /// <summary>
        ///  //El programa tiene más de un punto de entrada  ( " MAIN " ) definido//

        //Se borro el otro punto de entrada//
        //Se le agrego un ( "Console.ReadKey();" )//

        /// </summary>
        /// <param name="args"></param>
        public static void Main (string[] args)
        {
           




            char car = '\0';      //El caracter digitado por el usuario solo toma una letra o numero de una cadena//

            Console.WriteLine(" caracter: ");
            car = (char)Console.Read();
            Console.WriteLine(car.ToString());
            Console.ReadKey();


        }

















    }
}
