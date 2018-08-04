using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagoMusical
{
    public class Rana : Animal
    {
        public Rana()
            : base()
        {

            sonidosRana();
        }

        private void sonidosRana()
        {
            sonidos.Clear();
            Sonidos sonido = new Sonidos("brr");//0
            sonidos.Add(sonido);
            sonido = new Sonidos("birip");//1
            sonidos.Add(sonido);
            sonido = new Sonidos("brrah");//2
            sonidos.Add(sonido);
            sonido = new Sonidos("croac");//3
            sonidos.Add(sonido);
        }

    }
}
