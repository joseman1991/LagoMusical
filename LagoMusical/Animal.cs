using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagoMusical
{
   public class Animal
    {
        protected List<Sonidos> sonidos;
        private int myVar;

        public int index
        {
            get { return myVar; }
            set { myVar = value; }
        }        

       

        public Animal()
        {
            this.sonidos = new List<Sonidos>();
        }


        public Sonidos getSonido()
        {
            return this.sonidos[index];
        }

        public void imprimirSonidos()
        {
            foreach (Sonidos soni in sonidos)
            {
                Console.Write(soni.sonido + "  ");
            }
            Console.WriteLine();
        }

        

        
    }
}
