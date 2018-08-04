using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LagoMusical
{
    public class Canciones
    {

        private static int nCancion;
        private int numero;
        private List<Sonidos> cancion;

        public Canciones()
        {
            this.cancion = new List<Sonidos>();
            nCancion++;
            numero = nCancion;
        }


        public void asignarSonido(Sonidos sonido)
        {
            cancion.Add(sonido);
        }


        public bool entonarCancion(Sonidos sonido)
        {
            cancion = cancion.OrderBy(o => o.orden).ToList();
            bool isSonido = false;
            int i;
            Sonidos get;
            for (i = 0; i < cancion.Count; i++)
            {
                get = cancion[i];
                if (sonido.sonido.Equals(get.sonido))
                {
                    isSonido = true;
                    i++;
                    break;
                }
            }

            if (isSonido)
            {
                Console.WriteLine("\nSonido encontrado en canción número {0}", numero);
                Console.WriteLine("\nReproducir\n");
                for (; i < cancion.Count; i++)
                {
                    get = cancion[i];
                    Console.WriteLine(get.sonido);
                }
            }
            return isSonido;
        }


    }
}
