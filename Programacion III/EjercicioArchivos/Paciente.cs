using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoriasClinicas
{
    public class Paciente
    {

        private string nombre;
        private string apellido;
        private string telefono;
        private string direccion;
        private string correoElectronico;

        public Paciente()
        {

        }

        public Paciente(string nombre, string apellido, string telefono, string direccion, string correoElectronico)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.correoElectronico = correoElectronico;
        }

        public Paciente(string nombre, string apellido, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
    }
}
