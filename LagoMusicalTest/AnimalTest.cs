using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LagoMusical;
namespace LagoMusicalTest
{
    [TestClass]
    public class AnimalTest
    {

        [TestMethod]
        public void TestImprimirSonido()
        {
            LagoMusical.Animal a = new LagoMusical.Rana();
            a.imprimirSonidos();
            a = new LagoMusical.Libelula();
            a.imprimirSonidos();
            a = new LagoMusical.Grillo();
            a.imprimirSonidos();
            
        }
        [TestMethod]
        public void TestGetSonido()
        {
            LagoMusical.Animal a = new LagoMusical.Rana();
            a.index = 0;
            Sonidos s = a.getSonido();
            a = new LagoMusical.Libelula();
            s = a.getSonido();
            a = new LagoMusical.Grillo();
            s = a.getSonido();

        }

    }
}
