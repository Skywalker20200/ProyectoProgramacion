using System;

namespace practico
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1 - Números");
            Console.WriteLine("2 - Series");
            Console.WriteLine("3 - Cadenas");
            Console.WriteLine("4 - Vectores");
            Console.WriteLine("5 - Matrices");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    new Numeros().ejercicio1();
                    break;
                case 2:
                    new Series().ejercicio1();
                    break;
                case 3:
                    new Cadenas().ejercicio1();
                    break;
                case 4:
                    new Vectores().ejercicio1();
                    break;
                case 5:
                    new Matrices().ejercicio1();
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}
