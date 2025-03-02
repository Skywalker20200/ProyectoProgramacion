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
    }
}
