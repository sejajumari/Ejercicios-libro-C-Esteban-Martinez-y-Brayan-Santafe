using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_Pag_98
{
    
    class CGrados
    {

        //Modifique los limites inferior y superior de los grados centihrados, el incremento y ejecute de nuevo el programa
        //Conversion de grados centigrados a farenheit:  F = 9/5 * C + 32//



        //Definicion de constantes//

        const int limInferior = 20;     //Aqui modificamos los limites superior e inferior segun lo pide el ejercicio/
        const int limSuperior = 50;          // const int limInferior = -30;//   // const int limSuperior = 100;//
        const int Incremento = 6;
        public static float ObtenerFarenheit(float gradosC)
        {

            return  9 / 5 * gradosC + 32;

        }


        public static void Main(string[] args)
        {

            int gradosCent = limInferior; // Definicion de variables// 
            float gradosFahr = 0;


            while (gradosCent <= limSuperior)
            {
                gradosFahr = ObtenerFarenheit(gradosCent);

                System.Console.WriteLine("{0, 8:d} Centigrados {1, 8:F2} Farenheit", gradosCent, gradosFahr);  //Aqui obtenemos los grados farenheit equivalentes a grados cent//

                gradosCent += Incremento;



                Console.ReadLine();



            }





























        }

        }
    }
