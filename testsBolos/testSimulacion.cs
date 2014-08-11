using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testsBolos
{
    [TestClass]
    public class testSimulacion
    {
        /*
        * Partida rescatado de http://www.eyeintheskygroup.com/azar-ciencia/Teoria-de-Juegos/Juegos-No-Estrat%E9gicos_archivos/image008.jpg 
         */

        [TestMethod]
        public void Simulacion180()
        {
            kataBolos.Bolos partida = new kataBolos.Bolos();
            //Indice recorrido de las tiradas

            
            partida.roll(10);

            partida.roll(10);

            partida.roll(10);

            partida.roll(7);
            partida.roll(2);

            partida.roll(8);
            partida.roll(2);

            partida.roll(0);
            partida.roll(9);

            partida.roll(10);

            partida.roll(7);
            partida.roll(3);

            partida.roll(9);
            partida.roll(0);

            partida.roll(10);

            partida.roll(10);

            partida.roll(8);

            //Comprobamos que la salida es 0
            Assert.AreEqual(partida.score(), 180);
        
        }
    }
}
