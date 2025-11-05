/*
This code converts a given string to a char array and then reverses the char array.
We then use a foreach loop to determine how many "o" chars there are.
Lastly, convert the char array back to a string and print it 
Print the number of times "o" appears as well 
*/

/* (Better comment)
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog."; //include better var names

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");