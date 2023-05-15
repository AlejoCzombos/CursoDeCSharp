using ManejoDeFechas;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Realice una clase utilitaria de manejo de tiempo y fechas que tenga al menos:
        ObtenerDiasCalendario() obtiene los días entre dos fechas
        ObtenerDiasLaborables() obtiene los días laborables entre dos fechas
        SumarDiasLaborables() obtiene una fecha sumando una cantidad de días a una fecha inicial
        Tenga en cuenta fines de semanas y feriados
        uede guardar los feriados en un arreglo*/

        int diasVividos = Calendario.ObtenerDiasCalendario(new DateTime(2000,10,20), new DateTime(2023,04,26));
        Console.WriteLine(diasVividos);

        int diasLaborables = Calendario.ObtenerDiasLaborables(new DateTime(2023, 04, 01), new DateTime(2023, 04, 09));
        Console.WriteLine(diasLaborables);

        DateTime diaLaboralNuevo = Calendario.SumarDiasLaborables(new DateTime(2023, 04, 01), 3);
        Console.WriteLine(diaLaboralNuevo);

    }
}