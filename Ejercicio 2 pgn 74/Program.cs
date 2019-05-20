using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_pgn_74
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escriba el Valor unico de "q" y de la "Q" sin consultar la tabla.//

            String msg = "Q";


            foreach (byte b in Encoding.UTF8.GetBytes(msg.ToCharArray()))
            Console.Write(b.ToString()+"\n");

            //Se uso el codigo para buscar la consulta en la tabla//

            String msgq = "q";

            foreach (byte b in Encoding.UTF8.GetBytes(msgq.ToCharArray()))
            Console.Write(b.ToString ());
            Console.ReadLine();

        }
    }
}
