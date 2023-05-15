using EjercicioDado;

internal class Program
{
    private static void Main(string[] args)
    {
        Dado dado = new Dado();
        int apuesta = 0;
        ConsoleKeyInfo respuesta;
        do
        {
            Console.WriteLine("Ingrese el numero al que desea apostar");
            apuesta = int.Parse(Console.ReadLine());
            Console.WriteLine("Pulse cualquier tecla para tirar el dado");
            Console.ReadKey();
            Console.Clear();
            int numeroDado = dado.TirarDado();
            Console.WriteLine("El numero que salio es " + numeroDado);
            if (numeroDado == apuesta)
            {
                Console.WriteLine("GANASTE!");
            }
            else
            {
                Console.WriteLine("Perdiste pibe");
            }
            Console.WriteLine("Desea seguir jugando?\n1) si\n2) no");
            respuesta = Console.ReadKey();
            Console.Clear();
        } while (respuesta.Key == ConsoleKey.D1);
    }
}