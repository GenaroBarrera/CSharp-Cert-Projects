// What is Composite Formatting?

// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// // string.format method uses placeholders {0} and {1} 
// // to insert the values of first and second into the resulting string.
// Console.WriteLine(result);

// Update your code as follows:

string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
//The order of placeholders can be changed. 
//However {0} still refers to the first argument (first) and {1} refers to the second argument (second).
//Thus the output will be "World Hello!" 
Console.WriteLine("{0} {0} {0}!", first, second); 
//You can use the same placeholder multiple times in the format string. In this case, the value of first will be repeated three times in the output. 
// Second isn't used in this example, but it's still passed as an argument to the WriteLine method.