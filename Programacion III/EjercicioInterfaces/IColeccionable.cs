using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    internal interface IColeccionable
    {
        String Titulo { set; get; }
        String Describir();
    }
}
