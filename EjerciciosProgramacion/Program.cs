using System;

internal class Program
{
    static void Main(){
        TP4Ejercicio1While();
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

    public static void TP4Ejercicio1While() {
        Random random = new Random();
        int numeroSecreto = random.Next(25), numeroIngresado=-1, cantidadIntentos = 0;
        while(numeroIngresado != numeroSecreto) {
            Console.WriteLine("He pensado un Número entre el 1 y el 25");
            Console.WriteLine("¿Podrías Adivinar cual es?");
            string teclado = Console.ReadLine();
            if (ValidarNumeroEnteroPositivo(teclado, out numeroIngresado)) {
                if (numeroIngresado<=25) {
                    cantidadIntentos++;
                    if (numeroIngresado==numeroSecreto)
                    {
                        Console.WriteLine("Felicidades, has acertado el numero " + teclado);
                        Console.WriteLine("Y solo lo has hecho en " + cantidadIntentos.ToString() + " intentos");
                    } else
                    {
                        Console.WriteLine("Lo siento, no has acertado.");
                        Console.WriteLine("Intenta Nuevamente");
                        Console.WriteLine("Llevas " + cantidadIntentos.ToString() + " intentos");
                    }
                } else {
                    Console.WriteLine("Ingrese un numero entre 1 y 25");
                }
            }

        }
    }
    public static void TP4Ejercicio1Do()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(25), numeroIngresado = -1, cantidadIntentos = 0;
        Console.WriteLine("He pensado un Número entre el 1 y el 25");
        Console.WriteLine("¿Podrías Adivinar cual es?");
        do {
            string teclado = Console.ReadLine();
            if (ValidarNumeroEnteroPositivo(teclado, out numeroIngresado))
            {
                if (numeroIngresado <= 25)
                {
                    cantidadIntentos++;
                    if (numeroIngresado == numeroSecreto)
                    {
                        Console.WriteLine("Felicidades, has acertado el numero " + teclado);
                        Console.WriteLine("Y solo lo has hecho en " + cantidadIntentos.ToString() + " intentos");
                    }
                    else
                    {
                        Console.WriteLine("Lo siento, no has acertado.");
                        Console.WriteLine("Llevas " + cantidadIntentos.ToString() + " intentos");
                        Console.WriteLine("Intenta Nuevamente");
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un numero entre 1 y 25");
                }
            }
        } while (numeroIngresado != numeroSecreto);
    }
    public static void TP4Ejercicio2While()
    {
        int numero, contador=1;
        Console.WriteLine("Ingrese un Número, Te mostrare su tabla de Multiplicar");
        if (!ValidarNumeroEnteroPositivo(Console.ReadLine(), out numero))
        {
            return;
        }
        Console.WriteLine($"La Tabla de Multiplicar del Número {numero} es:");
        while (contador <= 10)
        {
            int resultado = numero * contador;
            Console.WriteLine($"{numero} x {contador} = {resultado}");
            contador++;
        }
    }
    public static void TP4Ejercicio2Do()
    {
        int numero, contador = 1;
        Console.WriteLine("Ingrese un Número,");
        Console.WriteLine("Te mostrare su tabla de Multiplicar");
        if (!ValidarNumeroEnteroPositivo(Console.ReadLine(), out numero))
        {
            return;
        }
        Console.WriteLine($"La Tabla del Número {numero} es:");
        do
        {
            int resultado = numero * contador;
            Console.WriteLine($"{numero} x {contador} = {resultado}");
            contador++;
        } while (contador <= 10);
    }
    public static void TP4Ejercicio2For()
    {
        int numero;
        Console.WriteLine("Ingrese un Número,");
        Console.WriteLine("Te mostrare su tabla de Multiplicar");
        if (!ValidarNumeroEnteroPositivo(Console.ReadLine(), out numero))
        {
            return;
        }
        Console.WriteLine($"La Tabla del Número {numero} es:");
        for (int contador = 1; contador <= 10; contador++) {
            int resultado = numero * contador;
            Console.WriteLine($"{numero} x {contador} = {resultado}");
        }
    }
    public static void TP4Ejercicio3()
    {
        int opcionMenu=-1;
        float saldo=50000, monto;
        Console.WriteLine("Bienvenido al Cajero");
        while (opcionMenu != 0) {
            Console.WriteLine($"Saldo Actual: $ {saldo}");
            Console.WriteLine("Ingrese la Opción deseada");
            Console.WriteLine("1. Depositar Efectivo");
            Console.WriteLine("2. Extraer Dinero");
            Console.WriteLine("0. Salir");
            if (ValidarNumeroEnteroPositivo(Console.ReadLine(), out opcionMenu)) {
                switch (opcionMenu)
                {
                    case 0:
                        Console.WriteLine("Gracias por utilizar nuestros servicios");
                        break;
                    case 1:
                        Console.WriteLine("Ingrese el Monto a Depositar");
                        if (float.TryParse(Console.ReadLine(), out monto)) {
                            if (monto>0)
                            {
                                saldo = saldo + monto;
                                Console.WriteLine("´Depósito Exitoso");
                                Console.WriteLine($"Saldo Actual: ${saldo}");
                            } else
                            {
                                Console.WriteLine("Debe ingresar un monto mayor a cero");
                            }
                        } else {
                            Console.WriteLine("No se ha ingresado un dato valido");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el monto a Extraer");
                        if (float.TryParse(Console.ReadLine(), out monto)) {
                            if (monto>0) {
                                if (monto<=saldo)
                                {
                                    saldo = saldo - monto;
                                    Console.WriteLine("Extracción Exitosa");
                                    Console.WriteLine($"Saldo Actual :$ {saldo}");
                                } else
                                {
                                    Console.WriteLine("Fondos Insifucientes");
                                }
                            } else
                            {
                                Console.WriteLine("Debe ingresar un monto mayor a cero");
                            }
                        } else {
                            Console.WriteLine("No se ha ingresado un dato valido");
                        }
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta.");
                        break;
                }
            } else {
                opcionMenu = -1;
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
    public static void TP4Ejercicio4() {
        float numero=-1, suma = 0;
        while (numero != 0) {
            Console.WriteLine($"Suma Acumulada: {suma}");
            Console.WriteLine("Ingrese un Número");
            if (float.TryParse(Console.ReadLine(), out numero)) {
                if (numero!=0) {
                    suma += numero;
                    Console.WriteLine($"Suma actual: {suma}");
                }
            }
            Console.WriteLine("Presione una tecla");
            Console.ReadKey();
            Console.Clear();
        }
    }
    public static void TP4Ejercicio5() {
        int cantidadNumeros, numero, resultadoPotencia, potencia=3;
        Console.WriteLine("Ingrese la cantidad de numeros que desea calcular su potencia");
        if (!ValidarNumeroEnteroPositivo(Console.ReadLine(), out cantidadNumeros))
        {
           return;
        }
        for (int i = cantidadNumeros; i > 0; i--) {
            resultadoPotencia = 1;
            Console.WriteLine($"Faltan Ingresar {i} numeros"); 
            Console.WriteLine("Ingrese el numero para calcular su cubo");
            if (int.TryParse(Console.ReadLine(), out numero)) {
                for (int j=1; j<=potencia; j++) {
                    resultadoPotencia = resultadoPotencia * numero;
                }
                Console.WriteLine($"{numero} elevado a la {potencia} = {resultadoPotencia}");
            } else
            {
                Console.WriteLine("Ingrese un numero válido");
            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
    }
    public static void TP4Ejercicio6() {
        for (int i = 1; i <= 100; i++) {
            if ((i % 2) == 0) {
                Console.WriteLine($"El número {i} es par");
            }
        }
    }
    public static void TP4Ejercicio7() {
        int numero, factorial = 1;
        Console.WriteLine("Ingrese un número para calcular su Factorial");
        if (ValidarNumeroEnteroPositivo(Console.ReadLine(), out numero))
        {
            for (int i = 1; i <= numero; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine($"El Factorial de {numero} es: {factorial}");
        }
    }
    public static void TP4Ejercicio8() {
        int numero, resultadoTabla;
        Console.WriteLine("Ingrese un numero mayor a 1");
        if (!ValidarNumeroEnteroPositivo(Console.ReadLine(), out numero)) {
            return;
        }
        
        Console.WriteLine($"Se calcularan las tablas de los numeros 1 al {numero}");
        Console.WriteLine("Presione una tecla para continuar");
        Console.ReadKey();
        Console.Clear();
        for (int i = 1; i <= numero; i++) {
            Console.WriteLine($"Tabla de Multiplicar del {i}:\n");
            for (int j = 1; j <= 10; j++) {
                resultadoTabla = i * j;
                Console.WriteLine($"{i} x {j} = {resultadoTabla}");
            }
            Console.WriteLine("\nPresione una tecla para calcular la siguiente tabla");
            Console.ReadKey();
            Console.Clear();
        }
    }
}



