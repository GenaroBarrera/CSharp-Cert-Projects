// //***do-while loop example
// Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1, 11); //will randomly generate a number from 1-10 (remember second parameter is non-inclusive)
//     Console.WriteLine(current); //print current to terminal
// } while (current != 7); //condition is true as long as current is not 7 (will keep iterating until current is 7)
// //note: even if current is 7 on the first iteration it will still execute the body at least once!


// //***while loop example 
// Random random = new Random();
// int current = random.Next(1, 11);

// //Note: this changes the code flow and the while keyword acts as a gate instead
// while (current >= 3) //in this case the while statement and Boolean expression are evaluate before the code block
// {
//     Console.WriteLine(current); //print current
//     current = random.Next(1, 11); //assign current a rand number
// }
// Console.WriteLine($"Last number: {current}"); //print the last number saved into current 
// //(it will not get printed in the while body since the while condition is evaluated before the code block)

// //***Use the Continue statement to step directly to the Boolean expression
// Random random = new Random();
// int current = random.Next(1, 11);

// do //will execute at least once
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue; //if true, continue keyword will transfer control to the end of the code block and the while condition will be evaluated

//     Console.WriteLine(current); //meaning this line would be skipped (i.e. a value of 8 or greater will never be printed)
// } while (current != 7);

/*
***Challange activity - Role playing game battle challenge
Here are the rules for the battle game that you need to implement in your code project:

You must use either the do-while statement or the while statement as an outer game loop.
The hero and the monster will start with 10 health points.
All attacks will be a value between 1 and 10.
The hero will attack first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.
*/

/*
***My solution***
//instantiate a new object (random) of the Random class
Random random = new Random(); 
//Attacks will be randomly generated from 1-10
int heroAttack = random.Next(1,11);
int monsterAttack = random.Next(1,11);

//set the health for both players
int heroHealth = 10;
int monsterHealth = 10;

do //outer game loop
{
    //Hero will attack first
    monsterHealth = monsterHealth - heroAttack; //subtract damage
    Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health."); //print outcome
    heroAttack = random.Next(1,11); //re-roll hero attack

    //check if monster has died
    if(monsterHealth <= 0) //if monster dies
    {
        Console.WriteLine("Hero wins!");
        break; //exit the loop (stop iterating)
    }

    //Monster will attack second
    heroHealth = heroHealth - monsterAttack; //subtract damage
    Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health."); //print outcome
    monsterAttack = random.Next(1,11); //re-roll monster attack
    
    //check if hero has died
    if(heroHealth <= 0) //if hero dies
    {
        Console.WriteLine("Monster wins!");
        break; //exit the loop (stop iterating)
    }

} while (heroHealth > 0); //keep iterating as long as the hero has health (note: we need an end statement after the Boolean expression)
*/

//Official solution
int hero = 10;
int monster = 10;

Random dice = new Random();

do 
{
    int roll = dice.Next(1, 11); //NOTE: we only use one (dice) variable to subtract damage in initialize it inside the loop 
    monster -= roll; // subtract damage
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue; //Note: if the monster dies we use Continue to skip the monster's attack and go straight to the while condition evaluation

    roll = dice.Next(1, 11); //re-roll the dice at the beginning of each attack
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0); //keep looping while both players are still alive

//Once we're out of the do while, it means one of the players died
Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!"); //use this ternary conditional statement to determine the correct winner