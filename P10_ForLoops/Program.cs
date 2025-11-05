/*
//for loop exapmle breakdown

for (int i = 0; i < 10; i++) //for keyword: the parenthesis contain the conditions of for iteration (three sections separated by ;)
//1: first initializer - i is the iterator variable. init at 0
//2: second condition - is the completion condition. we will iterate over the code block while i is less than 10
//3: third iterator -  defines the action to take after each iteration (iterator). in this case, we increase i by 1 for each iteration
{
    Console.WriteLine(i); //our code block (body): executed on every iteration
}
*/

//iterate over i in reverse
// for (int i = 10; i >= 0; i--) 
// {
//     Console.WriteLine(i);
// }

//increment the iterator by 3
// for (int i = 0; i < 10; i += 3) 
// {
//     Console.WriteLine(i);
// }

//using the break keyword in for loops
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break; //break causes us to exit for loops immediately
// }

//loop through an array starting from the last element
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--) //note: we init i to names.Length - 1 since arrays are 0 indexed
// {
//     Console.WriteLine(names[i]);
// }

//limitations of the foreach loop
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// foreach (var name in names)
// {
//     // Can't do this: trying to change the value of an element (can't assign to name since it's the foreach iteration variable)
//     if (name == "David") name = "Sammy";
// }

//overcoming this limitation with a for loop instead
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = 0; i < names.Length; i++) //note: braces aren't needed if it's a one liner code block
//     if (names[i] == "David") names[i] = "Sammy"; //replaces any element that contains "David" with "Sammy"

// foreach (var name in names) Console.WriteLine(name); //print the names array using a foreach

/* 
//Challange activity - FizzBuzz challenge
Here are the FizzBuzz rules that you need to implement in your code project:

Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
When the current value is divisible by 3, print the term Fizz next to the number.
When the current value is divisible by 5, print the term Buzz next to the number.
When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.
*/

for (int i = 1; i <= 100; i++)
{
    //if divisible by 3 and 5
    if ((i % 3 == 0) && (i % 5 == 0)) //Note: this condition must come first otherwise it'll enter one of the other two if statements before
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    //if divisible by 3 only
    else if (i % 3 == 0) //modulus 0 means i is divisible by 3
    {
        Console.WriteLine($"{i} - Fizz");
    }
    //if divisible by 5 only
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    //default condition
    else Console.WriteLine(i); 
}



