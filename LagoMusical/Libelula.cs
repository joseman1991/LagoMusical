using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagoMusical
{
  public  class Libelula : Animal
    {
        public Libelula() : base()
        {
            sonidosLibelula();
        }

        private void sonidosLibelula()
        {
            sonidos.Clear();
            Sonidos sonido = new Sonidos("fiu");
            sonidos.Add(sonido);
            sonido = new Sonidos("plop");
            sonidos.Add(sonido);
            sonido = new Sonidos("pep");
            sonidos.Add(sonido);
        }
    }
}
