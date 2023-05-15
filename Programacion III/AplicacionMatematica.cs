namespace Laboratorio_III
{
    internal class AplicacionMatematica
    {
        private static void Main(string[] args)
        {
            float[] alturas = new float[10];
            string input;
            float mediaDeAlturas = 0, varianzaDeAlturas = 0, desviacionEstandar = 0, rangoInferior = 0, rangoSuperior = 0;

            //Pedir al usuario las 10 alturas y comprobar si son o no Integers
            for (int i = 0; i < alturas.Length; i++)
            {
                Console.WriteLine("Ingrese la altura numero " + (i + 1) + " :");
                input = Console.ReadLine();
                while (!float.TryParse(input, out alturas[i]))
                {
                    Console.WriteLine("\nNumero ingresado es invalido, ingrese un numero nuevamente: ");
                    input = Console.ReadLine();
                }
                Console.Clear();
            }

            //calcular la media con la funcion Average
            mediaDeAlturas = alturas.Average();

            //calcular la varianza de altura con una funcion lambda
            varianzaDeAlturas = alturas.Sum(a => (float)Math.Pow(a - mediaDeAlturas, 2));

            //Calcular la desviacion estandar una vez obrenido la varianza
            desviacionEstandar = (float)Math.Sqrt(varianzaDeAlturas / alturas.Length);

            Console.WriteLine("\nLa media de las alturas es igual a: " + mediaDeAlturas + "\n");
            Console.WriteLine("La desviacion estandar de las alturas es igual a: " + desviacionEstandar + "\n");

            //Imprimir las alturas que estan debajo de la media
            Console.Write("Las alturas que se encuentran debajo de la media son: ");
            for (int i = 0; i < alturas.Length; i++)
            {
                if (alturas[i] < mediaDeAlturas) Console.Write(alturas[i] + " ");
            }

            //Imprimir las alturas que estan por encima de la media
            Console.Write("\n\nLas alturas que se encuentran por encima de la media son: ");
            for (int i = 0; i < alturas.Length; i++)
            {
                if (alturas[i] > mediaDeAlturas) Console.Write(alturas[i] + " ");
            }

            rangoInferior = mediaDeAlturas - desviacionEstandar;
            rangoSuperior = mediaDeAlturas + desviacionEstandar;

            //Imprimir las alturas que se encuentran dentro del rango de la desviacion estandar
            Console.Write($"\n\nLas alturas que se encuentran dentro del rango definido ({rangoInferior} / {rangoSuperior}) dentro de la desviacion estandar son: " );
            foreach (float altura in alturas)
            {
                if (altura >= rangoInferior && altura <= rangoSuperior) Console.Write(altura + " ");
            }

            Console.WriteLine("\n\n*Presione cualquier tecla para cerrar la aplicacion*");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}