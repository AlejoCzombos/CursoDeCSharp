using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSetsYDataTables
{
    internal class Libro
    {
        private long ISBN;
        private long codigoEditorial;
        private string autor;
        private string titulo;

        public Libro(long iSBN, long codigoEditorial, string autor, string titulo)
        {
            ISBN1 = iSBN;
            this.CodigoEditorial = codigoEditorial;
            this.Autor = autor;
            this.Titulo = titulo;
        }

        public long ISBN1 { get => ISBN; set => ISBN = value; }
        public long CodigoEditorial { get => codigoEditorial; set => codigoEditorial = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Titulo { get => titulo; set => titulo = value; }
    }
}
