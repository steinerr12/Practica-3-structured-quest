using System;

class program
{
    static void Main(string[] args)
    {

        //NIVEL 1: CENTRO DE DECISIONES :v.

        //Calculador de recursos.
        Console.WriteLine(" CALCULADORA DE RECURSOS ");

        // Validar cantidad de trabajadores
        int trabajadores;
        Console.Write("Ingrese la cantidad de trabajadores: ");
        while (!int.TryParse(Console.ReadLine(), out trabajadores) || trabajadores <= 0)
        {
            Console.Write("Entrada inválida. Ingrese un número entero positivo: ");
        }

        // Validar horas trabajadas
        double horas;
        Console.Write("Ingrese las horas trabajadas: ");
        while (!double.TryParse(Console.ReadLine(), out horas) || horas <= 0)
        {
            Console.Write("Entrada inválida. Ingrese un número positivo para las horas: ");
        }

        // Validar consumo por hora
        double consumoPorHora;
        Console.Write("Ingrese el consumo por hora: ");
        while (!double.TryParse(Console.ReadLine(), out consumoPorHora) || consumoPorHora <= 0)
        {
            Console.Write("Entrada inválida. Ingrese un número positivo para el consumo: ");
        }

        // Cálculo usando operadores aritméticos
        double consumoTotal = trabajadores * horas * consumoPorHora;

        // Reporte
        Console.WriteLine("\n--- REPORTE DE CONSUMO ---");
        Console.WriteLine($"Trabajadores: {trabajadores}");
        Console.WriteLine($"Horas: {horas}");
        Console.WriteLine($"Consumo por hora: {consumoPorHora}");
        Console.WriteLine($"Consumo Total: {consumoTotal}");




        //Nivel de acceso. :v

        Console.WriteLine(" NIVEL DE ACCESO ");

        // Validar edad del operador
        int edad;
        Console.Write("Ingrese la edad del operador: ");
        while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0)
        {
            Console.Write("Entrada inválida. Ingrese una edad válida (número entero positivo): ");
        }

        // Evaluación de la regla de acceso mediante relacionales e IF
        if (edad >= 18)
        {
            Console.WriteLine("Acceso permitido");
        }
        else
        {
            Console.WriteLine("Acceso restringido");
        }



        //SISTEMA DE AUTORIZACION. :v
        Console.WriteLine("=== SISTEMA DE AUTORIZACIÓN ===");

        // Validar edad
        int eda;
        Console.Write("Ingrese la edad: ");
        while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0)
        {
            Console.Write("Entrada inválida. Ingrese una edad válida: ");
        }

        // Validar nivel de seguridad
        int nivelSeguridad;
        Console.Write("Ingrese el nivel de seguridad: ");
        while (!int.TryParse(Console.ReadLine(), out nivelSeguridad) || nivelSeguridad < 0)
        {
            Console.Write("Entrada inválida. Ingrese un nivel de seguridad válido (entero positivo): ");
        }

        // Validar estado de credencial
        bool credencialActiva = false;
        bool entradaValida = false;

        while (!entradaValida)
        {
            Console.Write("¿La credencial está activa? (s/n o true/false): ");
            string entrada = Console.ReadLine()?.Trim().ToLower();

            if (entrada == "s" || entrada == "true" || entrada == "1")
            {
                credencialActiva = true;
                entradaValida = true;
            }
            else if (entrada == "n" || entrada == "false" || entrada == "0")
            {
                credencialActiva = false;
                entradaValida = true;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Intente de nuevo.");
            }
        }

        // Evaluación de autorización con operadores lógicos (&&)
        if (edad >= 18 && nivelSeguridad >= 3 && credencialActiva)
        {
            Console.WriteLine("\nAcceso Autorizado");
        }
        else
        {
            Console.WriteLine("\nAcceso Denegado");
        }



        //CLASIFICADOR DE ALERTAS. :v


    }
}