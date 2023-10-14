using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUIII
{
    //Una clase derivada de una clase derivada que a su vez es una super clase
    public class AnimalModificado : Gato
    {
        //Atributos
        public double Altura { get; set; }

        //Constructor
        public AnimalModificado()
        {

        }

        public AnimalModificado(string nombre, int anioDeNacimiento, string color, int patas, double altura) : base(nombre, anioDeNacimiento, color, patas)
        {
            Altura = altura;
        }

        //Metodos Sobreescritos
        public override void HacerSonido()
        {
            Console.WriteLine("El Animal Modificado esta haciendo sonidos");
        }

        //Metodos propios 
        public void AlturaAnimalModificado()
        {
            Console.WriteLine("La altura del Animal Modificado es: {0}", Altura);
        }

    }
}
