using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testsBolos
{
    [TestClass]
    public class testCodeKataCatalogue
    {

        /*
         * Partida rescatado de http://content.codersdojo.org/code-kata-catalogue/bowling-game/
         * */

        [TestMethod]
        public void testCodeKataCatalogue133()
        {
            kataBolos.Bolos partida = new kataBolos.Bolos();
            //Indice recorrido de las tiradas


            partida.roll(1);
            partida.roll(4);

            partida.roll(4);
            partida.roll(5);

            partida.roll(6);
            partida.roll(4);

            partida.roll(5);
            partida.roll(5);

            partida.roll(10);

            partida.roll(0);
            partida.roll(1);

            partida.roll(7);
            partida.roll(3);

            partida.roll(6);
            partida.roll(4);

            partida.roll(10);

            partida.roll(2);
            partida.roll(8);
            partida.roll(6);


            //Comprobamos que la salida es 0
            Assert.AreEqual(partida.score(), 133);
        }
    }
}
