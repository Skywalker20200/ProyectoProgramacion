using System;

namespace Practico
{
    class Series
    {
        public void ejercicio1()
        {
            Console.Write("Ingrese n para Fibonacci: ");
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1, temp;
            for (int i = 0; i < n - 1; i++)
            {
                temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine("Fibonacci(" + n + ") = " + a);
        }

        public void ejercicio2()
        {
            Console.Write("Ingrese n para la serie: ");
            int n = int.Parse(Console.ReadLine());
            int[] serie = { 1, 2, 3, 6, 7, 14, 15, 30, 31 };
            Console.WriteLine("Serie(" + n + ") = " + serie[n - 1]);
        }

        public void ejercicio3()
        {
            Console.Write("Ingrese n para la suma de pares: ");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma += 2 * i;
            }
            Console.WriteLine("Suma: " + suma);
        }

        public void ejercicio4()
        {
            Console.Write("Ingrese n para la serie: ");
            int n = int.Parse(Console.ReadLine());
            int valor = (1 << n) - 1;
            Console.WriteLine("Serie(" + n + ") = " + valor);
        }

        public void ejercicio5()
        {
            Console.Write("Ingrese n para la suma de términos pares: ");
            int n = int.Parse(Console.ReadLine());
            int suma = 0, num = 1, count = 0;
            while (count < n)
            {
                if (num % 2 == 0)
                {
                    suma += num;
                    count++;
                }
                num++;
            }
            Console.WriteLine("Suma de términos pares: " + suma);
        }

        static void Main(string[] args)
        {
            Series series = new Series();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Seleccione un ejercicio:");
                Console.WriteLine("1. Fibonacci");
                Console.WriteLine("2. Serie");
                Console.WriteLine("3. Suma de pares");
                Console.WriteLine("4. Serie con 2^n - 1");
                Console.WriteLine("5. Suma de términos pares");
                Console.WriteLine("6. Salir");
                Console.Write("Ingrese el número de ejercicio: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        series.ejercicio1();
                        break;
                    case 2:
                        series.ejercicio2();
                        break;
                    case 3:
                        series.ejercicio3();
                        break;
                    case 4:
                        series.ejercicio4();
                        break;
                    case 5:
                        series.ejercicio5();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
