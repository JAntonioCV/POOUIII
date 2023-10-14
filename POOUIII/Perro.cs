using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUIII
{
    //Hacemos la herencia de la clase(Padre) animal en la clase (hija) perro
    public class Perro: Animal
    {
        //Atributos
        public string Raza { get; set;}

        //Constructor

        public Perro()
        {

        }

        public Perro(string nombre, int anioDeNacimiento, string raza): base(nombre,anioDeNacimiento)
        {
            Raza = raza;
        }

        //Sobreescribimos el metodo y le damos su propia implementacion
        public override void HacerSonido()
        {
            Console.WriteLine("El perro esta ladrando");
        }

        //Metodo propio de la clase perro
        public void MostrarRaza()
        {
            Console.WriteLine("La Raza del Perro es {0}", Raza);
        }
    }
}
