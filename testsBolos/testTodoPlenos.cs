using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testsBolos
{
    [TestClass]
    public class testTodoPlenos
    {
        [TestMethod]
        public void TodoPlenos300()
        {
            kataBolos.Bolos partida = new kataBolos.Bolos();
            //Indice recorrido de las tiradas
            int i;
            for (i = 0; i < 12; i++)
            {
                partida.roll(10);
            }

            //Comprobamos que la salida es 0
            Assert.AreEqual(partida.score(), 300);
        }
    }
}
