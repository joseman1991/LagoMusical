using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LagoMusical;
namespace LagoMusicalTest
{
    [TestClass]
    public class CancionesTest
    {
        [TestMethod]
        public void asignarSonidoTest()
        {
            Canciones c = new Canciones();
            Sonidos s= new Sonidos();
            c.asignarSonido(s);
        }

        [TestMethod]
        public void entonarCancionTest()
        {
            Canciones c = new Canciones();
            Sonidos s = new Sonidos();
            c.entonarCancion(s);
        }
    }
}
