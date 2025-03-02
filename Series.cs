using System;

namespace practico
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
            int[] serie = {1, 2, 3, 6, 7, 14, 15, 30, 31};
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
    }
}

