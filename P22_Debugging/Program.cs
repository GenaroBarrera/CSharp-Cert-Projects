// string[] students = new string[] {"Sophia", "Nicolas", "Zahirah", "Jeong"};

// int studentCount = students.Length - 1; //This should be students.Length - 1 to access the last index since arrays are zero-indexed.

// Console.WriteLine("The final name is: " + students[studentCount]); //Print the last name in the array

/* Code debugging process

When you notice a bug in your code, it can be tempting to try a direct approach. You know, that quick scan where you
think the issue might be. If it pays off in the first 30 seconds, great, but don't let yourself be sucked in. Don't keep
going to that next spot, and the next. Don't let yourself throw time against the following approaches:

    Reading through your code (just one more time) hoping that this time the issue jumps out at you.
    Breadcrumbing a few Console.WriteLine("here") messages in your code to the track progress through your app.
    Rerunning your app with different data. Hoping that if you see what works, you'll understand what doesn't work.

You might have experienced various degrees of success with these methods, but don't be fooled. There is a better way. */

/* Why use a debugger

If you're not running your code through a debugger, you're probably guessing at what's happening in your application at
runtime. The primary benefit of using a debugger is that you can watch your program running. You can follow program
execution one line of code at a time. This approach minimizes the chance of guessing wrong. */

/* Every debugger has its own set of features. The two most important features that come with almost all debuggers are:

Control of your program execution. You can pause your program and run it step by step, which allows you to see what code
is executed and how it affects your program's state.

Observation of your program's state. For example, you can look at the value of your variables and function parameters at
any point during your code execution.
 */

 /* What does it mean to "throw" and "catch" an exception?

The terms "throw" and "catch" can be explained by evaluating the definition of an exception.

The second sentence of the definition says "Exceptions are thrown by code that encounters an error and caught by code
that can correct the error". The first part of this sentence tells you that exceptions are created by the .NET runtime
when an error occurs in your code. The second part of the sentence tells you that you can write code to catch an
exception that's been thrown. 

After evaluating that second sentence of the definition, you know the following:

    An exception gets created at runtime when your code produces an error.
    The exception can be treated like a variable that has some extra capabilities.
    You can write code that accesses the exception and takes corrective action.*/