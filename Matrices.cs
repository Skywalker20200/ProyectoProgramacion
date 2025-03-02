using System;

namespace practico
{
    class Matrices
    {
        public void ejercicio1()
        {
            int[,] matriz = {
                { 15, 0, 0, 0, 0 },
                { 14, 13, 0, 0, 0 },
                { 12, 11, 10, 0, 0 },
                { 9, 8, 7, 6, 0 },
                { 5, 4, 3, 2, 1 }
            };

            ImprimirMatriz(matriz);
        }

        public void ejercicio2()
        {
            int[,] matriz = new int[5, 5];

            int valor = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    matriz[i, j] = valor++;
                }
            }

            ImprimirMatriz(matriz);
        }

        public void ejercicio3()
        {
            int[,] matriz = new int[5, 4];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = i + 1 + j * 9;
                }
            }

            ImprimirMatriz(matriz);
        }

        public void ejercicio4()
        {
            int[,] matriz = {
                { 17, 24, 1, 8, 15 },
                { 23, 5, 7, 14, 16 },
                { 4, 6, 13, 20, 22 },
                { 10, 12, 19, 21, 3 },
                { 11, 18, 25, 2, 9 }
            };

            ImprimirMatriz(matriz);
        }

        public void ejercicio5()
        {
            int[,] matriz = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    matriz[i, j] = 5 - i;
                }
            }

            ImprimirMatriz(matriz);
        }

        private void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j].ToString().PadLeft(3));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Matrices m = new Matrices();

            Console.WriteLine("Ejercicio 1:");
            m.ejercicio1();

            Console.WriteLine("Ejercicio 2:");
            m.ejercicio2();

            Console.WriteLine("Ejercicio 3:");
            m.ejercicio3();

            Console.WriteLine("Ejercicio 4:");
            m.ejercicio4();

            Console.WriteLine("Ejercicio 5:");
            m.ejercicio5();
        }
    }
}
