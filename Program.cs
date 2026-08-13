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


        //VALIDADOR DE DATOS :v

        Console.WriteLine("\n=== VALIDADOR DE DATOS ===");

        int edadValidada;
        Console.Write("Ingrese su edad: ");
        while (!int.TryParse(Console.ReadLine(), out edadValidada))
        {
            Console.Write("Valor inválido. Ingrese un número entero para la edad: ");
        }

        double salarioValidado;
        Console.Write("Ingrese su salario: ");
        while (!double.TryParse(Console.ReadLine(), out salarioValidado))
        {
            Console.Write("Valor inválido. Ingrese un número válido para el salario: ");
        }

        int anioNacimiento;
        Console.Write("Ingrese su año de nacimiento: ");
        while (!int.TryParse(Console.ReadLine(), out anioNacimiento))
        {
            Console.Write("Valor inválido. Ingrese un año válido: ");
        }

        Console.WriteLine($"Datos registrados -> Edad: {edadValidada}, Salario: {salarioValidado}, Año de nacimiento: {anioNacimiento}");


        //RELOJ DEL SISTEMA :v

        Console.WriteLine("\n=== RELOJ DEL SISTEMA ===");
        DateTime fechaHoraActual = DateTime.Now;

        Console.WriteLine($"Fecha y hora actual: {fechaHoraActual}");
        Console.WriteLine($"Día: {fechaHoraActual.Day}");
        Console.WriteLine($"Mes: {fechaHoraActual.Month}");
        Console.WriteLine($"Año: {fechaHoraActual.Year}");

        int anioNac;
        Console.Write("Ingrese su año de nacimiento para calcular la edad: ");
        while (!int.TryParse(Console.ReadLine(), out anioNac))
        {
            Console.Write("Entrada inválida. Ingrese un año válido: ");
        }
        int edadCalculada = fechaHoraActual.Year - anioNac;
        Console.WriteLine($"Su edad aproximada es: {edadCalculada} años.");


        //SIMULADOR MATEMATICO :v

        Console.WriteLine("\n=== SIMULADOR MATEMÁTICO ===");
        double num1, num2;

        Console.Write("Ingrese el primer número: ");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.Write("Entrada inválida. Ingrese un número: ");
        }

        Console.Write("Ingrese el segundo número: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.Write("Entrada inválida. Ingrese un número: ");
        }

        Console.WriteLine($"Potencia ({num1}^{num2}): {Math.Pow(num1, num2)}");
        Console.WriteLine($"Raíz cuadrada del primer número: {Math.Sqrt(Math.Abs(num1))}");
        Console.WriteLine($"Valor absoluto del primer número: {Math.Abs(num1)}");
        Console.WriteLine($"Redondeo del primer número: {Math.Round(num1)}");
        Console.WriteLine($"Número mayor entre ambos: {Math.Max(num1, num2)}");
        Console.WriteLine($"Número menor entre ambos: {Math.Min(num1, num2)}");


        //GENERADOR DE CODIGOS :v

        Console.WriteLine("\n=== GENERADOR DE CÓDIGOS ===");
        Random random = new Random();
        char continuarGen = 's';

        while (continuarGen == 's')
        {
            int codigoSeguridad = random.Next(100000, 1000000);
            Console.WriteLine($"Código de seguridad generado: {codigoSeguridad}");

            Console.Write("¿Desea generar otro código? (s/n): ");
            string respuestaGen = Console.ReadLine()?.Trim().ToLower();
            if (respuestaGen == "s")
            {
                continuarGen = 's';
            }
            else
            {
                continuarGen = 'n';
            }
        }

        //CONSOLA DE CONTROL :v

        Console.WriteLine("\n=== CONSOLA DE CONTROL ===");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[ESTADO]: Operativo (Color Verde)");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("[ADVERTENCIA]: Nivel de energía bajo (Color Amarillo)");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[ERROR]: Falla crítica en el sistema (Color Rojo)");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("[INFORMACIÓN]: Transfiriendo datos... (Color Cian)");

        Console.ResetColor();
        Console.WriteLine("Colores restablecidos. Fin del programa.");

       
// NIVEL FINAL: BOSS - OPERACIÓN CÓDIGO ROJO


Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("        OPERACIÓN CÓDIGO ROJO - CONTROL BASE      ");

Console.ResetColor();

Random random = new Random();
int opcionPrincipal;

do
{
    Console.WriteLine("\n--- MENU PRINCIPAL DE LA MISIÓN ---");
    Console.WriteLine("1. Registro de Operadores (Validador + Analizador)");
    Console.WriteLine("2. Control de Acceso y Seguridad (Login + Autorización)");
    Console.WriteLine("3. Simulación de Recursos y Alertas");
    Console.WriteLine("4. Generador de Códigos de Seguridad");
    Console.WriteLine("5. Herramientas Matemáticas (Calculadora + Tablas)");
    Console.WriteLine("6. Reloj del Sistema y Estadísticas");
    Console.WriteLine("7. Salir del Sistema");
    Console.WriteLine("--------------------------------------------------");
    Console.Write("Seleccione una opción (1-7): ");

    if (!int.TryParse(Console.ReadLine(), out opcionPrincipal))
    {
        opcionPrincipal = -1;
    }

    Console.Clear();

    switch (opcionPrincipal)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== REGISTRO DE OPERADORES ===");
            Console.ResetColor();

            Console.Write("Ingrese nombre completo del operador: ");
            string nombreIngresado = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(nombreIngresado))
            {
                string nombreLimpio = nombreIngresado.Trim();
                Console.WriteLine($"\n[OPERADOR REGISTRADO]: {nombreLimpio.ToUpper()}");
                Console.WriteLine($"Extensión del nombre: {nombreLimpio.Length} caracteres.");
            }
            else
            {
                Console.WriteLine("Error: Entrada vacía.");
            }

            int edadValidada;
            Console.Write("Ingrese su edad: ");
            while (!int.TryParse(Console.ReadLine(), out edadValidada) || edadValidada < 0)
            {
                Console.Write("Edad inválida. Ingrese un entero positivo: ");
            }

            double salarioValidado;
            Console.Write("Ingrese su salario base: ");
            while (!double.TryParse(Console.ReadLine(), out salarioValidado) || salarioValidado <= 0)
            {
                Console.Write("Salario inválido. Ingrese un monto válido: ");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nFicha guardada con éxito -> Edad: {edadValidada} | Salario: ${salarioValidado}");
            Console.ResetColor();
            break;

        case 2:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== CONTROL DE ACCESO Y AUTORIZACIÓN ===");
            Console.ResetColor();

            string usuarioCorrecto = "admin";
            string claveCorrecta = "1234";
            int intentos = 3;
            bool autenticado = false;

            while (intentos > 0 && !autenticado)
            {
                Console.Write("Usuario: ");
                string user = Console.ReadLine();
                Console.Write("Contraseña: ");
                string pass = Console.ReadLine();

                if (user == usuarioCorrecto && pass == claveCorrecta)
                {
                    autenticado = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n[AUTENTICACIÓN EXITOSA]");
                    Console.ResetColor();
                }
                else
                {
                    intentos--;
                    Console.WriteLine($"Credenciales erróneas. Intentos restantes: {intentos}\n");
                }
            }

            if (autenticado)
            {
                int nivelSeguridad;
                Console.Write("Ingrese su Nivel de Seguridad asignado: ");
                while (!int.TryParse(Console.ReadLine(), out nivelSeguridad) || nivelSeguridad < 0)
                {
                    Console.Write("Nivel inválido. Reintente: ");
                }

                Console.Write("¿Credencial física activa? (s/n): ");
                string cred = Console.ReadLine()?.Trim().ToLower();
                bool activa = (cred == "s" || cred == "true" || cred == "1");

                if (nivelSeguridad >= 3 && activa)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n[ACCESO OTORGADO]: Nivel de autorización verificado.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n[ACCESO DENEGADO]: Permisos insuficientes o credencial inactiva.");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SISTEMA BLOQUEADO POR INTENTOS FALLIDOS.");
                Console.ResetColor();
            }
            break;

        case 3:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== SIMULACIÓN DE RECURSOS Y ALERTAS ===");
            Console.ResetColor();

            int trabajadores;
            Console.Write("Cantidad de trabajadores: ");
            while (!int.TryParse(Console.ReadLine(), out trabajadores) || trabajadores <= 0)
            {
                Console.Write("Número inválido. Reintente: ");
            }

            double horas, consumoPorHora;
            Console.Write("Horas operativas: ");
            while (!double.TryParse(Console.ReadLine(), out horas) || horas <= 0)
            {
                Console.Write("Horas inválidas. Reintente: ");
            }

            Console.Write("Consumo por hora (kWh): ");
            while (!double.TryParse(Console.ReadLine(), out consumoPorHora) || consumoPorHora <= 0)
            {
                Console.Write("Consumo inválido. Reintente: ");
            }

            double totalConsumo = trabajadores * horas * consumoPorHora;
            Console.WriteLine($"\nConsumo Total Calculado: {totalConsumo} kWh");

            int nivelAlerta;
            Console.Write("\nIngrese nivel de alerta reportado (0 a 10): ");
            while (!int.TryParse(Console.ReadLine(), out nivelAlerta))
            {
                Console.Write("Ingrese un número entero (0-10): ");
            }

            Console.Write("Estado de Alerta: ");
            if (nivelAlerta == 0) Console.WriteLine("NORMAL");
            else if (nivelAlerta >= 1 && nivelAlerta <= 3) Console.WriteLine("ADVERTENCIA");
            else if (nivelAlerta >= 4 && nivelAlerta <= 6) Console.WriteLine("PELIGRO");
            else if (nivelAlerta >= 7 && nivelAlerta <= 9) Console.WriteLine("CRÍTICO");
            else if (nivelAlerta == 10) Console.WriteLine("EMERGENCIA");
            else Console.WriteLine("NIVEL INVÁLIDO");
            break;

        case 4:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== GENERADOR DE CÓDIGOS DE SEGURIDAD ===");
            Console.ResetColor();

            char genOtro = 's';
            while (genOtro == 's')
            {
                int token = random.Next(100000, 1000000);
                Console.WriteLine($"\nTOKEN GENERADO: SEC-{token}");

                Console.Write("¿Generar otro token? (s/n): ");
                string resp = Console.ReadLine()?.Trim().ToLower();
                genOtro = (resp == "s") ? 's' : 'n';
            }
            break;

        case 5:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== HERRAMIENTAS MATEMÁTICAS Y TABLAS ===");
            Console.ResetColor();

            int baseTabla, inicio, fin;
            Console.Write("Número base para la tabla: ");
            while (!int.TryParse(Console.ReadLine(), out baseTabla))
            {
                Console.Write("Entrada inválida: ");
            }

            Console.Write("Inicio del rango: ");
            while (!int.TryParse(Console.ReadLine(), out inicio))
            {
                Console.Write("Entrada inválida: ");
            }

            Console.Write("Fin del rango: ");
            while (!int.TryParse(Console.ReadLine(), out fin))
            {
                Console.Write("Entrada inválida: ");
            }

            if (inicio > fin)
            {
                int temp = inicio;
                inicio = fin;
                fin = temp;
            }

            Console.WriteLine($"\n--- Tabla del {baseTabla} ({inicio} al {fin}) ---");
            for (int i = inicio; i <= fin; i++)
            {
                Console.WriteLine($"{baseTabla} x {i} = {baseTabla * i}");
            }
            break;

        case 6:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== RELOJ Y ESTADÍSTICAS DEL SISTEMA ===");
            Console.ResetColor();

            DateTime ahora = DateTime.Now;
            Console.WriteLine($"Fecha y Hora Actual: {ahora}");
            Console.WriteLine($"Día: {ahora.Day} | Mes: {ahora.Month} | Año: {ahora.Year}");

            string[] equipo = { "Ana", "Luis", "Carlos", "Bea", "Alexander" };
            Console.WriteLine("\n[OPERADORES REGISTRADOS EN SISTEMA (Filtro > 4 caracteres)]:");
            foreach (string op in equipo)
            {
                if (op.Length > 4)
                {
                    Console.WriteLine($"- {op} ({op.Length} letras)");
                }
            }
            break;

        case 7:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCerrando Operación Código Rojo... ¡Misión Cumplida!");
            Console.ResetColor();
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opción no válida.");
            Console.ResetColor();
            break;
    }

    if (opcionPrincipal != 7)
    {
        Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }

} while (opcionPrincipal != 7);

    }
}
