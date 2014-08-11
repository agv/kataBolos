using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testsBolos
{
    [TestClass]
    public class testJuegoAleatorio
    {

        /*
         * Partida rescatado de http://www.laboleradevalladolid.es/wp-content/uploads/2011/10/Puntuacion-bowling.jpg
         */
        [TestMethod]
        public void testJuegoAleatorio188()
        {
            kataBolos.Bolos partida = new kataBolos.Bolos();
            //Indice recorrido de las tiradas

            
            partida.roll(10);

            partida.roll(3);
            partida.roll(7);

            partida.roll(8);
            partida.roll(1);

            partida.roll(10);

            partida.roll(10);

            partida.roll(10);

            partida.roll(6);
            partida.roll(0);

            partida.roll(10);

            partida.roll(10);

            partida.roll(3);
            partida.roll(7);

            partida.roll(10);

            //Comprobamos que la salida es 0
            Assert.AreEqual(partida.score(), 188);
        }
    }
}
