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

bool exit = false; // To control the loop
var rand = new Random(); // Random number generator
int num1 = 5; // First number
int num2 = 5; // Second number

do // Loop until exit is true
{
    num1 = rand.Next(1, 11); // Generate a random number between 1 and 10
    num2 = num1 + rand.Next(1, 51); // Generate a second number greater than the first

} while (exit == false); // End of loop. Exit is always false, so this loop runs indefinitely

//commit this
