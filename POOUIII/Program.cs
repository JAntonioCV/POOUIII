using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Super Clase se pueden hacer instacias
            Animal animal = new Animal("Estrella", 1998);

            animal.HacerSonido();
            animal.CalcularEdad();
            Console.WriteLine();

            //Clase hija heredada desde la clase Animal
            Perro perro = new Perro("Luna", 1990, "India");

            perro.HacerSonido();
            perro.CalcularEdad();
            perro.MostrarRaza();
            Console.WriteLine();

            //Clase hija heredada desde la clase Animal
            Gato gato = new Gato("Alonso", 2000, "Verde", 5);

            gato.HacerSonido();
            gato.CalcularEdad();
            gato.MostrarColor();
            Console.WriteLine();

            //Clase de la herencia multiple herede de Gato que a su vez hereda de Animal 
            AnimalModificado animalModificado = new AnimalModificado("Modificado", 2020, "Rosado", 10, 5.5);

            animalModificado.HacerSonido();
            animalModificado.CalcularEdad();
            animalModificado.MostrarColor();
            animalModificado.AlturaAnimalModificado();

            
            Console.ReadKey();


        }
    }
}
