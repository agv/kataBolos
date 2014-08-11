using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testsBolos
{
    [TestClass]
    public class testTiradaMala
    {
        [TestMethod]
        public void TiradaDe2En2()
        {
            kataBolos.Bolos partida = new kataBolos.Bolos();
            //Indice recorrido de las tiradas
            int i;
            for (i = 0; i < 20; i++)
            {
                partida.roll(2);
            }

            //Comprobamos que la salida es 0
            Assert.AreEqual(partida.score(), 40);
        }
    }
}
