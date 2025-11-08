//Write code that attempts to add an int and a string and save the result in an int

// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);

//error CS0029: Cannot implicitly convert type 'string' to 'int'

/* int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result); //outputs 24 which is mathematically incorrect but valid string concatenation
 */

// Why can't the C# compiler figure out that you want to treat the variable second containing 4 as a number, not a string?
// Because Compilers make safe conversions

//Question: Is it possible that attempting to change the value's data type would result in a loss of information?

/* int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}"); */

/* Since any int value can easily fit inside of a decimal, the compiler
performs the conversion. The term widening conversion means that you're
attempting to convert a value from a data type that could hold less
information to a data type that can hold more information. 
This is an implicit conversion because the compiler can safely make the conversion without any risk of data loss.
 */

/* Perform a Cast (Explicit Conversion)  
To perform a cast, you use the casting operator () to surround a data type,
then place it next to the variable you want to convert (example:
(int)myDecimal). You perform an explicit conversion to the defined cast data
type (int).
 */

/* decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}"); */

/* The variable myDecimal holds a value that has precision after the decimal
point. By adding the casting instruction (int), you're telling the C# compiler
that you understand it's possible you'll lose that precision, and in this
situation, it's fine. You're telling the compiler that you're performing an
intentional conversion, an explicit conversion. */

//Determine if your conversion is a "widening conversion" or a "narrowing conversion"

//The term narrowing conversion means that you're attempting to convert a value
//from a data type that can hold more information to a data type that can hold less information. 

/* decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}"); */

// You can observe from the output that casting a decimal into a float is a narrowing conversion because you're losing
// precision.

/* Summary:
 - Implicit Conversion (Widening Conversion): Safe conversions where the compiler automatically converts a value from a data type that holds less information to one that holds more information (e.g., int to decimal).
 
 - Explicit Conversion (Narrowing Conversion): Conversions that may result in data loss, requiring the programmer to specify the desired data type using casting (e.g., decimal to int).
 
 - Always assess whether a conversion is widening or narrowing to understand potential data loss risks.
 */

//Use ToString() to convert a number to a string
/* int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message); */

//Convert a string to an int using the Parse() helper method
/* string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum); */

// Take a minute to try to spot the potential problem with the previous code example? What if either of the variables
// first or second are set to values that can't be converted to an int? An exception is thrown at runtime.
//The easiest way to mitigate this situation is by using TryParse(), which is a better version of the Parse() method.

//Convert a string to a int using the Convert class
/* string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result); */

// The ToInt32() method has 19 overloaded versions allowing it to accept virtually every data type. you used the
// Convert.ToInt32() method with a string here, but you should probably use TryParse() when possible. So, when should
// you use the Convert class? The Convert class is best for converting fractional numbers into whole numbers (int)
// because it rounds up the way you would expect.

//Compare casting and converting a decimal into an int
/* int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2); */

// When you're casting int value = (int)1.5m;, the value of the float is truncated so the result is 1, meaning the value
// after the decimal is ignored completely. You could change the literal float to 1.999m and the result of casting would
// be the same.

/* When you're converting using Convert.ToInt32(), the literal float value is properly rounded up to 2. If you changed
the literal value to 1.499m, it would be rounded down to 1. */

/* Summary:
 - ToString(): Converts a number to its string representation.
 
 - Parse(): Converts a string to a number but can throw exceptions if the string is not in a valid format.
 
 - TryParse(): Safely attempts to convert a string to a number without throwing exceptions, returning a boolean indicating success or failure.
 
 - Convert Class: Provides methods for converting between various data types, including rounding behavior when converting fractional numbers to whole numbers.
 
 - Casting vs. Converting: Casting truncates values (e.g., decimal to int), while converting rounds values (e.g., decimal to int using Convert.ToInt32()).
 */

/*  //TryParse() a string into an int
string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

Console.WriteLine(result); //outputs 0 since the conversion failed, meaning result was never changed from its initial value of 0

if (result > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result}"); */

/* When calling a method with an out parameter, you must use the keyword out before the variable, which holds the value.
The out parameter is assigned to the result variable in the code (int.TryParse(value, out result). You can then use the
value the out parameter contains throughout the rest of your code using the variable result.

The converted value is stored in the int variable result. The int variable result is declared and initialized before
this line of code, so it should be accessible both inside the code blocks that belong to the if and else statements, as
well as outside of them. */

// Use TryParse() when converting a string into a numeric data type. TryParse() returns true if the conversion is
// successful, false if it's unsuccessful.

//***Complete a challenge to combine string array values as strings and as integers***

/* string[] values = { "12.3", "45", "ABC", "11", "DEF" };

//initialize message and sum variables
String message = ""; 
double sum = 0;

if (values != null && values.Length > 0) //checks that the array is not null and has at least one element 
{
    foreach (string s in values) //iterate through each string in the array
    {
        //first try to parse s as an double
        if (double.TryParse(s, out double doubleResult))
        {
            //if successful add it to sum
            sum += doubleResult;
        }
        else
        {
            //if unsuccessful, concatenate it to message
            message += s;
        }
    }
    Console.WriteLine($"Message: {message}");
    Console.WriteLine($"Total: {sum}");
    // what is the $ used for in the WriteLine method? 
    // The $ before the string indicates that the string is an interpolated string, 
    // allowing you to embed expressions directly within the string using curly braces {}. 
} */

//***Complete a challenge to output math operations as specific number types***

/* Here's a second chance to use what you've learned about casting and conversion to solve a coding challenge.

The following challenge helps you to understand the implications of casting values considering the impact of narrowing
and widening conversions. */

int value1 = 11;
decimal value2 = 6.2m; //what is the m for? //The m suffix indicates that the literal is of type decimal.
float value3 = 4.3f; //what is the f for? //The f suffix indicates that the literal is of type float.

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
//Solve for result1: Divide value1 by value2, display the result as an int 
int result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
//Solve for result2: Divide value2 by value3, display the result as a decimal
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
//Solve for result3: Divide value3 by value1, display the result as a float
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

// result1: Convert.ToInt32(decimal) rounds to the nearest integer, so 11 / 6.2 ≈ 1.774... becomes 2.
// result2: (decimal)value3 and Convert.ToDecimal(value3) produce the same numeric result for normal finite floats.
// result3: using a float for the numerator gives a float division; 4.3f / 11 prints as 0.3909091 (the default float formatting).


