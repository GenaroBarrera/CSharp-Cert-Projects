//Use a simple foreach statement to loop through a string array and identify strings
//That start with the letter B

string[] fraudOrderIds = {"B123","C234","A345","C15","B177","G3003","C235","B179"};
foreach(string id in fraudOrderIds)
{
    if (id.StartsWith("B")) //Use the string.StartsWith() class method to determine if the first char is B
    {
        Console.WriteLine($"{id} starts with 'B'!");
    } 
}