using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class CuentaBancaria
    {
        private int Id;
        private float dineroActual;
        Random random;
        public CuentaBancaria() 
        {
            random = new Random();
            Id1 = random.Next(0, 10000);
        }
        public CuentaBancaria(float dinero)
        { 
            random = new Random();
            Id1 = random.Next(0,10000);
            DineroActual = dinero;
        }

        public int Id1 { get => Id; set => Id = value; }
        public float DineroActual { get => dineroActual; set => dineroActual = value; }

        public virtual void DepositarDinero(float dinero)
        {
            dineroActual += dinero;
        }

        public virtual void ExtraerDinero(float dinero)
        {
            dineroActual -= dinero;
        }

    }
}
