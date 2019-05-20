using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_74
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - ¿Que resultados se obtienen al realizar las operaciones siguientes? Si hay errores en la compilacion, corrijalos y de una explicacion de porque suceden.//

            int a = 10, b = 3, c = 1, d, e;

            float x, y;


            x = a / b;

            if ((a < b) && (c < a))  // El operador '&&' no se puede aplicar a operandos del tipo 'bool' e 'int'// 
            {


            }
            else
            {
                //Es nesecaria una condicion//

            }




            d = a + b++;

            e = ++a - b;

            y = a / b; // Se elimino el float ya que los datos son de tipo entero así que es irracional colocar un float ahí y los float son utlizados principalmente para declarar variables .//   

        }
    }
}
