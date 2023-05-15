using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class CuentaCorriente : CuentaBancaria
    {
        private readonly float topeDescubierto;
        private float dineroDescubierto;
        public CuentaCorriente() : base() 
        { 
            topeDescubierto = 1000.0f;
            dineroDescubierto = 0;
        }
        public CuentaCorriente(float dinero) : base(dinero) 
        {
            topeDescubierto = 1000.0f;
            dineroDescubierto = 0;
        }

        public override void DepositarDinero(float dinero)
        {
            float aux = 0;
            if (dineroDescubierto > 0)
            {
                if(dinero > dineroDescubierto)
                {
                    aux = dinero - dineroDescubierto;
                    dineroDescubierto = 0;
                    DineroActual = aux;
                }
                dineroDescubierto -= dinero;
            }
            else
            {
                DineroActual += dinero;
            }
        }
        public override void ExtraerDinero(float dinero)
        {
            float aux = 0;
            if(DineroActual > dinero)
            {
                DineroActual -= dinero;
            }
            else{
                if (dineroDescubierto == 0)
                {
                    if (dinero < topeDescubierto) dineroDescubierto = dinero;
                    else Console.WriteLine("No podes sacar plata flaco, no tenes nada pobre");
                }
                else
                {
                    if(dinero + dineroDescubierto < topeDescubierto) dineroDescubierto+= dinero;
                    else Console.WriteLine("No podes sacar plata flaco, ya pasaste el limite ");
                }
            }
        }

    }
}
