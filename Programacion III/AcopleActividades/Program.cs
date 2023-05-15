using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acople
{
    class Persona
    {
        public string Nombre { get; set; }
        public virtual void Saludar()
        {
            Console.WriteLine("Hola, soy una persona.");
        }

    }
    class Estudiante : Persona
    {
        public override void Saludar()
        {
            Console.WriteLine("Hola, soy una estudiante.");
        }

    }
    class Program
    {
        static void main(string[] args)
        {

            Persona persona = new Persona();
            persona.Saludar();
        }
    }
}