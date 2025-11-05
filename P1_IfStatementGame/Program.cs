







//create an object of the Random class
Random dice = new Random();

//simulate three dice rolls using Random.Next() method
int roll1 = dice.Next(1, 7); //each dice roll is random from 1-6
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

/*
//hard coded values to test bonus conditons
roll1 = 6;
roll2 = 6;
roll3 = 6;
*/

//calculate and store the total of the three dice rolls
int total = roll1 + roll2 + roll3;

/* --This is my original code--
//determine if two or more dice were of equal value to receive bonus points
//two dice means two bonus points
//all three dice means six bonus points
if(roll1.Equals(roll2) & roll1.Equals(roll3)) total += 6;
else if(roll1.Equals(roll2)) total += 2; //should I use else if or separate if's? 
else if(roll2.Equals(roll3)) total += 2;
else if(roll1.Equals(roll3)) total += 2;
//that should cover all possibilities...

//determine if you've won the game
if(total >= 15) Console.WriteLine("You Won!");
else Console.WriteLine("You Lost Try Again!");
*/

//print dice rolls and final total 
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//now both triple and double bonus conditions are nested inside each other 
//this logic clears the bonus stacking bug we had before
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) //check for doubles
{
    if ((roll1 == roll2) && (roll2 == roll3)) //if doubles are confirmed check for triple
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; //all three rolls are the same, increment triple bonus
    }
    else //we only have a double bonus
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2; //increment double bonus
    }
}//if no rolls are the same this whole code block will be ignored

/*
//Create the win conditions and display the result
if (total >= 15)
{
    Console.WriteLine("You win!");
}
else 
{
    Console.WriteLine("Sorry, you lose.");
}

//Note: in this case the total displayed isn't updated after we add the bonus points
//Also the doulbe bonus will stack if you roll a triple bonus with our current logic. we should avoid that
*/

//modify the win conditions to win prizes instead
//note how if, else if, and else statements are used! (they're not nested in this case!)
if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

/*
The if, else if, and else statements allow you to create multiple exclusive conditions as Boolean expressions. 
In other words, when you only want one outcome to happen, but you have several possible conditions and results, use as many else if statements as you want. 
If none of the if and else if statements apply, the final else code block will be executed. 
The else is optional, but it must come last if you choose to include it.
*/
