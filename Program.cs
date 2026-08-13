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
        Console.WriteLine(" SISTEMA DE AUTORIZACIÓN ");

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

        Console.WriteLine(" CLASIFICADOR DE ALERTAS ");

        // Validar que sea un número entero
        int nivelAlerta;
        Console.Write("Ingrese el nivel de alerta (0 a 10): ");
        while (!int.TryParse(Console.ReadLine(), out nivelAlerta))
        {
            Console.Write("Entrada inválida. Ingrese un número entero: ");
        }

        // Clasificación mediante estructuras if / else if / else
        if (nivelAlerta == 0)
        {
            Console.WriteLine("NORMAL");
        }
        else if (nivelAlerta >= 1 && nivelAlerta <= 3)
        {
            Console.WriteLine("ADVERTENCIA");
        }
        else if (nivelAlerta >= 4 && nivelAlerta <= 6)
        {
            Console.WriteLine("PELIGRO");
        }
        else if (nivelAlerta >= 7 && nivelAlerta <= 9)
        {
            Console.WriteLine("CRÍTICO");
        }
        else if (nivelAlerta == 10)
        {
            Console.WriteLine("EMERGENCIA");
        }
        else
        {
            Console.WriteLine("NIVEL DE ALERTA INVÁLIDO");
        }



        //PANEL DE CONTROL :v

        Console.WriteLine(" PANEL DE CONTROL ");
        Console.WriteLine("1. Consultar estado");
        Console.WriteLine("2. Mostrar temperatura");
        Console.WriteLine("3. Mostrar operadores");
        Console.WriteLine("4. Reiniciar sistema");
        Console.WriteLine("5. Salir");
        Console.Write("Seleccione una opción (1-5): ");

        int opcion;
        if (!int.TryParse(Console.ReadLine(), out opcion))
        {
            opcion = -1;
        }

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Estado del sistema: Operativo");
                break;
            case 2:
                Console.WriteLine("Temperatura actual: 24°C");
                break;
            case 3:
                Console.WriteLine("Operadores activos: 3");
                break;
            case 4:
                Console.WriteLine("Reiniciando sistema...");
                break;
            case 5:
                Console.WriteLine("Saliendo del panel...");
                break;
            default:
                Console.WriteLine("OPCIÓN NO VÁLIDA");
                break;
        }


        //LOGIN DEL SISTEMA :v

        Console.WriteLine(" LOGIN DEL SISTEMA ");

        // Credenciales predefinidas para la prueba
        string usuarioCorrecto = "admin";
        string claveCorrecta = "1234";

        int intentosRestantes = 3;
        bool accesoConcedido = false;

        while (intentosRestantes > 0 && !accesoConcedido)
        {
            Console.Write("Usuario: ");
            string usuario = Console.ReadLine();

            Console.Write("Contraseña: ");
            string clave = Console.ReadLine();

            if (usuario == usuarioCorrecto && clave == claveCorrecta)
            {
                accesoConcedido = true;
                Console.WriteLine("\nAcceso concedido al sistema.");
            }
            else
            {
                intentosRestantes--;
                if (intentosRestantes > 0)
                {
                    Console.WriteLine($"Datos incorrectos. Intentos restantes: {intentosRestantes}\n");
                }
            }
        }

        if (!accesoConcedido)
        {
            Console.WriteLine("SISTEMA BLOQUEADO");
        }


        //MENU PERSISTENTE :v

        int opcion;

        do
        {
            Console.WriteLine("\n=== MENÚ PERSISTENTE ===");
            Console.WriteLine("1. Consultar estado del sistema");
            Console.WriteLine("2. Ver consumo de energía");
            Console.WriteLine("3. Ver lista de módulos");
            Console.WriteLine("4. Calibrar sensores");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción (1-5): ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = -1; // Valor para activar la opción no válida
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\n[ESTADO]: Todos los sistemas operando al 100%.");
                    break;
                case 2:
                    Console.WriteLine("\n[CONSUMO]: Consumo actual en 45 kWh.");
                    break;
                case 3:
                    Console.WriteLine("\n[MÓDULOS]: Módulo de decisiones, repetición y datos.");
                    break;
                case 4:
                    Console.WriteLine("\n[CALIBRACIÓN]: Sensores calibrados con éxito.");
                    break;
                case 5:
                    Console.WriteLine("\nSaliendo del programa... ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("\nOPCIÓN NO VÁLIDA. Intente nuevamente.");
                    break;
            }

        } while (opcion != 5);



        //GENERADOR DE TABLAS :v

        Console.WriteLine("=== GENERADOR DE TABLAS DE MULTIPLICAR ===");

        // Solicitar y validar el número base
        int numero;
        Console.Write("Ingrese el número base para la tabla: ");
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Entrada inválida. Ingrese un número entero: ");
        }

        // Solicitar y validar el rango inicial
        int inicio;
        Console.Write("Ingrese el valor inicial del rango: ");
        while (!int.TryParse(Console.ReadLine(), out inicio))
        {
            Console.Write("Entrada inválida. Ingrese un número entero: ");
        }

        // Solicitar y validar el rango final
        int fin;
        Console.Write("Ingrese el valor final del rango: ");
        while (!int.TryParse(Console.ReadLine(), out fin))
        {
            Console.Write("Entrada inválida. Ingrese un número entero: ");
        }

        // Asegurar que el inicio sea menor o igual al fin (en caso de ingresar al revés)
        if (inicio > fin)
        {
            int temp = inicio;
            inicio = fin;
            fin = temp;
        }

        Console.WriteLine($"\n--- Tabla del {numero} (del {inicio} al {fin}) ---");

        // Generar la tabla usando for
        for (int i = inicio; i <= fin; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }

        //PROCESADOR DE OPERADORES :v

        Console.WriteLine("\n=== PROCESADOR DE OPERADORES ===");
        string[] operadores = { "Ana", "Luis", "Carlos", "Bea", "Alexander" };

        Console.WriteLine("Operadores con más de cuatro caracteres:");
        foreach (string op in operadores)
        {
            if (op.Length > 4)
            {
                Console.WriteLine($"- {op} ({op.Length} caracteres)");
            }
        }

        //FILTRO DE SEGURIDAD :v

        Console.WriteLine("\n=== FILTRO DE SEGURIDAD ===");
        string[] codigos = { "SEC-01", "ERROR", "SEC-02", "EXIT", "SEC-03" };

        foreach (string codigo in codigos)
        {
            if (codigo == "ERROR")
            {
                continue; // Ignora la iteración actual si encuentra "ERROR"
            }
            if (codigo == "EXIT")
            {
                break; // Detiene completamente el ciclo si encuentra "EXIT"
            }

            Console.WriteLine($"Procesando código: {codigo}");
        }

        //ANALIZADOR DE NOMBRES :v

        Console.WriteLine("\n=== ANALIZADOR DE NOMBRES ===");
        Console.Write("Ingrese un nombre completo: ");
        string nombreIngresado = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(nombreIngresado))
        {
            string nombreLimpio = nombreIngresado.Trim();
            int cantidadCaracteres = nombreLimpio.Length;
            string enMayusculas = nombreLimpio.ToUpper();
            string enMinusculas = nombreLimpio.ToLower();

            Console.WriteLine($"Nombre limpio: {nombreLimpio}");
            Console.WriteLine($"Cantidad de caracteres: {cantidadCaracteres}");
            Console.WriteLine($"En mayúsculas: {enMayusculas}");
            Console.WriteLine($"En minúsculas: {enMinusculas}");
        }
        else
        {
            Console.WriteLine("Entrada vacía o inválida.");
        }

    }
}