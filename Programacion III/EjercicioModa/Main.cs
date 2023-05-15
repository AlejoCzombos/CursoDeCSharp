using EjercicioModa;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Moda moda = new Moda();

        int[] numeros = {8, 6, 7, 9, 8, 5, 1, 2, 2, 15 ,64 ,45, 8, 129};

        var resultado = moda.FuncionModa(numeros);

        Console.WriteLine($"El valor de Moda es: {resultado.moda}");
        Console.WriteLine($"El valor minimo es: {resultado.minimo}");
        Console.WriteLine($"El valor maximo es: {resultado.maximo}");
    }
}