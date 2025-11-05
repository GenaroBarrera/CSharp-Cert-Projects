class Calculator
{
    static void Main()
    {
        bool continueCalculating = true;

        Console.WriteLine("Welcome to Simple Calculator!");

        while (continueCalculating)
        {
            // Get first number
            Console.Write("\nEnter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            // Get operation
            Console.Write("Enter operation (+, -, *, /): ");
            string? operation = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(operation) || operation.Length != 1 || !"+-*/".Contains(operation))
            {
                Console.WriteLine("Invalid operation. Please enter a single character: +, -, *, or /");
                continue;
            }

            // Get second number
            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            // Perform calculation
            double? result = Calculate(num1, num2, operation[0]);
            
            // Display result
            if (result.HasValue)
            {
                Console.WriteLine($"\nResult: {num1} {operation} {num2} = {result}");
            }

            // Ask to continue
            Console.Write("\nCalculate again? (y/n): ");
            string? answer = Console.ReadLine()?.ToLower();
            continueCalculating = answer == "y" || answer == "yes";
        }

        Console.WriteLine("\nThank you for using Simple Calculator!");
    }

    static double? Calculate(double num1, double num2, char operation)
    {
        try
        {
            return operation switch
            {
                '+' => num1 + num2,
                '-' => num1 - num2,
                '*' => num1 * num2,
                '/' when num2 != 0 => num1 / num2,
                '/' => throw new DivideByZeroException("Cannot divide by zero"),
                _ => throw new ArgumentException($"Invalid operation: {operation}")
            };
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero!");
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return null;
        }
    }
}
