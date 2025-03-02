using System;

namespace Practico
{
    class Numeros
    {
        // 1. Encontrar el mayor dígito de un número
        public static void Ejercicio1()
        {
            Console.WriteLine("Ingrese un número:");
            int num = int.Parse(Console.ReadLine());
            int maxDigit = 0;

            while (num > 0)
            {
                int digit = num % 10;
                if (digit > maxDigit) maxDigit = digit;
                num /= 10;
            }

            Console.WriteLine("El mayor dígito es: " + maxDigit);
        }

        // 2. Sumar los dígitos pares de un número
        public static void Ejercicio2()
        {
            Console.WriteLine("Ingrese un número:");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                if (digit % 2 == 0) sum += digit;
                num /= 10;
            }

            Console.WriteLine("La suma de los dígitos pares es: " + sum);
        }

        // 3. Contar cuántos dígitos impares tiene un número
        public static void Ejercicio3()
        {
            Console.WriteLine("Ingrese un número:");
            int num = int.Parse(Console.ReadLine());
            int count = 0;

            while (num > 0)
            {
                int digit = num % 10;
                if (digit % 2 != 0) count++;
                num /= 10;
            }

            Console.WriteLine("Cantidad de dígitos impares: " + count);
        }

        // 4. Calcular el factorial de un número
        public static void Ejercicio4()
        {
            Console.WriteLine("Ingrese un número:");
            int num = int.Parse(Console.ReadLine());
            long factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("El factorial de " + num + " es: " + factorial);
        }

        // 5. Determinar si un número es primo
        public static void Ejercicio5()
        {
            Console.WriteLine("Ingrese un número:");
            int num = int.Parse(Console.ReadLine());
            bool esPrimo = num > 1;

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            Console.WriteLine(num + (esPrimo ? " es primo." : " no es primo."));
        }
    }
}
