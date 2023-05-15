using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioModa
{
    internal class Moda
    {
        //Se establece la funcion que devuelve una Tupla(Permite agrupar varios valores en una sola estructura)
        //La funcion moda tiene como parametro un array
        public (int moda, int minimo, int maximo) FuncionModa(params int[] numeros)
        {
            //Defino las variables necesarias
            int moda = 0, maximasRepeticiones = 1, repeticiones = 1;
            int minimo, maximo;

            //Utilizo las funciones Min y Max para obtener el numero minimo y maximo respectivamente
            minimo = numeros.Min();
            maximo= numeros.Max();

            //Ordeno el array asi se puede comparar los numeros que contiene mas facilmente
            Array.Sort(numeros);

            for(int i = 1; i < numeros.Length; i++)
            {
                //Si el numero actual es igual al anterior significa que hay repeticion y se incrementa esa variable
                if (numeros[i] == numeros[i - 1])
                {
                    repeticiones++;
                }
                else 
                {
                    //Si las repeticiones es mayor a las maximas repeticiones se establece el valor de repeticiones 
                    //en maximas repeticiones y se establece el valor de moda con el numero actual anterior y se resetea la variable de repeticion
                    if(repeticiones > maximasRepeticiones)
                    {
                        maximasRepeticiones = repeticiones;
                        moda = numeros[i - 1];
                    }
                    repeticiones = 1;
                }
            }
            //Se devuelve la tupla
            return (moda, minimo, maximo);
        }

    }
}
