/* 
This code uses a names array and corresponding methods to display
greeting messages
*/

/* string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

string messageText = "";

foreach (string name in names)
{
    if (name == "Sophia") //(Breakpoint here) The Step Into button is used to advance to the next executable statement.
        messageText = SophiaMessage(); //(step into) Since the first element in the names array is Sophia and the if statement is checking for the name Sophia, the expression evaluates to true and code execution moves into the code block of the if statement.
    else if (name == "Andrew")
        messageText = AndrewMessage();
    else if (name == "AllGreetings")
    {//added curly braces to fix bug
        messageText = SophiaMessage();
        messageText = messageText + "\n\r" + AndrewMessage();//(step into) Note: this line is outside the else if code block because there are no curly braces surrounding the else if code block. This is a bug in our code. Andrew's message will be added to messageText each time the loop iterates.
    }
    Console.WriteLine(messageText + "\n\r");
}

bool pauseCode = true;
while (pauseCode == true);

static string SophiaMessage()
{//(step into) Notice that code execution advances to the SophiaMessage method and pauses. The Step Into button has advanced to the next executable code line. The next executable code line isn't the next line number in the file, it's the next statement in the execution path. In this case, the next executable statement is the entry point to the SophiaMessage method.
    return "Hello, my name is Sophia."; //(Step out) When inside a method, the Step Out button completes the remaining lines of the current method and then returns to the execution context that invoked the method. (The method call at line 13)
}

static string AndrewMessage()
{
    return "Hi, my name is Andrew. Good to meet you.";
}
 */

//left off at Set Breakpoints section
//ALRIGHT TIME TO DEBUG
//This's one for github green 
//do it all for the nookie

int productCount = 2000; //number of products to process
string[,] products = new string[productCount, 2]; //2D array to hold product data

LoadProducts(products, productCount); //load product data into the products array

for (int i = 0; i < productCount; i++)
{
    string result;
    result = Process1(products, i); //breakpoint here, step into Process1

    /* Take a moment to consider the advantage that conditional breakpoints offer. (51: products[i,1] == "new";)

In this simulated data processing scenario, there is about a 1% chance that a product is new. If you're using a standard
breakpoint to debug the issue, you'd need to walk through the analysis of about 100 products to find one of the new
products that you're interested in.

Conditional breakpoints can save you lots of time when you're debugging an application.
 */

    if (result != "obsolete")
    {
        result = Process2(products, i);
    }
}

bool pauseCode = true;
while (pauseCode == true) ;

//Method to generate data for the simulated processes
// The LoadProducts method generates 2000 random product IDs and assigns a value of existing, new, or obsolete to a
// product description field. There is about a 1% chance that the products are marked new.
static void LoadProducts(string[,] products, int productCount)
{
    Random rand = new Random();

    for (int i = 0; i < productCount; i++)
    {
        int num1 = rand.Next(1, 10000) + 10000;
        int num2 = rand.Next(1, 101);

        string prodID = num1.ToString();

        if (num2 < 91)
        {
            products[i, 1] = "existing";
        }
        else if (num2 == 91)
        {
            products[i, 1] = "new";
            prodID = prodID + "-n";
        }
        else
        {
            products[i, 1] = "obsolete";
            prodID = prodID + "-0";
        }

        products[i, 0] = prodID;
    }
}

//Methods To simulate data processing
// The Process1 and Process2 methods display progress messages and return a string.
static string Process1(string[,] products, int item)
{
    Console.WriteLine($"Process1 message - working on {products[item, 1]} product");

    return products[item, 1];
}

static string Process2(string[,] products, int item)
{
    Console.WriteLine($"Process2 message - working on product ID #: {products[item, 0]}");
    if (products[item, 1] == "new")
        Process3(products, item); //call Process3 if product is new

    return "continue";
}

//Process3 method to handle new products. Displays a message indicating that new product information is being processed.
static void Process3(string[,] products, int item)
{
    Console.WriteLine($"Process3 message - processing product information for 'new' product");
}

