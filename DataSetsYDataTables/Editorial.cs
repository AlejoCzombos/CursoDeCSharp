using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataSetsYDataTables
{
    internal class Editorial
    {
        private string nombre;
        private string direccion;
        private string numero;
        private long codigoEditorial;

        public Editorial(string nombre, string direccion, string numero, long codigoEditorial)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Numero = numero;
            this.CodigoEditorial = codigoEditorial;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Numero { get => numero; set => numero = value; }
        public long CodigoEditorial { get => codigoEditorial; set => codigoEditorial = value; }
    }
}
