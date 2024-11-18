using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== Menú de Operaciones Matemáticas ====");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            Console.Write("Selecciona una opción (1-5): ");

            string opcion = Console.ReadLine() ?? string.Empty; // Manejo de null

            // Validación para restringir opciones fuera del rango permitido
            if (!int.TryParse(opcion, out int opcionNumerica) || opcionNumerica < 1 || opcionNumerica > 5)
            {
                Console.WriteLine("Opción no válida. Presiona una tecla para regresar al menú...");
                Console.ReadKey();
                continue;
            }

            // Salida si elige la opción 5
            if (opcion == "5")
            {
                Console.WriteLine("Gracias por usar la calculadora. ¡Adiós!");
                break;
            }

            // Solicitar números para la operación
            Console.Write("Ingresa el primer número: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Entrada inválida. Presiona una tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            Console.Write("Ingresa el segundo número: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Entrada inválida. Presiona una tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            double resultado;
            bool operacionValida = true;

            switch (opcion)
            {
                case "1":
                    resultado = num1 + num2;
                    Console.WriteLine($"El resultado de la suma es: {resultado}");
                    break;
                case "2":
                    resultado = num1 - num2;
                    Console.WriteLine($"El resultado de la resta es: {resultado}");
                    break;
                case "3":
                    resultado = num1 * num2;
                    Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"El resultado de la división es: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                        operacionValida = false;
                    }
                    break;
                default:
                    operacionValida = false;
                    break;
            }

            if (operacionValida)
            {
                Console.WriteLine("Presiona una tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
