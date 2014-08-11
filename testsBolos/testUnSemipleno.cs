using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testsBolos
{
    [TestClass]
    public class testUnSemipleno
    {
        [TestMethod]
        public void UnSemipleno1()
        {
            kataBolos.Bolos partida = new kataBolos.Bolos();
            //Indice recorrido de las tiradas

            partida.roll(2);
            partida.roll(8);

            partida.roll(3);
            partida.roll(2);


            for (int j = 4; j < 20; j++)
            {
                partida.roll(1);
            }

            //Comprobamos que la salida es 0
            Assert.AreEqual(partida.score(), 34);
        }
    }
}
