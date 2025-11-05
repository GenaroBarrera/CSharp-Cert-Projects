/*
 Your task is to display a renewal message when a user logs into the software system and is notified their subscription will soon end. 
 You'll need to add a couple of decision statements to properly add branching logic to the application to satisfy the requirements.
 
 // Business rules
Rule 1: Your code should only display one message.
    The message that your code displays will depend on the other five rules. For rules 2-6, 
    the higher numbered rules take precedence over the lower numbered rules.

Rule 2: If the user's subscription will expire in 10 days or less, display the message:
    Your subscription will expire soon. Renew now!

Rule 3: If the user's subscription will expire in five days or less, display the messages:
    Your subscription expires in _ days.
    Renew now and save 10%!

Rule 4: If the user's subscription will expire in one day, display the messages:
    Your subscription expires within a day!
    Renew now and save 20%!

Rule 5: If the user's subscription has expired, display the message:
    Your subscription has expired.

Rule 6: If the user's subscription doesn't expire in 10 days or less, display nothing.
*/

// initial code
Random random = new Random();
int daysUntilExpiration = random.Next(12); //generated rand int from 0-11
int discountPercentage = 0; //var to store percentage of discount, will vary depending on days left

//Test Code (remove later)
//daysUntilExpiration = 9;
//daysUntilExpiration = 4;
//daysUntilExpiration = 1;
//daysUntilExpiration = 0;

//check the number of days remaining
Console.WriteLine(daysUntilExpiration);

if(daysUntilExpiration <= 10 && daysUntilExpiration >= 6) //rule 2 (take into account implied conditions!)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if(daysUntilExpiration <= 5 && daysUntilExpiration >= 2) //rule 3
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!"); //Note: the use of interpolation and verbatim prefixes
}
else if(daysUntilExpiration == 1) //rule 4
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
}
else if(daysUntilExpiration == 0) //rule 5
{
    Console.WriteLine("Your subscription has expired.");
}
//rule 6 (do nothing)








