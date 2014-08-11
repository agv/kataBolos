using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kataBolos
{
    public class Bolos
    {
        //Variable para llevar la puntuación actual
        int puntuacion = 0;
        //Vector donde se guarda el numero de bolos derribados por tirada
        int[] tiradas = new int[21];
        // Contador de la tirada actual
        int tirActual = 0;

        //Definimos los dos métodos que se piden.
        public void roll(int pins)
        {
        //Asignamos a la actual tirada el numero de bolos
            tiradas[tirActual] = pins;
            tirActual++;
        }

        public int score()
        {
            //Variable para conocer la tanda, si tenemos un pleno avanzamos a la siguiente tirada.
            int tandaActual = 0;
            //Recorremos las tandas con sus respectivas tiradas ( 2*9 + 3)
            for (int i = 0; i < 10; i++ )
            {
                if(pleno(tandaActual)){
                    //Sumamos 10 + las dos tiradas siguientes.
                    puntuacion += 10;
                    puntuacion += tiradas[tandaActual + 1] + tiradas[tandaActual + 2];
                    tandaActual++;
                }
                else if(semiPleno(tandaActual))
                {
                    puntuacion += 10;
                    puntuacion += tiradas[tandaActual + 2];
                    tandaActual += 2;
                }
                else {
                    puntuacion += tiradas[tandaActual] + tiradas[tandaActual + 1];
                    tandaActual += 2;
                }
            }
            return puntuacion;
        }

        // Funciones booleanas para saber si es o no pleno y semipleno

        public bool pleno(int tanda)
        {
            return tiradas[tanda] == 10;
        }
        public bool semiPleno(int tanda)
        {
            return tiradas[tanda] + tiradas[tanda+1] == 10;
        }

        static void Main(string[] args)
        {

        }
    }
}
