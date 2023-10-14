using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace POOUIII
{
    //Hacemos la herencia de la clase(Padre) animal en la clase (hija) gato
    public class Gato : Animal
    {
        //Atributos
        public string Color { get; set; }
        public int Patas { get; set; }

        //Constructor
        public Gato()
        {

        }

        public Gato(string nombre, int anioDeNacimiento,string color, int patas): base(nombre,anioDeNacimiento)
        {
            Color = color;
            Patas = patas; 
        }

        //Sobreescribimos el metodo y le damos su propia implementacion
        public override void HacerSonido()
        {
            Console.WriteLine("El Gato esta mauyando");
        }

        //Metodo propio de la clase gato
        public void MostrarColor()
        {
            Console.WriteLine("El color del Gato es {0}", Color);
        }
    }

    }
