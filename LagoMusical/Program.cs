using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagoMusical
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal;
            Canciones cancion1 = new Canciones();
            Canciones cancion2 = new Canciones();
            Canciones cancion3 = new Canciones();
            bool isSonido = false;
            //sonidos de la rana
            animal = new Rana();

            Componer(animal, 0, 1);
            cancion1.asignarSonido(animal.getSonido());
            Componer(animal, 2, 4);
            cancion1.asignarSonido(animal.getSonido());

            Componer(animal, 1, 2);
            cancion2.asignarSonido(animal.getSonido());
            Componer(animal, 3, 4);
            cancion2.asignarSonido(animal.getSonido());

            Componer(animal, 2, 4);
            cancion3.asignarSonido(animal.getSonido());

            //sonidos de la libelula
            animal = new Libelula();
            Componer(animal, 0, 2);
            cancion1.asignarSonido(animal.getSonido());

            Componer(animal, 2, 1);
            cancion2.asignarSonido(animal.getSonido());

            Componer(animal, 1, 2);
            cancion3.asignarSonido(animal.getSonido());

            //sonidos del grillo
            animal = new Grillo();
            Componer(animal, 0, 3);
            cancion1.asignarSonido(animal.getSonido());

            Componer(animal, 1, 3);
            cancion2.asignarSonido(animal.getSonido());

            Componer(animal, 2, 1);
            cancion3.asignarSonido(animal.getSonido());

            Componer(animal, 0, 3);
            cancion3.asignarSonido(animal.getSonido());

            List<Canciones> canciones = new List<Canciones>();
            canciones.Add(cancion1);
            canciones.Add(cancion2);
            canciones.Add(cancion3);

            int op;

            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1.- Escribir Sonido");
                Console.WriteLine("2.- Salir");
                try
                {
                    Console.WriteLine("\nDigite una opción...");
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Console.Clear();
                            animal = new Rana();
                            Console.Write("Rana: ");
                            animal.imprimirSonidos();
                            animal = new Libelula();
                            Console.Write("Libelula: ");
                            animal.imprimirSonidos();
                            animal = new Grillo();
                            Console.Write("Grillo: ");
                            animal.imprimirSonidos();
                            Console.WriteLine("\nEscriba un sonido");
                            String sonido = Console.ReadLine();
                            canciones = ShuffleList(canciones);
                            for (int i = 0; i < canciones.Count; i++)
                            {
                                Canciones get = canciones[i];
                                if ((isSonido = get.entonarCancion(new Sonidos(sonido))))
                                    break;
                            }

                            if (!isSonido)
                            {
                                Console.WriteLine("Sonido no encontrado");
                            }
                            break;

                        case 2:
                            Console.WriteLine("Saliendo");
                            break;

                        default:
                            Console.WriteLine("Opcion no válida...");
                            break;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\nValor incorrecto...");
                    op = 0;
                }
                Console.WriteLine("\nPresione una tecla...");
                Console.ReadKey();
                Console.Clear();

            } while (op != 2);
        }

        private static void Componer(Animal animal, int index, int orden)
        {
            animal.index = index;
            animal.getSonido().orden = orden;
        }

        private static List<Canciones> ShuffleList<Canciones>(List<Canciones> inputList)
        {
            List<Canciones> randomList = new List<Canciones>();

            Random r = new Random();
            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = r.Next(0, inputList.Count);
                randomList.Add(inputList[randomIndex]);
                inputList.RemoveAt(randomIndex);
            }

            return randomList;
        }

    }
}
