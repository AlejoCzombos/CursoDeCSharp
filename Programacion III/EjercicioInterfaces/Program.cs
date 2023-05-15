using EjercicioInterfaces;
using System.Collections.Immutable;

internal class Program
{
    private static void Main(string[] args)
    {
        Libro[] biblioteca = new Libro[] { 
            new Libro("El Camino de los Reyes", "Brandon Sanderson"),
            new Libro("Palabras Radiantes", "Brandon Sanderson"),
            new Libro("Juramentada", "Brandon Sanderson"),
            new Libro("El Ritmo de la Guerra", "Brandon Sanderson"),
            new Libro("El Imperio Final", "Brandon Sanderson"),
            new Libro("El Pozo de la Ascencion", "Brandon Sanderson"),
            new Libro("El Heroe de las Eras", "Brandon Sanderson")
        };
        
        foreach (Libro libro in biblioteca)
        {
            Console.WriteLine(libro.Describir());
        }
        
        Array.Sort(biblioteca);
        Console.WriteLine("\nBiblioteca Ordenada por Titulo\n");

        foreach (Libro libro in biblioteca)
        {
            Console.WriteLine(libro.Describir());
        }
    }
}