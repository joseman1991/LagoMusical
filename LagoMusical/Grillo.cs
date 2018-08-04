using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagoMusical
{
    public class Grillo : Animal
    {
        public Grillo() : base()
        {            
            sonidosGrillo();
        }

        private void sonidosGrillo()
        {
            sonidos.Clear();
            Sonidos sonido = new Sonidos("cric-cric");
            sonidos.Add(sonido);
            sonido = new Sonidos("trri-trri");
            sonidos.Add(sonido);
            sonido = new Sonidos("bri-bri");
            sonidos.Add(sonido);
        }
    }
}
