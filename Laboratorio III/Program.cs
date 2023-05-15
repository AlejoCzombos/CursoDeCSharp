namespace Laboratorio_III
{
    internal class AplicacionMatematica
    {
        private static void Main(string[] args)
        {
            float numeroA = 0, numeroB = 0;
            int opcionSeleccionada = 0;
            bool esLetraoCaracter;
            string input1, input2;

            do
            {

                Console.WriteLine("======================================================================================\n");
                Console.WriteLine("\t\t\t\tAPLICACION MATEMÁTICA\n");
                Console.WriteLine("======================================================================================\n");
                Console.WriteLine("Elija una opcion:\n");
                Console.WriteLine("1 - Mostar tabla de multiplicar de un numero ingresado");
                Console.WriteLine("2 - Mostar suma entre numero a y numero b");
                Console.WriteLine("3 - Mostar resta entre numero a y numero b");
                Console.WriteLine("4 - Mostar multiplicacion entre numero a y numero b");
                Console.WriteLine("5 - Mostar divicion entre numero a y numero b");
                Console.WriteLine("6 - Mostar resto entre numero a y numero b");
                Console.WriteLine("7 - Salir\n");
                Console.WriteLine("======================================================================================\n");
                do
                {
                    input1 = Console.ReadLine();
                    if (int.TryParse(input1, out opcionSeleccionada))
                    {
                        esLetraoCaracter = false;
                    }
                    else
                    {
                        Console.WriteLine("El numero ingresado es invalido, ingrese un numero nuevamente:");
                        esLetraoCaracter = true;
                    }

                } while (esLetraoCaracter);


                if (opcionSeleccionada == 1)
                {

                    Console.WriteLine("\nEscriba el numero del que desea saber la tabla");
                    input1 = Console.ReadLine();
                    while (!float.TryParse(input1, out numeroA))
                    {
                        Console.WriteLine("El numero ingresado es invalido, ingrese un numero nuevamente:");
                        input1 = Console.ReadLine();
                    }

                }
                else if (opcionSeleccionada == 7)
                {

                }
                else if(opcionSeleccionada > 1 && opcionSeleccionada < 7)
                {
                    do
                    {
                        Console.WriteLine("\nIngrese el numero A:");
                        input1 = Console.ReadLine();
                        Console.WriteLine("\nIngrese el numero B:");
                        input2 = Console.ReadLine();
                        if (float.TryParse(input1, out numeroA) && float.TryParse(input2, out numeroB))
                        {
                            esLetraoCaracter = false;
                        }
                        else
                        {
                            Console.WriteLine("El numero ingresado es invalido");
                            esLetraoCaracter = true;
                        }
                    } while (esLetraoCaracter);
                }


                switch (opcionSeleccionada)
                {
                    case 1:
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"{numeroA} * {i} = {numeroA * i}");
                        }
                        break;
                    case 2:
                        Console.WriteLine($"{numeroA} + {numeroB} = {numeroA + numeroB}");
                        break;
                    case 3:
                        Console.WriteLine($"{numeroA} - {numeroB} = {numeroA - numeroB}");
                        break;
                    case 4:
                        Console.WriteLine($"{numeroA} * {numeroB} = {numeroA * numeroB}");
                        break;
                    case 5:
                        Console.WriteLine($"{numeroA} / {numeroB} = {numeroA / numeroB}");
                        break;
                    case 6:
                        Console.WriteLine($"{numeroA} % {numeroB} = {numeroA % numeroB}");
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Opcion no contemplada");
                        break;
                }
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            } while (opcionSeleccionada != 7);

            Console.WriteLine("Presione cualquier tecla para cerrar la aplicacion");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
/*
Realizar una aplicacion de tipo consola en c# que según la opción 
    escogida en un menú, permita mostrar la tabla de multiplicar 
    de un número ingresado por el usuario, o solicitar que se 
    ingresen dos números "a" y "b" para mostrar las operaciones 
    suma "a+b", resta "a-b", multiplicación "a*b",
    divicion "a/b" y resto de "a%b"
    */