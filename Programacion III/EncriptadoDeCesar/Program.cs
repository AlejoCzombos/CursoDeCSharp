using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        string mensajeDesencriptado = "La top uno es la profe de organizacion";
        string mensajeEncriptado = EncriptarMensaje(mensajeDesencriptado, 14);
        Console.WriteLine(mensajeEncriptado);
    }
    public static string DesencriptarMensaje(string mensajeCifrado, int claveReferencia)
    {
        string alfabeto = "aábcdeéfghiíjklmnñoópqrstuúüvwxyz";
        string mensajeDesencriptado = "";
        foreach (char letra in mensajeCifrado)
        {
            if (letra == ' ')
            {
                mensajeDesencriptado += ' ';
                continue;
            }

            int posicion = (alfabeto.IndexOf(letra) + claveReferencia) % alfabeto.Length;
            if (posicion < 0)
            {
                posicion += alfabeto.Length;
            }
            char letraDesencriptada = alfabeto[posicion];
            mensajeDesencriptado += letraDesencriptada;
        }
        return mensajeDesencriptado;
    }
    public static string EncriptarMensaje(string mensaje, int claveReferencia)
    {
        string alfabeto = "aábcdeéfghiíjklmnñoópqrstuúüvwxyz";
        string mensajeEncriptado = "";
        foreach (char caracter in mensaje)
        {
            if (caracter == ' ')
            {
                mensajeEncriptado += ' ';
                continue;
            }
            int posicion = (alfabeto.IndexOf(caracter) - claveReferencia) % alfabeto.Length;
            if (posicion < 0)
            {
                posicion += alfabeto.Length;
            }
            char letraEncriptada = alfabeto[posicion];
            mensajeEncriptado += letraEncriptada;
        }
        return mensajeEncriptado;
    }
}