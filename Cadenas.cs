using System;

namespace Practico
{
    class Cadenas
    {
        public static void Ejercicio1()
        {
            Console.WriteLine("Ingrese una frase:");
            string frase = Console.ReadLine();
            string[] palabras = frase.Split(' ');

            Console.WriteLine("Cantidad de palabras: " + palabras.Length);
        }

        public static void Ejercicio2()
        {
            Console.WriteLine("Ingrese una frase:");
            string frase = Console.ReadLine();
            string resultado = EliminarVoc(frase);
            Console.WriteLine("Frase sin vocales: " + resultado);
        }

        public static void Ejercicio3()
        {
            Console.WriteLine("Ingrese una frase:");
            string frase = Console.ReadLine();
            string palabraMasLarga = CadenaMasLarga(frase);
            Console.WriteLine("La palabra más larga es: " + palabraMasLarga);
        }

        public static void Ejercicio4()
        {
            Console.WriteLine("Ingrese una frase:");
            string frase = Console.ReadLine();
            string resultado = EliminaPrim(frase);
            Console.WriteLine("Frase sin las primeras letras de cada palabra: " + resultado);
        }

        public static void Ejercicio5()
        {
            Console.WriteLine("Ingrese una frase:");
            string frase = Console.ReadLine();
            string resultado = InvertirPal(frase);
            Console.WriteLine("Frase con palabras invertidas: " + resultado);
        }

        // Función para eliminar las vocales de una cadena
        public static string EliminarVoc(string texto)
        {
            string resultado = "";
            foreach (char c in texto)
            {
                if (!"aeiouAEIOU".Contains(c))
                {
                    resultado += c;
                }
            }
            return resultado;
        }

        // Función para obtener la palabra más larga de una cadena
        public static string CadenaMasLarga(string texto)
        {
            string[] palabras = texto.Split(' ');
            string palabraLarga = "";
            foreach (var palabra in palabras)
            {
                if (palabra.Length > palabraLarga.Length)
                {
                    palabraLarga = palabra;
                }
            }
            return palabraLarga;
        }

        // Función para eliminar la primera letra de cada palabra
        public static string EliminaPrim(string texto)
        {
            string[] palabras = texto.Split(' ');
            string resultado = "";
            foreach (var palabra in palabras)
            {
                if (palabra.Length > 1)
                {
                    resultado += palabra.Substring(1) + " ";
                }
                else
                {
                    resultado += " "; // Si la palabra tiene solo un caracter, se elimina y se mantiene el espacio
                }
            }
            return resultado.Trim();
        }

        // Función para invertir cada palabra en una cadena
        public static string InvertirPal(string texto)
        {
            string[] palabras = texto.Split(' ');
            string resultado = "";
            foreach (var palabra in palabras)
            {
                char[] arr = palabra.ToCharArray();
                Array.Reverse(arr);
                resultado += new string(arr) + " ";
            }
            return resultado.Trim();
        }
    }
}
