//Create an array of pallets, then sort them

/* string[] pallets = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} */

//Reverse the order of the pallets

/* string[] pallets = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

string[] pallets = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine(""); */

//Use array methods to clear and resize an array

/* string[] pallets = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} */

// When you use Array.Clear(), the elements that were cleared no longer reference a string in memory. In fact, the
// element points to nothing at all. Pointing to nothing is an important concept that can be difficult to grasp at
// first.

//Access the value of a cleared element
/* string[] pallets = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} */

// If you focus on the line of output After: , you might think that the value stored in pallets[0] is an empty string.
// However, the C# Compiler implicitly converts the null value to an empty string for presentation.

//Call a string helper method on a cleared element, to demonstrate that it is null

/* string[] pallets = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} */

// The line that attempts to call ToLower() on pallets[0] throws a System.NullReferenceException because pallets[0] is null.
// A null value means that the element does not reference any object in memory. Therefore, there is no object on which
// to call the ToLower() method, resulting in the exception.

//so does that mean strings are objects, and therefore reference types?
//Yes, strings in C# are indeed reference types. In C#, a string is an object of the System.String class, which is part of the .NET Framework.
//As a reference type, when you create a string variable, it holds a reference (or pointer) to the actual string data stored in memory, rather than the data itself.
//This means that when you assign one string variable to another, both variables refer to the same string object in memory until one of them is changed (since strings are immutable in C#).

//Resize the array to add more elements

/* string[] pallets =  ["B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6); // what does ref mean here? 
//The ref keyword in C# is used to pass an argument by reference, rather than by value. When
// you use ref, any changes made to the parameter inside the method will be reflected in the original variable that was
// passed in. In the case of Array.Resize, the method needs to modify the reference to the array itself because resizing
// an array involves creating a new array and copying the elements from the old array to the new one. By using ref, the
// method can update the reference of the original array variable to point to the newly created array.
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} */

//Resize the array to remove elements

// string[] pallets = [ "B14", "A11", "B12", "A13" ];
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2); //clears the first two elements of the array, setting them to null.
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6); //increases the size of the array to 6 elements, the new elements are initialized to null.
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3); //reduces the size of the array to 3 elements, the elements beyond the new size are discarded.
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Notice that calling Array.Resize() didn't eliminate the first two null elements. Rather, it removed the last three
// elements. Notably, last three elements were removed even though they contained string values.

//Can you remove null elements from an array?
// If the Array.Resize() method doesn't remove empty elements from an array, is there another helper method that does
// the job automatically? NO. The best way to empty elements from an array would be to count the number of non-null
// elements by iterating through each item and increment a variable (a counter). Next, you would create a second array
// that is the size of the counter variable. Finally, you would loop through each element in the original array and copy
// non-null values into the new array.

//New array elements and cleared elements are null, meaning they don't point to a value in memory.

// Discover Split() and Join() 
//To perform data transformation, you need to accept incoming data as a string, parse it
// into smaller data elements, then manipulate it to match different format required. How can you parse the string data
// into smaller data elements?

// Use the ToCharArray() to reverse a string

// string value = "abc123";
// char[] valueArray = value.ToCharArray(); //Converts the string into an array of characters
// Array.Reverse(valueArray); //Reverses the order of the characters in the array
// string result = new string(valueArray);
// Console.WriteLine(result);

// Combine all of the chars into a new comma-separated-value string using Join()

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray); //Joins the characters in the array into a single string, with commas between each character
// Console.WriteLine(result);

// Split() the comma-separated-value string into an array of strings

// string value = "abc123";
// char[] valueArray = value.ToCharArray(); //Converts the string into an array of characters
// Array.Reverse(valueArray); //Reverses the order of the characters in the array
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray); //Joins the characters in the array into a single string, with commas between each character
// Console.WriteLine(result);

// string[] items = result.Split(','); //Splits the string into an array of strings, using the comma as the delimiter
// foreach (string item in items)
// {
//     Console.WriteLine(item); //Outputs each item in the array on a new line
// }

/* Recap

Here are a few key points to remember when working with strings and arrays:

    To create an array, use methods like ToCharArray() and Split()
    To turn the array back into a single string, use methods like Join(), or create a new string passing in an array of char
 */

// Complete a challenge to reverse words in a sentence

/* The following solution provided is one of many possible solutions. The approach taken to solve this challenge was to break down the solution into four steps:

    1 To create the string array message, split the pangram string on the space character.
    2 Create a new newMessagearray that stores a reversed copy of the "word" string from the message array.
    3 Loop through each element in the message array, reverse it, and store this element in newMessage array.
    4 Join "word" strings from the array newMessage, using a space again, to create the desired single string to write to the console.
 */

 string pangram = "The quick brown fox jumps over the lazy dog"; // Original sentence in a string variable

// Step 1
string[] message = pangram.Split(' '); // Split the pangram into words, using space as the delimiter

//Step 2
string[] newMessage = new string[message.Length]; // Create a new string array to hold the reversed words

// Step 3
for (int i = 0; i < message.Length; i++) // Loop through each word in the original message array, using its index
{
    char[] letters = message[i].ToCharArray(); // Convert the current word to a char array
    Array.Reverse(letters); // Reverse the order of characters in the char array
    newMessage[i] = new string(letters); // Create a new string from the reversed char array and store it in the newMessage array at the same index
}

//Step 4
string result = String.Join(" ", newMessage); // Join the reversed words into a single string, using space as the delimiter
Console.WriteLine(result); // Output the final reversed sentence to the console

// Complete a challenge to parse a string of orders, sort the orders and tag possible errors
// Add code below the previous code to parse the "Order IDs" from the string of incoming orders and store the "Order IDs" in an array.
// Add code to output each "Order ID" in sorted order and tag orders that aren't exactly four characters in length as "- Error".


string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(','); // Split the orderStream into individual order strings using comma as the delimiter
Array.Sort(items); // Sort the array of order strings in ascending order

foreach (var item in items) // Loop through each order string in the sorted array
{
    if (item.Length == 4) // Check if the length of the order string is exactly 4 characters
    {
        Console.WriteLine(item); //if successful, output the order string as is
    }
    else // If the length is not 4 characters
    {
        Console.WriteLine(item + "\t- Error"); //output the order string followed by a tab and "- Error" to indicate an issue with the order
    }
}
