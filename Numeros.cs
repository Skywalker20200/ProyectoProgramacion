using System;

namespace practico
{
    class Numeros
    {
        public void ejercicio1()
        {
            Console.Write("Ingrese un número: ");
            string num = Console.ReadLine();
            int max = 0;
            foreach (char c in num)
            {
                max = Math.Max(max, c - '0');
            }
            Console.WriteLine("Mayor dígito: " + max);
        }
    }
}
