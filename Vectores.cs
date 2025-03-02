using System;

namespace practico
{
    class Vectores
    {
        public void ejercicio1()
        {
            int[] numeros = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Elementos del vector:");
            foreach (int num in numeros)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
