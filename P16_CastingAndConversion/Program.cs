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
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);

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