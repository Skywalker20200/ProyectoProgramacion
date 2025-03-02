using System;

namespace Practico
{
    class Vectores
    {
        // Ejercicio 1: Contar la cantidad de números pares en un vector
        public static void Ejercicio1()
        {
            int[] vector = { 2, 4, 5, 12, 23, 54, 3, 34, 6 };
            int count = 0;

            foreach (int num in vector)
                if (num % 2 == 0) count++;

            Console.WriteLine("Cantidad de números pares: " + count);
        }

        // Ejercicio 2: Ordenar un vector con el algoritmo MergeSort
        public static void MergeSort(int[] vector)
        {
            if (vector.Length <= 1)
                return;

            int mid = vector.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[vector.Length - mid];

            Array.Copy(vector, 0, left, 0, mid);
            Array.Copy(vector, mid, right, 0, vector.Length - mid);

            MergeSort(left);
            MergeSort(right);

            Merge(vector, left, right);
        }

        public static void Merge(int[] vector, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    vector[k++] = left[i++];
                }
                else
                {
                    vector[k++] = right[j++];
                }
            }

            while (i < left.Length)
                vector[k++] = left[i++];

            while (j < right.Length)
                vector[k++] = right[j++];
        }

        public static void Ejercicio2()
        {
            int[] vector = { 2, 4, 5, 12, 23, 54, 3, 34, 6 };
            MergeSort(vector);

            Console.WriteLine("Vector ordenado con MergeSort: " + string.Join(", ", vector));
        }

        // Ejercicio 3: Ordenar un vector con el algoritmo InsertionSort
        public static void InsertionSort(int[] vector)
        {
            for (int i = 1; i < vector.Length; i++)
            {
                int key = vector[i];
                int j = i - 1;

                while (j >= 0 && vector[j] > key)
                {
                    vector[j + 1] = vector[j];
                    j--;
                }

                vector[j + 1] = key;
            }
        }

        public static void Ejercicio3()
        {
            int[] vector = { 2, 4, 5, 12, 23, 54, 3, 34, 6 };
            InsertionSort(vector);

            Console.WriteLine("Vector ordenado con InsertionSort: " + string.Join(", ", vector));
        }

        // Ejercicio 4: Eliminar el dato x de un vector
        public static int[] EliminarX(int[] vector, int n, int x)
        {
            int[] newArray = new int[n - 1];
            int j = 0;

            for (int i = 0; i < n; i++)
            {
                if (vector[i] != x)
                {
                    newArray[j++] = vector[i];
                }
            }

            return newArray;
        }

        public static void Ejercicio4()
        {
            int[] vector = { 2, 5, 65, 23, 45, 2, 13, 45, 61 };
            int x = 2;
            int[] newVector = EliminarX(vector, vector.Length, x);

            Console.WriteLine("Vector después de eliminar el dato x (2): " + string.Join(", ", newVector));
        }

        // Ejercicio 5: Invertir una parte de un vector entre los índices a y b
        public static void Invertir(int[] vector, int a, int b)
        {
            while (a < b)
            {
                int temp = vector[a];
                vector[a] = vector[b];
                vector[b] = temp;

                a++;
                b--;
            }
        }

        public static void Ejercicio5()
        {
            int[] vector = { 2, 5, 65, 23, 45, 2, 13, 45 };
            Invertir(vector, 2, 6);

            Console.WriteLine("Vector después de invertir desde el índice 2 hasta el 6: " + string.Join(", ", vector));
        }

        // Función Main para ejecutar todos los ejercicios
        public static void Main(string[] args)
        {
            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();
            Ejercicio5();
        }
    }
}
