using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituradeMetodoPractica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sobreescritura de Metodo

            AnimalSalvaje as1 = new AnimalSalvaje();
            AnimalDomestico ad1 = new AnimalDomestico();
            Gato g1 = new Gato();
            Leon l1 = new Leon();
            Canario c1 = new Canario();


            List<Animal> ListaAnimales = new List<Animal>();
            ListaAnimales.Add(g1);
            ListaAnimales.Add(l1);
            ListaAnimales.Add(c1);
            ListaAnimales.Add (new Simio());

            Console.WriteLine("<< Mundo Animal >>");

            Console.WriteLine(as1.Habitat());
            Console.WriteLine(ad1.Domesticos());

            // POLIMORFISMO

            foreach (Animal item in ListaAnimales)
            {
                Console.WriteLine(item.Nombre());
                Console.WriteLine(item.Comunicarse());


            }
            Console.WriteLine("La cantidad de animales en la lista son : " + ListaAnimales.Count);

            Console.ReadKey();
           



            
        }
    }
}
