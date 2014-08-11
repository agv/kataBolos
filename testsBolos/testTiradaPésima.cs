using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testsBolos
{
    [TestClass]
    public class testTiradaPésima
    {
        [TestMethod]
        public void TiradaPésima0()
        {
            kataBolos.Bolos partida = new kataBolos.Bolos();
            //Indice recorrido de las tiradas
            int i;
            for(i=0; i<20; i++)
            {
                partida.roll(0);
            }

            //Comprobamos que la salida es 0
            Assert.AreEqual(partida.score(), 0);
        }
    }
}
