using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    internal class Libro : IColeccionable, IComparable<Libro>
    {

        private String titulo;
        private String autor;

        public Libro() { }
        public Libro(String titulo, String autor) 
        {
            this.titulo = titulo;
            this.autor = autor;
        }

        public string Titulo 
        { 
            get => titulo; 
            set => titulo = value; 
        }
        public string Autor 
        { 
            get => autor; 
            set => autor = value;
        }

        public int CompareTo(Libro other)
        {
            return Titulo.CompareTo(other.Titulo);
        }

        public string Describir()
        {
            return (titulo + " de: " + autor);
        }
    }
}
