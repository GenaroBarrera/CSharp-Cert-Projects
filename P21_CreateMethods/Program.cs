//How methods work
// The process of developing a method begins with creating a method signature. The method signature declares the
// method's return type, name, and input parameters. For example, consider the following method signature:

/* int[] a = {1,2,3,4,5};

Console.WriteLine("Contents of Array:");
PrintArray();

void PrintArray()
{
    foreach (int x in a)
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();
} */

/* Best practices

When choosing a method name, it's important to keep the name concise and make it clear what task the method performs.
Method names should be Pascal case and generally shouldn't start with digits. Names for parameters should describe what
kind of information the parameter represents. Consider the following method signatures: */
// void ShowData(string a, int b, int c); // Not descriptive
// void DisplayDate(string month, int day, int year); // Descriptive

/* Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

void DisplayRandomNumbers() 
{
    Random random = new Random();

    for (int i = 0; i < 5; i++) 
    {
        Console.Write($"{random.Next(1, 100)} ");
    }

    Console.WriteLine();
} */

/* Methods are useful for organizing code, reusing code, and for tackling problems efficiently. You can think of a
method like a black box that takes input, performs the named task, and returns output. With this assumption, you can
quickly structure programs just by naming your tasks as methods, and then filling in the logic after you've identified
all of the necessary tasks.

When you use plain language to describe steps in code, without strictly adhering to syntax rules, you're using
"pseudo-code". Combining methods and pseudo-code is a great way to quickly power through any challenging programming
task. Use methods to structure code 

Suppose you're a candidate in a coding interview. The interviewer wants you to write a program that checks whether an
IPv4 address is valid or invalid. You're given the following rules:

    //***these are the three steps***
    A valid IPv4 address consists of four numbers separated by dots
    Each number must not contain leading zeroes
    Each number must range from 0 to 255

1.1.1.1 and 255.255.255.255 are examples of valid IP addresses.*/

/* // At the beginning of your program, create variables to store the input and validation statuses:
string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"}; //example input strings
/* Lastly, you need to fix the input data each method uses since you updated ipv4Input from a string to an array. Since
each method uses string.Split, you can declare a variable to store the result of string.Split and use it in each method
instead. */
/* string[] address; 
bool validLength = false; //check for 4 numbers
bool validZeroes = false; //check for no leading zeroes
bool validRange = false; //check for range between 0-255 */ 

/* When developing a solution, it is important to test your code with different input cases. In this code, you provide a
decent range of test values. Now that you've updated your test input, you'll need to update your code to use the new
values. Since the values are in an array, you'll need to update your code to test each one using a loop. */
/* foreach (string ip in ipv4Input) //loop through each input string
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries); // Split the input string into an array using '.' as the delimiter, removing any empty entries
    // running this line before each validation method ensures that each method uses the correct input data. Also
    // reduces redundancy since you don't need to call string.Split in each method anymore.

    ValidateLength(); //call method to validate length
    ValidateZeroes();  //call method to validate leading zeroes
    ValidateRange(); //call method to validate range

    if (validLength && validZeroes && validRange) //check if all validations passed
    {
        Console.WriteLine($"{ip} is a valid IPv4 address"); //output valid message
    } 
    else 
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address"); //output invalid message
    }
} */

// Step 1
// if ipAddress consists of 4 numbers
// and
// if each ipAddress number has no leading zeroes
// and
// if each ipAddress number is in range 0 - 255
// In this step, you transform the if statements from your pseudo-code into callable methods and output the results. 

// Step 2
// then ipAddress is valid

// Step 3
// else ipAddress is invalid

//define methods
// The first rule states that the IPv4 address needs to have four numbers. So in this code, you use string.Split to
// separate the digits and check that there are four of them.
/* void ValidateLength()
{
    //string[] address = ipv4Input.Split('.'); // Split the input string into an array using '.' as the delimiter
    validLength = address.Length == 4; // Check if the length of the array is 4 and assign the result to validLength. True if it is, false otherwise
} */

// The second rule states that the numbers in the IPv4 address must not contain leading zeroes. So the method needs to
// check numbers for leading zeroes while accepting 0 as a valid number. If all the numbers have valid zeroes,
// validZeroes should be equal to true, and false otherwise.
/* void ValidateZeroes() 
{
    //string[] address = ipv4Input.Split("."); // Split the input string into an array using '.' as the delimiter

    foreach (string number in address) // Iterate through each number in the address array
    {
        if (number.Length > 1 && number.StartsWith("0")) // Check if the number has more than one digit and starts with '0'. This check takes into account that '0' itself is a valid number.
        {
            validZeroes = false; // If a leading zero is found, set validZeroes to false
            return; // Exit the method early since we found an invalid number. This prevents validZeroes from being set to true later on.
        }
    }

    //This line should only be reached if no leading zeroes were found in any of the numbers.
    validZeroes = true; //If no leading zeroes are found, set validZeroes to true. This line should be outside the loop to ensure it only sets validZeroes to true if all numbers are valid.
} */

/* The third rule states that each number in the IPv4 address must range from 0 to 255. So in this code, you check that
each number is less than 255, and if not, terminate execution after setting validRange to false. Since the input string
only contains digits and dots, you don't need to check for negative numbers. */
/* void ValidateRange() 
{
    //string[] address = ipv4Input.Split(".", StringSplitOptions.RemoveEmptyEntries);// Split the input string into an array using '.' as the delimiter, removing any empty entries

    foreach (string number in address) // Iterate through each number in the address array
    {
        int value = int.Parse(number); // Convert the string number to an integer
        if (value < 0 || value > 255) // Check if the integer value is outside the range of 0 to 255. || represents the logical OR operator.
        {
            validRange = false; // If a number is out of range, set validRange to false
            return; // Exit the method early since we found an invalid number
        }
    }
    validRange = true; // If all numbers are within the valid range, set validRange to true
} */

/* Recap

Here's what you've learned about using methods so far:

    Methods can be used to quickly structure applications
    The return keyword can be used to terminate method execution
    Each step of a problem can often be translated into its own method
    Use methods to solve small problems to build up your solution
 */


/* Code Challenge Tell a fortune

You're helping to develop a massive multiplayer role-playing game. Each player has a luck stat that can affect their odds of finding rare treasure. Each day, a player can speak to an in-game fortune teller that reveals whether their luck stat is high, low, or neutral.

The game currently has code to generate a player's fortune, but it isn't reusable. Your task is to create a tellFortune method that can be called at any time, and replace the existing logic with a call to your method.

In this challenge, you're given some starting code. You must decide how to create and call the tellFortune method. */

/* Random random = new Random(); // Create a Random object to generate random numbers
int luck = random.Next(100); // generate a random luck value between 0 and 99

// Arrays to hold different parts of the fortune messages. Each array contains four strings that correspond to different fortune scenarios.
string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

TellFortune(); // Call the TellFortune method to display the fortune based on the luck value

void TellFortune() // Define the TellFortune method. The method does not take any parameters and does not return any value.
{
    Console.WriteLine("A fortune teller whispers the following words:"); // Output a message indicating that the fortune teller is speaking
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral)); // Determine which fortune array to use based on the luck value using a nested ternary operator
    // if luck is greater than 75, use the good fortune array; if luck is less than 25, use the bad fortune array;
    // otherwise, use the neutral fortune array. The ? is the ternary operator that acts as a shorthand for if-else
    // statements. The : operator separates the true and false parts of the condition.
    //Ternary operators can be nested to handle multiple conditions in a compact form. They are useful for simple conditional assignments but can reduce code readability if overused or nested too deeply.
    
    for (int i = 0; i < 4; i++) // Loop through the indices of the possible fortune messages. Each fortune consists of four parts.
    {
        Console.Write($"{text[i]} {fortune[i]} "); //This line outputs a part of the fortune message by combining a phrase from the text array with a corresponding phrase from the selected fortune array (good, bad, or neutral).
    }
    // The loop iterates four times, once for each part of the fortune message.
}
 */

 /* Create an RSVP application

In this task, you'll create a brief application for guests to RSVP to an event. The guests will provide their party size
and any allergies. You'll also add the option to restrict RSVPs to an invite-only guest list. */

// string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"}; // Example guest list
// string[] rsvps = new string[10]; // Array to store RSVP details, with a maximum of 10 RSVPs
// int count = 0; // Counter to keep track of the number of RSVPs received

/* RSVP("Rebecca", 1, "none", true);
RSVP("Nadia", 2, "Nuts", true); //this method call is using positional arguments
RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false); //This example uses named arguments for clarity
//RSVP("Linh", partySize: 2, "none", false); //this method call mixes positional and named arguments, which is allowed as long as positional arguments come first.
//RSVP(allergies: "none", inviteOnly: false, "Linh", 2); //this is an invalid method call because positional arguments cannot follow named arguments.
RSVP("Tony", inviteOnly: true, allergies: "Jackfruit",  partySize: 1); //Notice that the named arguments don't have to appear in the original order. However, the unnamed argument Tony is a positional argument, and must appear in the matching position.
RSVP("Noor", 4, "none", false);
RSVP("Jonte", 2, "Stone fruit", false); */

/* RSVP("Rebecca"); // Using default values for optional parameters
RSVP("Nadia", 2, "Nuts");
RSVP(name: "Linh", partySize: 2, inviteOnly: false);
RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
RSVP("Noor", 4, inviteOnly: false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

//This method collects RSVP details from a guest.
//void RSVP(string name, int partySize, string allergies, bool inviteOnly) //parameters for guest name, party size, allergies, and invite-only status. 
void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true) //This version makes partySize, allergies, and inviteOnly optional parameters with default values.
{                                                                        
    if (inviteOnly) // If the event is invite-only, check if the guest is on the guest list.
    {
        bool found = false; // Flag to track if the guest is found in the guest list
        foreach (string guest in guestList) // Iterate through each guest in the guest list
        {
            if (guest.Equals(name)) // Check if the current guest matches the provided name
            {
                found = true; // If a match is found, set the found flag to true
                break; // Exit the loop early since the guest has been found
            }
        }
        if (!found) // If the guest was not found in the guest list
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list"); // Output a message indicating the guest is not invited
            return; // Exit the RSVP method early since the guest is not invited
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}"; // Store the RSVP details in the rsvps array at the current count index
    count++; // Increment the count of RSVPs received
}

//This method displays all the RSVPs received so far.
void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:"); // Output a header for the RSVP list
    for (int i = 0; i < count; i++) // Loop through the rsvps array up to the current count of RSVPs
    {
        Console.WriteLine(rsvps[i]); // Output each RSVP detail
    }
} */

/* Use named arguments

When calling a method that accepts many parameters, it can be tricky to understand what the arguments represent. Using
named arguments can improve the readability of your code. Use a named argument by specifying the parameter name followed
by the argument value. In this task, you'll practice using named arguments. */

/* Declare optional parameters

A parameter becomes optional when it's assigned a default value. If an optional parameter is omitted from the arguments,
the default value is used when the method executes. In this step, you'll make the parameters partySize, allergies and
inviteOnly optional. */

double total = 0; // Initialize total variable to store the cumulative price
double minimumSpend = 30.00; // Minimum spend required to qualify for a discount

double[] items = {15.97, 3.50, 12.25, 22.99, 10.98}; // Array of item prices
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50}; // Corresponding array of discount rates for each item

for (int i = 0; i < items.Length; i++) // Loop through each item in the items array
{
    total += GetDiscountedPrice(i); // Call the GetDiscountedPrice method to calculate the discounted price for each item and add it to the total
}

total -= TotalMeetsMinimum()?  5.00 : 0.00; // If the total meets the minimum spend, subtract a $5.00 discount from the total using the TotalMeetsMinimum method

Console.WriteLine($"Total: ${FormatDecimal(total)}"); // Output the final total formatted to 5 characters using the FormatDecimal method

double GetDiscountedPrice(int itemIndex) // Method to calculate the discounted price for a given item
{
    return items[itemIndex] * (1 - discounts[itemIndex]); // Calculate and return the discounted price by multiplying the item price by (1 - discount rate)
}

bool TotalMeetsMinimum() // Method to check if the total meets the minimum spend requirement
{
    return total >= minimumSpend; // Return true if total is greater than or equal to minimumSpend, otherwise return false
}

string FormatDecimal(double input) // Method to format a decimal number (not decimal type) to a string with a maximum of 5 characters
{
    return input.ToString().Substring(0, 5); // Convert the input to a string and return the first 5 characters
}