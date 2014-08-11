using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testsBolos
{
    [TestClass]
    public class testPuntuajeMasRaro
    {

        /*
         * El puntaje más raro en el bowling es un juego de 292, 
         * que requiere 11 huelgas en una fila seguida de un 
         * número 2 en la última bola, y sólo se ha logrado 
         * unas 20 veces
         */
        [TestMethod]
        public void PuntuajeMasRaro292()
        {
            kataBolos.Bolos partida = new kataBolos.Bolos();
            //Indice recorrido de las tiradas
           
            for (int i = 0; i < 11; i++)
            {
                partida.roll(10);
            }

            partida.roll(2);

            //Comprobamos que la salida es 0
            Assert.AreEqual(partida.score(), 292);

        }
    }
}
