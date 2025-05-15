using System;

namespace EjerciciosProgramacion
{
    internal class Funciones
    {
        public static Boolean ValidarNumeroEntero(string texto, out int numero)
        {
            if (int.TryParse(texto, out numero))
            {
                return true;
            }
            else
            {
                Console.WriteLine("El dato ingresado no es un número");
            }
            return false;
        }
        public static Boolean ValidarNumeroFloat(string texto, out float numero)
        {
            if (float.TryParse(texto, out numero))
            {
                return true;
            }
            else
            {
                Console.WriteLine("El dato ingresado no es un número");
            }
            return false;
        }
        public static Boolean ValidarNumeroEnteroPositivo(string texto, out int numero)
        {
            if (int.TryParse(texto, out numero))
            {
                if (numero < 1)
                {
                    Console.WriteLine("El número debe ser mayor a 0");
                }
                else
                {
                    return true;
                }
            }
            else
            {
                Console.WriteLine("El dato ingresado no es un número");
            }
            return false;
        }
        public static Boolean ValidarNumeroFloatPositivo(string texto, out float numero)
        {
            if (float.TryParse(texto, out numero))
            {
                if (numero < 1)
                {
                    Console.WriteLine("El número debe ser mayor a 0");
                }
                else
                {
                    return true;
                }
            }
            else
            {
                Console.WriteLine("El dato ingresado no es un número");
            }
            return false;
        }
        public static void IngresarEntero(string mensaje, out int numero)
        {
            do
                Console.WriteLine(mensaje);
            while (!ValidarNumeroEntero(Console.ReadLine(), out numero));
            return;
        }
        public static void IngresarFloat(string mensaje, out float numero)
        {
            do
                Console.WriteLine(mensaje);
            while (!ValidarNumeroFloat(Console.ReadLine(), out numero));
            return;
        }
    }
}
