using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUIII
{
    //Super Clase o Clase Padre
    public class Animal
    {
        //Atributos 
        public string Nombre { get; set; }
        public int AnioDeNacimiento { get; set; }

        //Constructores
        public Animal()
        {

        }

        public Animal(string nombre, int anioDeNacimiento)
        {
            Nombre = nombre;
            AnioDeNacimiento = anioDeNacimiento;
        }

        //Metodos 
        public void CalcularEdad()
        {
            var anioActual = DateTime.Now.Year;
            Console.WriteLine($"Mi nombre es {Nombre}, tengo {anioActual - AnioDeNacimiento} años");
        }

        //Virtual para que el metodo pueda ser sobre escrito en la clase hija
        public virtual void HacerSonido() 
        {
            Console.WriteLine("El Animal esta haciendo un sonido");
        } 
    }
}
