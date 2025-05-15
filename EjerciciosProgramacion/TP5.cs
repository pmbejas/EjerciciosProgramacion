using System;

namespace EjerciciosProgramacion
{
    internal class TP5
    {
        public static void Ejercicio1TP5()
        {
            bool Calcular(int numero1, int numero2, char operacion, out float resulta)
            {
                switch (operacion)
                {
                    case '+':
                        resulta = numero1 + numero2;
                        break;
                    case '-':
                        resulta = numero1 - numero2;
                        break;
                    case '*':
                        resulta = numero1 * numero2;
                        break;
                    case '/':
                        if (numero2 != 0)
                        {
                            resulta = (float)numero1 / numero2;
                        }
                        else
                        {
                            resulta = 0;
                            Console.WriteLine("No se puede dividir por cero");
                            return false;
                        }
                        break;
                    default:
                        resulta = 0;
                        return false;
                }
                return true;
            }

            bool validarOperacion(char operacion)
            {
                if (operacion == '+' || operacion == '-' || operacion == '*' || operacion == '/')
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Operación no válida");
                    return false;
                }
            }

            int num1, num2;
            float resultado = 0;
            char opera;
            Funciones.IngresarEntero("Ingrese el primer número", out num1);
            Funciones.IngresarEntero("Ingrese el segundo número", out num2);

            do
            {
                Console.WriteLine("Ingrese la operación deseada (+, -, *, /)");
                opera = Console.ReadLine()[0];
            } while (!validarOperacion(opera));

            if (Calcular(num1, num2, opera, out resultado))
            {
                Console.WriteLine($"El resultado de la operación {num1} {opera} {num2} es: {resultado}");
            }
            else
            {
                Console.WriteLine("No se ha podido realizar la operación");
                Console.WriteLine("Revise los datos ingresados");
            }
        }
        public static void Ejercicio2TP5()
        {
            Boolean ValidarMayoriaEdad(int edadUsuario)
            {
                if (edadUsuario >= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


            int edad;
            Funciones.IngresarEntero("Ingrese la edad a evaluar", out edad);
            if (ValidarMayoriaEdad(edad))
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("Es menor de edad");
            }
        }
        public static void Ejercicio3TP5()
        {
            Boolean Depositar(float monto, ref float saldoActual)
            {
                if (monto > 0)
                {
                    saldoActual += monto;
                    return true;
                }
                else
                {
                    Console.WriteLine("El monto a depositar debe ser mayor a 0");
                    return false;
                }
            }

            Boolean Extraer(float monto, ref float saldoActual)
            {
                if (monto > 0 && monto <= saldoActual)
                {
                    saldoActual -= monto;
                    return true;
                }
                else
                {
                    Console.WriteLine("El monto a extraer debe ser mayor a 0 y menor o igual al saldo actual");
                    return false;
                }
            }
            float saldo = 50000;
            int opera = -1;

            while (opera != 0)
            {
                Console.WriteLine($"Saldo actual: {saldo}");
                Funciones.IngresarEntero("ATM\nElija su opcion:\n1. Depositar Dinero\n2. Extraer Dinero\n0. Salir del Sistema", out opera);
                switch (opera)
                {
                    case 1:
                        float montoDeposito = 0;
                        Funciones.IngresarFloat("Ingrese el monto a depositar", out montoDeposito);
                        if (Depositar(montoDeposito, ref saldo))
                        {
                            Console.WriteLine($"Se ha realizado el Depósito de manera exitosa.\nSaldo actual: {saldo}");
                        }
                        else
                        {
                            Console.WriteLine("Hubo un error al tratar de hacer el depósito.\nVerifique los datos ingresados.");
                        }
                        break;
                    case 2:
                        float montoExtraccion = 0;
                        Funciones.IngresarFloat("ingrese el monto de la extraccion", out montoExtraccion);
                        if (Extraer(montoExtraccion, ref saldo))
                        {
                            Console.WriteLine($"Se ha realizado la Extracción de manera exitosa.\nSaldo actual: {saldo}");
                        }
                        else
                        {
                            Console.WriteLine("Hubo un error al tratar de hacer la extracción.\nVerifique los datos ingresados.");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Gracias por utilizar nuestos servicos.");
                        break;
                }
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void Ejercicio4TP5()
        {
            //Ejercicio 4: Crear una funcion que calcule la temperatura media de un dia a partir de la temperatura maxima y minima.
            //Crear un programa princiapal, que utilizando la funcion anterior, vaya pidiendo la temperatura maxima y minima de cada dia
            //y vaya mostrando la media. El programa pedirá el número de días que se van a introducir.

            float TemperaturaMedia(float temperaturaMaxima, float temperaturaMinima)
            {
                return (temperaturaMaxima + temperaturaMinima) / 2;
            }

            float maxima, minima, mediaAcumulada=0;
            int dias;
            Funciones.IngresarEntero("Ingrese la cantidad de días a evaluar", out dias);
            for (int i = 1; i <= dias; i++)
            {
                Console.WriteLine($"Día {i}");
                Funciones.IngresarFloat("Ingrese la temperatura máxima", out maxima);
                Funciones.IngresarFloat("Ingrese la temperatura mínima", out minima);
                float media = TemperaturaMedia(maxima,minima);
                Console.WriteLine($"La temperatura media del día {i} es: {media}\n");
                mediaAcumulada += media;
            }
            Console.WriteLine($"La temperatura media acumulada es: {mediaAcumulada}");
            Console.WriteLine($"La temperatura media de los {dias} días es: {mediaAcumulada / dias}");
        }
        public static void Ejercicio5TP5()
        {
            //Ejercicio 5: Escribir un programa que pida dos números enteros al usuario y crear una funcion EsMultiplo que reciba los
            //dos números y devuelva true si el primer número es múltiplo del segundo, y false si no lo es.
            bool EsMultiplo(int numero1, int numero2)
            {
                return (numero1 % numero2 == 0) ? true : false;
            }

            int num1, num2;
            Funciones.IngresarEntero("Ingrese el primer número", out num1);
            Funciones.IngresarEntero("Ingrese el segundo número", out num2);
            if (EsMultiplo(num1, num2))
            {
                Console.WriteLine($"El número {num1} es múltiplo de {num2}");
            }
            else
            {
                Console.WriteLine($"El número {num1} no es múltiplo de {num2}");
            }
        }
        public static void Ejercicio6TP5()
        {
            //Escribir una funcion que reciba un numnero entero positivo y devuelva su factorial.
            //Ejemplo: 7! = 1 * 2 * 3 * 4 * 5 *  6 * 7 = 5040

            int CalularFactorial(int numero)
            {
                int resultado = 1;
                for (int i = 1; i <= numero; i++)
                {
                    resultado *= i;
                }
                return resultado;
            }

            int num;
            do
            {
                Funciones.IngresarEntero("Ingrese un número entero positivo", out num);
            } while (num <= 0);
            Console.WriteLine($"\nEl factorial de {num} es: {CalularFactorial(num)}\n");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
