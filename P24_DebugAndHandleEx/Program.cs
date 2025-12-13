/*
This application manages transactions at a store check-out line. The
check-out line has a cash register, and the register has a cash till
that is prepared with a number of bills each morning. The till includes
bills of four denominations: $1, $5, $10, and $20. The till is used
to provide the customer with change during the transaction. The item 
cost is a randomly generated number between 2 and 49. The customer 
offers payment based on an algorithm that determines a number of bills
in each denomination. 

Each day, the cash till is loaded at the start of the day. As transactions
occur, the cash till is managed in a method named MakeChange (customer 
payments go in and the change returned to the customer comes out). A 
separate "safety check" calculation that's used to verify the amount of
money in the till is performed in the "main program". This safety check
is used to ensure that logic in the MakeChange method is working as 
expected.
*/

//Top level statements - available in C# 9.0 and later
string? readResult = null; //nullable reference type. string? indicates that readResult can hold a string or a null value
bool useTestData = false; //set to true to use predefined test data for transactions
Console.Clear(); //clear the console window

int[] cashTill = new int[] { 0, 0, 0, 0 }; // index 0 = ones, 1 = fives, 2 = tens, 3 = twenties
int registerCheckTillTotal = 0; // variable to hold the expected total amount in the till

// registerDailyStartingCash: $1 x 50, $5 x 20, $10 x 10, $20 x 5 => ($350 total) 
int[,] registerDailyStartingCash = new int[,] { { 1, 50 }, { 5, 20 }, { 10, 10 }, { 20, 5 } }; // first column is denomination, second column is quantity

int[] testData = new int[] { 6, 10, 17, 20, 31, 36, 40, 41 }; // predefined item costs for testing
int testCounter = 0; // counter to track the current index in the testData array

// load the cash till with the starting cash amounts for the day
LoadTillEachMorning(registerDailyStartingCash, cashTill);

// calculate the expected total amount in the till based on starting cash
registerCheckTillTotal = registerDailyStartingCash[0, 0] * registerDailyStartingCash[0, 1] + registerDailyStartingCash[1, 0] * registerDailyStartingCash[1, 1] + registerDailyStartingCash[2, 0] * registerDailyStartingCash[2, 1] + registerDailyStartingCash[3, 0] * registerDailyStartingCash[3, 1];

// display the number of bills of each denomination currently in the till
LogTillStatus(cashTill);

// display a message showing the amount of cash in the till
Console.WriteLine(TillAmountSummary(cashTill));

// display the expected registerDailyStartingCash total
Console.WriteLine($"Expected till value: {registerCheckTillTotal}\n\r");

var valueGenerator = new Random((int)DateTime.Now.Ticks); // random number generator for item costs

int transactions = 40; // number of transactions to process

if (useTestData) // if using test data, set transactions to the length of the testData array
{
    transactions = testData.Length; // set transactions to the length of the testData array
}

while (transactions > 0) // process transactions until none are left
{
    transactions -= 1; // decrement the transaction counter
    int itemCost = valueGenerator.Next(2, 50); // generate a random item cost between 2 and 19

    if (useTestData) // if using test data, get the item cost from the testData array
    {
        itemCost = testData[testCounter]; // get the item cost from the testData array
        testCounter += 1; // increment the test data counter
    }

    int paymentOnes = itemCost % 2;                 // value is 1 when itemCost is odd, value is 0 when itemCost is even
    int paymentFives = (itemCost % 10 > 7) ? 1 : 0; // value is 1 when itemCost ends with 8 or 9, otherwise value is 0
    int paymentTens = (itemCost % 20 > 13) ? 1 : 0; // value is 1 when 13 < itemCost < 20 OR 33 < itemCost < 40, otherwise value is 0
    int paymentTwenties = (itemCost < 20) ? 1 : 2;  // value is 1 when itemCost < 20, otherwise value is 2

    // display messages describing the current transaction
    Console.WriteLine($"Customer is making a ${itemCost} purchase");
    Console.WriteLine($"\t Using {paymentTwenties} twenty dollar bills");
    Console.WriteLine($"\t Using {paymentTens} ten dollar bills");
    Console.WriteLine($"\t Using {paymentFives} five dollar bills");
    Console.WriteLine($"\t Using {paymentOnes} one dollar bills");

    try
    {
        // MakeChange manages the transaction and updates the till 
        MakeChange(itemCost, cashTill, paymentTwenties, paymentTens, paymentFives, paymentOnes);

        Console.WriteLine($"Transaction successfully completed.");
        registerCheckTillTotal += itemCost; // update the expected total amount in the till
    }
    catch (InvalidOperationException e)
    {
       Console.WriteLine($"Could not complete the transaction: {e.Message}"); // display the exception message
    }


    // Backup Calculation - each transaction adds current "itemCost" to the till
    // if (transactionMessage == "transaction succeeded") // if the transaction was successful
    // {
    //     Console.WriteLine($"Transaction successfully completed.");
    //     registerCheckTillTotal += itemCost; // update the expected total amount in the till
    // }
    // else // if the transaction was unsuccessful
    // {
    //     Console.WriteLine($"Transaction unsuccessful: {transactionMessage}");
    // }

    Console.WriteLine(TillAmountSummary(cashTill)); // display the amount of cash in the till
    Console.WriteLine($"Expected till value: {registerCheckTillTotal}\n\r"); // display the expected total amount in the till
    Console.WriteLine(); //set breakpoint here to examine variables after each transaction.
} // end of while loop for transactions

Console.WriteLine("Press the Enter key to exit"); // prompt the user to press Enter to exit

do // Loop to ensure we don't exit if ReadLine returns null
{
    readResult = Console.ReadLine(); 

} while (readResult == null);

//End of Top level statements-Define methods below this line

// Load the cash till with the starting cash amounts for the day
static void LoadTillEachMorning(int[,] registerDailyStartingCash, int[] cashTill) 
{
    cashTill[0] = registerDailyStartingCash[0, 1]; // Load ones
    cashTill[1] = registerDailyStartingCash[1, 1]; // Load fives
    cashTill[2] = registerDailyStartingCash[2, 1]; // Load tens
    cashTill[3] = registerDailyStartingCash[3, 1]; // Load twenties
}

// Manage the transaction, update the till, and return a message indicating success or failure
static void MakeChange(int cost, int[] cashTill, int twenties, int tens = 0, int fives = 0, int ones = 0)
{
    //string transactionMessage = ""; // Default to empty string, which indicates success

    cashTill[3] += twenties; // Add customer payment to the till
    cashTill[2] += tens; //
    cashTill[1] += fives;
    cashTill[0] += ones;

    int amountPaid = twenties * 20 + tens * 10 + fives * 5 + ones; // Calculate total amount paid by the customer
    int changeNeeded = amountPaid - cost; // Calculate change needed by the customer

    if (changeNeeded < 0) // Check if the customer provided enough money
        //transactionMessage = "Not enough money provided.";
        throw new InvalidOperationException("InvalidOperationException: Not enough money provided to complete transaction.");

    Console.WriteLine("Cashier Returns:"); // Display change being returned to the customer

    while ((changeNeeded > 19) && (cashTill[3] > 0)) // Return twenties as change
    {
        cashTill[3]--;
        changeNeeded -= 20;
        Console.WriteLine("\t A twenty");
    }

    while ((changeNeeded > 9) && (cashTill[2] > 0)) // Return tens as change
    {
        cashTill[2]--;
        changeNeeded -= 10;
        Console.WriteLine("\t A ten");
    }

    while ((changeNeeded > 4) && (cashTill[1] > 0)) // Return fives as change
    {
        cashTill[1]--;
        changeNeeded -= 5;
        Console.WriteLine("\t A five");
    }

    while ((changeNeeded > 0) && (cashTill[0] > 0)) // Return ones as change
    {
        cashTill[0]--;
        changeNeeded--;
        Console.WriteLine("\t A one");
    }

    if (changeNeeded > 0) // If unable to provide exact change
        throw new InvalidOperationException("InvalidOperationException: The till is unable to make the correct change.");

    // if (transactionMessage == "") // If no errors, set success message
    //     transactionMessage = "transaction succeeded";

    //return transactionMessage; // Return the transaction message
}

// Log the current status of the cash till
static void LogTillStatus(int[] cashTill)
{
    Console.WriteLine("The till currently has:"); // Display the number of bills of each denomination in the till
    Console.WriteLine($"{cashTill[3] * 20} in twenties"); //
    Console.WriteLine($"{cashTill[2] * 10} in tens");
    Console.WriteLine($"{cashTill[1] * 5} in fives");
    Console.WriteLine($"{cashTill[0]} in ones");
    Console.WriteLine();
}

// Return a summary string of the total amount in the cash till
static string TillAmountSummary(int[] cashTill)
{
    return $"The till has {cashTill[3] * 20 + cashTill[2] * 10 + cashTill[1] * 5 + cashTill[0]} dollars"; // Calculate and return the total amount in the till

}

//COMMIT ANYTHING YOU HAVE TO GIT BEFORE CONTINUING TO THE NEXT PATH!
//commit message suggestion: "P24 Debug and Handle Exceptions complete"
//commit all changes including Program.cs and P24_DebugAndHandleEx.csproj