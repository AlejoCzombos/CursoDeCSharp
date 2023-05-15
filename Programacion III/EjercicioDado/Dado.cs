using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDado
{
    internal class Dado
    {
        Random numeroRandom = new Random();
        public int TirarDado()
        {
            return numeroRandom.Next(1,6);
        }
    }
}
