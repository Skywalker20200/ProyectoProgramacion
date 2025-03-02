using System;

namespace practico
{
    class Matrices
    {
        public void ejercicio1()
        {
            int[,] matriz = {
                { 1, 2 },
                { 3, 4 }
            };

            Console.WriteLine("Matriz:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
