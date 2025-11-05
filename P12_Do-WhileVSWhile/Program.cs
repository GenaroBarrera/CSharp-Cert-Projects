//***prompt the user for simple string input
// string? readResult; //use a nullable type string for the input variable
// Console.WriteLine("Enter a string:"); //display to prompt the user for input

// do //use a do while loop in order to prompt the user for input at least once
// {
//     readResult = Console.ReadLine(); //Use ReadLine to obtain user input
// } while (readResult == null); //keep looping while readResult is null

//***prompt the user to enter a string of at least three characters
// string? readResult;
// bool validEntry = false; //used to determine if the user input entry is valid
// Console.WriteLine("Enter a string containing at least three characters:");

// do
// {
//     readResult = Console.ReadLine(); 
//     if (readResult != null) //first check if we got any input
//     {
//         if (readResult.Length >= 3) //check if the string is longer than 3 chars
//         {
//             validEntry = true; //if so mark validEntry to true
//         }
//         else //else keep prompting the user for input
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
// } while (validEntry == false); //keep looping until we get a string of at least 3 chars

//***capture user input in a string variable named readResult
// int numericValue = 0;
// bool validNumber = false;

// validNumber = int.TryParse(readResult, out numericValue);

/*
//***Code project 1 - write code that validates integer input

Here are the conditions that your first coding project must implement:
Your solution must include either a do-while or while iteration.

Before the iteration block: 
your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

Inside the iteration block:
Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the input is a valid representation of an integer.
If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
*/


// string? readResult;
// int numericValue = 0; //store our parsed integer here
// bool validEntry = false; //validate we can parse to an integer
// bool validNumber = false;  //validate integer is between 5-10
// //prompt user for a number 5-10
// Console.WriteLine("Enter an integer value between 5 and 10");

// do //when prompting a user for input we should use a do-while loop
// {
//     readResult = Console.ReadLine(); //obtain user input from terminal
//     if (readResult != null) //make sure readResult is not null
//     {
//         //parse the input string to an integer
//         validEntry = int.TryParse(readResult, out numericValue); //if input is parsed, validEntry is set to true and resulting int is stored

//         if (numericValue >= 5 && numericValue <= 10)
//         {
//             validNumber = true;
//         }
//         else
//         {
//             Console.WriteLine("Sorry, you entered an invalid number, please try again");
//         }
//     }
// } while (validNumber == false); //keep looping until we're able to parse a number between 5-10

// Console.WriteLine($"Your input value {numericValue} has been accepted."); //print accepted parsed integer

/*
//***Code project 2 - write code that validates string input
Your solution must include either a do-while or while iteration.

Before the iteration block: 
your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

Inside the iteration block:
Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the value entered matches one of the three role options.
Your solution should use the Trim() method on the input value to ignore leading and training space characters.
Your solution should use the ToLower() method on the input value to ignore case.
If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
*/

// string? readResult;
// //we need this var to determine wheter we keep looping or not
// bool validRole = false;
// //Prompt the user for an access role
// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

// do //when prompting a user for input we should use a do-while loop
// {
//     readResult = Console.ReadLine(); //obtain user input from terminal

//     if (readResult != null) //make sure readResult is not null
//     //trim the input and transform string to lower case
//     readResult = readResult.Trim().ToLower(); //method chaining should work...
//     {
//         //check if readresult matches a role (This should've been a case switch...)
//         if (readResult == "administrator") //use == operator instead since you're comparing values not obj instances
//         {
//             Console.WriteLine("Your input value (Administrator) has been accepted.");
//             validRole = true;

//         }
//         else if(readResult == "manager")
//         {
//             Console.WriteLine("Your input value (Manager) has been accepted.");
//             validRole = true;
//         }
//         else if(readResult == "user")
//         {
//             Console.WriteLine("Your input value (user) has been accepted.");
//             validRole = true;
//         }
//         else //default case
//         {
//             Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");
//         }
//     }
// } while (validRole == false); //keep looping until we get a valid Role as input


/*
//***Code project 3 - Write code that processes the contents of a string array

Here are the conditions that your third coding project must implement:

your solution must use the following string array to represent the input to your coding logic:
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

Your solution must include an outer foreach or for loop that can be used to process each string element in the array. The string variable that you'll process inside the loops should be named myString.
In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the myString variable. The method call should be similar to: myString.IndexOf("."). If there's no period character in the string, a value of -1 will be returned.
Your solution must include an inner do-while or while loop that can be used to process the myString variable.
In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.
In the inner loop, your solution must not display the period character.
In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information.
*/

string[] myStrings = new string[] { "I like pizza. I like roast chicken. I like salad", "The fox is brown. The dog is spotted.", "", ".", "I like all three of the menu choices" };
string myString = ""; //var to process string elements
int periodLocation = 0; //var to hold period location

//outer for loop will iterate through string elements 
//use a for statement since you can't modify the value of a 'foreach iteration variable'
for (int i = 0; i < myStrings.Length; i++)
{
    myString = myStrings[i]; //assign myString to the current element
    periodLocation = myString.IndexOf("."); //get location of first period found

    string mySentence; //local var to hold a complete sentence

    // extract sentences from each string and display them one at a time
    //use a while in situations where the body may not be entered at all (incase there are no periods found)
    while (periodLocation != -1) //loop while we keep finding periods in myString
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation); //removes all characters to the right including the period (save to mySentence as to not alter myString)

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1); //creates a new string of all the chars after the period

        // remove any leading white-space from myString
        myString = myString.TrimStart(); //Note: we usually place a space after a period

        // get the location of the next period in myString
        periodLocation = myString.IndexOf(".");

        if(mySentence == "")//if there were no characters left of the period (i.e ".")
        {
            //don't print a last sentence, skip to next iteration
            continue; 
        }
        //display the sentence we found (chars left of the first period)
        Console.WriteLine(mySentence);
    }

    if(myString == "") //if myString is empty at this point
    {
        //don't print a last sentence, skip to next iteration
        continue;
    }
    
    //Once we're on the last sentence/or a string has no periods inside
    mySentence = myString.Trim(); //remove all leading and trailing whitespace from the string
    //shouldn't we check if myString could be empty/null at this point?

    //display the last/only sentence found in myString
    Console.WriteLine(mySentence);
}
