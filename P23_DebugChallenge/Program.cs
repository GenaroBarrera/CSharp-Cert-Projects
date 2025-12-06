/* string? readResult; // To hold user input. String? is used to suppress nullable warning. 
int startIndex = 0; // To hold starting index value.
bool goodEntry = false; // To indicate whether user input is valid.

int[] numbers = { 1, 2, 3, 4, 5 }; // An array of integers.

// Display the numbers array to the console.
Console.Clear(); // Clear the console screen. an error occurs if you don't update VSCode launch.json to use "integratedTerminal" for "console"
Console.Write("\n\rThe 'numbers' array contains: { "); 
foreach (int number in numbers) // foreach loops through each element in the array
{
    Console.Write($"{number} "); // Display each element followed by a space.
}

// To calculate a sum of array elements, prompt the user for the starting element number.
Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':"); // Prompt user for input.
while (goodEntry == false) // Loop until valid input is received.
{
    readResult = Console.ReadLine(); // Read user input.
    goodEntry = int.TryParse(readResult, out startIndex); // Try to parse input as an integer.

    if (startIndex > 5) // Check if input is within valid range.
    {
        goodEntry = false; // Set goodEntry to false to continue the loop.
        Console.WriteLine("\n\rEnter an integer value between 1 and 5"); // Prompt user for valid input again.
    }
}

// Display the sum and then pause.
Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex)}");

Console.WriteLine("press Enter to exit");
readResult = Console.ReadLine();

// This method returns the sum of elements n through 5
static int SumValues(int[] numbers, int n)
{
    int sum = 0;
    n -= 1; // Adjust for zero-based array index. E.g., if user enters 1, start at index 0.
    for (int i = n; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum;
} */

/* bool exit = false; // To control the loop
var rand = new Random(); // Random number generator
int num1 = 5; // First number
int num2 = 5; // Second number

do // Loop until exit is true
{
    num1 = rand.Next(1, 11); // Generate a random number between 1 and 10
    num2 = num1 + rand.Next(1, 51); // Generate a second number greater than the first

} while (exit == false); // End of loop. Exit is always false, so this loop runs indefinitely
 */
//commit this

/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
//solution 1, pass x by reference
/* int x = 5; // Initial value of x is 5

ChangeValue(ref x); // Call the ChangeValue method, passing x by reference. (That means the value of x will be changed outside the method.)

Console.WriteLine(x); // Print the value of x to the console

// Method to change the value of the parameter.
void ChangeValue(ref int value) //we use the ref keyword to indicate that the parameter is passed by reference
{
    value = 10; // Update the value of the referenced variable to 10
} */

/* //solution 2, return the updated value (This is better practice)
int x = 5;
x = ChangeValue(x); //we assign the returned value from ChangeValue back to x
Console.WriteLine(x);

int ChangeValue(int value) //instead of void, we use int as the return type. and we return the updated value.
{
    value = 10;
    return value;
} */

/* //IndexOutOfRangeException
int[] values1 = { 3, 6, 9, 12, 15, 18, 21 }; // Length is 7, indices 0 to 6
int[] values2 = new int[6]; // Length is 6, indices 0 to 5

values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs */

//Implement a simple try-catch
/* try
{
    Process1();//method that calls another method which causes an exception
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()//method that simply calls another method
{
    WriteMessage();
}

static void WriteMessage()//method with code that causes an exception
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
} */

/* // inputValues is used to store numeric values entered by a user
string[] inputValues = ["three", "9999999999", "0", "2"];//simulated user inputs

foreach (string inputValue in inputValues)
{
    int numValue;
    try
    {
        numValue = int.Parse(inputValue);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid readResult. Please enter a valid number.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The number you entered is too large or too small.");
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
} */

try
{
    int num1 = int.MaxValue;
    int num2 = int.MaxValue;
    checked
    {
    int result = num1 + num2; // This will cause an OverflowException
    Console.WriteLine("Result: " + result);
    }
    
}
catch (OverflowException ex)
{
    Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
}

try
{
    string str = null;
    int length = str.Length; // This will cause a NullReferenceException
    Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null." + ex.Message);
}

try
{
    int[] numbers = new int[5];
    numbers[5] = 10; // This will cause an IndexOutOfRangeException
    Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range." + ex.Message);
}

try
{
    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4; // This will cause a DivideByZeroException
    Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
}

Console.WriteLine("Exiting program.");