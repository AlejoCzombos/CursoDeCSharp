using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcopleActividades
{
    internal class Actividad : IComparable<Actividad>
    {
        private string nombre;
        private DateTime inicioActividad;
        private DateTime finActividad;
        private TimeSpan duracion;

        public Actividad(string nombre, DateTime inicioActividad, DateTime finActividades)
        {
            this.nombre = nombre;
            this.inicioActividad = inicioActividad;
            this.finActividad = finActividades;
            duracion = finActividad - inicioActividad;
        }

        public DateTime InicioActividad { get => inicioActividad; set => inicioActividad = value; }
        public DateTime FinActividad { get => finActividad; set => finActividad = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public int CompareTo(Actividad other)
        {
            return inicioActividad.CompareTo(other.InicioActividad);
        }

        

    }
}
