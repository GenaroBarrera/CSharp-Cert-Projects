/* 
This code uses a names array and corresponding methods to display
greeting messages
*/

string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

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

//left off at Set Breakpoints section
//ALRIGHT TIME TO DEBUG
//This's one for github green 