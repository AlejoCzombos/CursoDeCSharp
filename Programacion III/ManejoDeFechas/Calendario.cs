using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeFechas
{
    internal class Calendario
    {

        public static int ObtenerDiasCalendario(DateTime fechaInicial, DateTime fechaFinal)
        {
            TimeSpan diferencia = fechaFinal - fechaInicial;
            return diferencia.Days;
        }

        public static int ObtenerDiasLaborables(DateTime fechaInicial, DateTime fechaFinal)
        {
            DateTime diaActual = fechaInicial;
            var diferencia = fechaFinal - fechaInicial;
            int iteraciones = diferencia.Days;
            int diasLaborables = 0;

            for (int i = 0; i < iteraciones; i++)
            {
                if (diaActual.DayOfWeek == DayOfWeek.Saturday || diaActual.DayOfWeek == DayOfWeek.Sunday)
                {
                    diaActual = diaActual.AddDays(1);
                    continue;
                }
                diasLaborables++;
                diaActual = diaActual.AddDays(1);
            }
            return diasLaborables;
        }

        public static DateTime SumarDiasLaborables(DateTime fechaInicial, int diasDesplazamiento)
        {
            DateTime diaActual = fechaInicial;
            int diasContados = 0;
            while (diasContados < diasDesplazamiento + 1)
            {
                diaActual = diaActual.AddDays(1);

                if (diaActual.DayOfWeek != DayOfWeek.Saturday || diaActual.DayOfWeek != DayOfWeek.Sunday)
                {
                    diasContados++;
                }
            }
            return diaActual;
        }

    }
}
