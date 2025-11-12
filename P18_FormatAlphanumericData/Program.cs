// What is Composite Formatting?

// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// // string.format method uses placeholders {0} and {1} 
// // to insert the values of first and second into the resulting string.
// Console.WriteLine(result);

//{0} is a placeholder for the first argument (first) and {1} is a placeholder for the second argument (second).

// Update your code as follows:

/* string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
//The order of placeholders can be changed. 
//However {0} still refers to the first argument (Hello) and {1} refers to the second argument (World).
//Thus the output will be "World Hello!" 
Console.WriteLine("{0} {0} {0}!", first, second);
// You can use the same placeholder multiple times in the format string. In this case, the value of first will be
// repeated three times in the output. Second isn't used in this example, but it can still be passed without error. 
// The output will be "Hello Hello Hello!"
Console.WriteLine("{1} {1} {1}!", first, second); 
//In this case, the second argument is used three times. You don't need to use the first argument.
//  The output will be "World World World!" */

//What is string interpolation?
// String interpolation is a technique that simplifies composite formatting. Instead of using a numbered token and
// including the literal value or variable name in a list of arguments to String.Format() or Console.WriteLine(), you
// can just use the variable name inside of the curly braces.

// string first = "Hello";
// string second = "World";
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

//Formatting currency

// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");
// Notice how adding the :C to the tokens inside of the curly braces formats the number as currency regardless of
// whether you use int or decimal.

//Formatting numbers

/* decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
//By default, the N numeric format specifier displays only two digits after the decimal point.
Console.WriteLine($"Measurement: {measurement:N4} units");
// If you want to display more precision, you can do that by adding a number after the specifier. The following code
// will display four digits after the decimal point using the N4 specifier.  */

//Formatting percentages

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P3}");

//Combining formatting approaches

// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
// Console.WriteLine(yourDiscount);

//Display the invoice number using string interpolation
//Finalize the receipt with the total amount due formatted as currency

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}"); //Print invoice number formatted using string interpolation
// Console.WriteLine($"   Shares: {productShares:N3} Product"); //Print product shares formatted to three decimal places
// Console.WriteLine($"     Sub Total: {subtotal:C}"); //Print subtotal formatted as currency
// Console.WriteLine($"           Tax: {taxPercentage:P2}"); //Print tax percentage formatted as a percentage with two decimal places
// Console.WriteLine($"     Total Billed: {total:C}"); //Print total amount due formatted as currency

//Discover padding and alignment
//Formatting strings by adding whitespace before or after

/* string input = "Pad this";
Console.WriteLine(input.PadLeft(12)); 
//adds spaces to the left of the string so that the total length is 12 charactera
//Output: "    Pad this"

// What is an overloaded method? In C#, an overloaded method is another version of a method with different or extra
// arguments that modify the functionality of the method slightly, as is the case with the overloaded version of the
// PadLeft() method.

Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-')); */

//Working with padded strings
// Add the Payment ID to the output
// Add the payee name to the output
// Add the payment amount to the output
// Add a line of numbers above the output to more easily confirm the result

/* string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";
//New code to test appending without padding
//string newString = "Test";

var formattedLine = paymentId.PadRight(6); //Adds spaces to the right of the string so that the total length is 6 characters
formattedLine += payeeName.PadRight(24); //Adds spaces to the right of the string so that the total length is 24 characters
formattedLine += paymentAmount.PadLeft(10); //Adds spaces to the left of the string so that the total length is 10 characters
//How is Test printed after paymentAmount?
//formattedLine += newString; //Appends newString to formattedLine without any padding

Console.WriteLine("1234567890123456789012345678901234567890"); //line of numbers for reference
Console.WriteLine(formattedLine); //Prints the formatted line with padded strings
 */

//Complete a challenge to apply string interpolation to a form letter

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);
