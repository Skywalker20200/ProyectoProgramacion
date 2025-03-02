using System;

namespace Practico
{
    class Practico
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione la clase a ejecutar:");
            Console.WriteLine("1. Números");
            Console.WriteLine("2. Series");
            Console.WriteLine("3. Cadenas");
            Console.WriteLine("4. Vectores");
            Console.WriteLine("5. Matrices");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Numeros.Ejercicio1();
                    Numeros.Ejercicio2();
                    Numeros.Ejercicio3();
                    Numeros.Ejercicio4();
                    Numeros.Ejercicio5();
                    break;
                case 2:
                    Series.Ejercicio1();
                    Series.Ejercicio2();
                    Series.Ejercicio3();
                    Series.Ejercicio4();
                    Series.Ejercicio5();
                    break;
                case 3:
                    Cadenas.Ejercicio1();
                    Cadenas.Ejercicio2();
                    Cadenas.Ejercicio3();
                    Cadenas.Ejercicio4();
                    Cadenas.Ejercicio5();
                    break;
                case 4:
                    Vectores.Ejercicio1();
                    Vectores.Ejercicio2();
                    Vectores.Ejercicio3();
                    Vectores.Ejercicio4();
                    Vectores.Ejercicio5();
                    break;
                case 5:
                    Matrices.Ejercicio1();
                    Matrices.Ejercicio2();
                    Matrices.Ejercicio3();
                    Matrices.Ejercicio4();
                    Matrices.Ejercicio5();
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}

