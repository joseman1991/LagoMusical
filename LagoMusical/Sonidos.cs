using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagoMusical
{
    public class Sonidos
    {
        private int myVar;
        private String myVar2;


        public Sonidos()
        {
            orden = 0;
            this.sonido = "";
        }

        public Sonidos(String sonido)
        {
            orden = 0;
            this.sonido = sonido;
        }


        public String sonido
        {
            get { return myVar2; }
            set { myVar2 = value; }
        }
        

        public int orden
        {
            get { return myVar; }
            set { myVar = value; }
        }
        
    }
}
