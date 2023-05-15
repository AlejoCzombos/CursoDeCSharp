using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AcopleActividades
{
    internal class CalculoSolapamiento
    {


        public static List<Actividad> Solapar(Actividad[] actividades)
        {
            List<Actividad> actividadesSolapadas = new List<Actividad>();
            //int indiceActual = 0;

            Array.Sort(actividades);
            DateTime max = DateTime.MaxValue, min = DateTime.MinValue;
            String nombres = "";

            foreach (Actividad intervalo in actividades)
            {
                max = intervalo.FinActividad;
                min = intervalo.InicioActividad;
                nombres = intervalo.Nombre;

                if(intervalo.InicioActividad > max)
                {
                    actividadesSolapadas.Add(new Actividad(nombres, min, max));
                    max = intervalo.FinActividad;
                    min = intervalo.InicioActividad;
                    nombres = intervalo.Nombre;
                }
                if (intervalo.FinActividad >= max && intervalo.InicioActividad >= min)
                {
                    max = intervalo.FinActividad;
                    nombres += intervalo.Nombre;
                }
                if (intervalo.FinActividad <= max && intervalo.InicioActividad >= min)
                {
                    nombres += intervalo.Nombre;
                }
            }

            actividadesSolapadas.Add(new Actividad(nombres, min, max));

            return actividadesSolapadas;
        }

        public static bool HaySolapamiento(Actividad actividad1, Actividad actividad2)
        {
            return actividad1.FinActividad > actividad2.InicioActividad;
        }
        /*
          for(int i = 0; i < actividades.Length; i++)
            {
                if(i == 0) {
                    actividadesSolapadas[i] = actividades[indiceActual];
                    continue;
                }

                if (HaySolapamiento(actividadesSolapadas[indiceActual], actividades[i]))
                {
                    string nombre = $"{actividadesSolapadas[indiceActual].Nombre}{actividades[i].Nombre}";
                    DateTime finActividad = actividades[i].FinActividad >
                        actividadesSolapadas[indiceActual].FinActividad
                        ? actividades[i].FinActividad
                        : actividadesSolapadas[indiceActual].FinActividad;

                    var nuevaActividad = new Actividad(nombre,
                                                        actividadesSolapadas[indiceActual].InicioActividad,
                                                        finActividad);
                    actividadesSolapadas[indiceActual] = nuevaActividad;
                }
                else
                {
                    indiceActual++;
                    actividadesSolapadas[indiceActual] = actividades[i];
                }
            }
         */
    }
}
