// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult; //defines a nullable type string variable. (why is this better? Incase there is no user input provided?)
string menuSelection = "";

// 2D multi-dimensional array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6]; //creates a 2D array, (maxPets = rows, 6 = columns)

// create some initial ourAnimals array entries (case 0-3 will be pre-existing pets in out array)
for (int i = 0; i < maxPets; i++) //loop over the elements(rows) of the ourAnimals 2d array
{
    // TODO: Convert the if-elseif-else construct to a switch statement
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    //The values of the animal characteristic variables are assigned to the ourAnimals array at the bottom of the for loop.
    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

//This do-while loop is to iterate over our menu selections
do //ensures that the main menu is refreshed for the user each time they make a menu selection
{
    //"refresh" clear the console
    Console.Clear();
    // display the top-level menu options
    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");

    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine(); //capture user input and place in readResult var
    if (readResult != null) //make sure it's not null (Many of the methods that accept strings as an input parameter will generate an error if they're passed a null value.)
    {
        menuSelection = readResult.ToLower(); //transform user input to lower case and store in menuSelection var
    }

    // //echo what the user selected
    // Console.WriteLine($"You selected menu option {menuSelection}.");
    // Console.WriteLine("Press the Enter key to continue"); //

    // // pause code execution
    // readResult = Console.ReadLine(); //why are we asking for user input again here?
    // //isn't there a better way to pause the terminal?

    //Write switch statement for menu selections
    switch (menuSelection)
    {
        // List all of our current pet information
        case "1":
            /*
            Note: don't use a foreach loop to iterate multi-dimensional arrays. 
            //A foreach array would recognize each string as a separate element in a list of 48 string items (8x6) 
            It wouldn't process the two dimensions separately.
            */
            for (int i = 0; i < maxPets; i++) //outerloop (maxPets acts as our pet limit for ourAnimals[][])
            {
                //checks for pet ID data
                if (ourAnimals[i, 0] != "ID #: ") //make sure it's not the default value (there's actual pet characteristics defined)
                {
                    Console.WriteLine();//prints a new line in between each pet
                    //inner for loop that will iterate through the characteristics of each pet
                    for (int j = 0; j < 6; j++) //we have 6 total characteristics (iterates through the columns)
                    {
                        Console.WriteLine(ourAnimals[i, j]);//display each characteristic of a pet on a separate line
                    }
                }
            }

            //use this a pause for the user before he continues to the menu
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        // Add a new animal friend to the ourAnimals array
        case "2":
            //These two variables control the iteration of a while loop that's used to enter new pet data
            //Note: always scope your variables as narrowly as possible
            string anotherPet = "y";
            int petCount = 0;

            //This loop is used to count the current number of pets inside ourAnimals[][]
            for (int i = 0; i < maxPets; i++) //outerloop (maxPets acts as our pet limit for ourAnimals[][])
            {
                if (ourAnimals[i, 0] != "ID #: ")//check the current pet has a valid ID
                {
                    //count the "real" pets currently stored in out array
                    petCount += 1; //if we get to this statement that means this is a (real pet)
                }
            }

            //determine if we can add new pets to our array
            if (petCount < maxPets)
            {
                //let the user know how many more pets we can manage
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            }

            //bool var to validate animal species
            bool validEntry = false;

            // get species (cat or dog) - string animalSpecies is a required field 
            do
            {
                //ask user to enter species
                Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                readResult = Console.ReadLine();

                //ensure the input isn't null
                if (readResult != null)
                {
                    animalSpecies = readResult.ToLower(); //make the input consistent

                    //ensure the species is a valid type
                    if (animalSpecies != "dog" && animalSpecies != "cat")
                    {
                        validEntry = false;
                    }
                    else
                    {
                        validEntry = true;
                    }
                }
            } while (validEntry == false); //loop until we get a valid user response

            // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
            animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

            //Build loop to read and validate the pet's age
            do // get the pet's age. can be ? at initial entry.
            {
                int petAge;
                Console.WriteLine("Enter the pet's age or enter ? if unknown");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalAge = readResult;
                    if (animalAge != "?")
                    {
                        validEntry = int.TryParse(animalAge, out petAge); //parse age to an int
                    }
                    else //what if it is another char besides ?...
                    {
                        validEntry = true;
                    }
                }
            } while (validEntry == false);

            // loop to get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
            do
            {
                Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalPhysicalDescription = readResult.ToLower();
                    if (animalPhysicalDescription == "")
                    {
                        animalPhysicalDescription = "tbd";
                    }
                }
            } while (animalPhysicalDescription == ""); //loop until the description string isn't empty

            // loop to get a description of the pet's personality - animalPersonalityDescription can be blank.
            do
            {
                Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalPersonalityDescription = readResult.ToLower();
                    if (animalPersonalityDescription == "")
                    {
                        animalPersonalityDescription = "tbd";
                    }
                }
            } while (animalPersonalityDescription == ""); //loop until the description string isn't empty

            // loop to get the pet's nickname. animalNickname can be blank.
            do
            {
                Console.WriteLine("Enter a nickname for the pet");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalNickname = readResult.ToLower();
                    if (animalNickname == "")
                    {
                        animalNickname = "tbd";
                    }
                }
            } while (animalNickname == ""); //loop until the description string isn't empty

            // store the new pet's information in the ourAnimals array (zero based)
            ourAnimals[petCount, 0] = "ID #: " + animalID;
            ourAnimals[petCount, 1] = "Species: " + animalSpecies;
            ourAnimals[petCount, 2] = "Age: " + animalAge;
            ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
            ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
            ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

            //This while loop is used to enter new pets in ourAnimals[][]....
            while (anotherPet == "y" && petCount < maxPets) //validates whether another pet is being entered and we have space in our array
            {
                // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                petCount = petCount + 1;

                // check if maxPet limit has been reached
                if (petCount < maxPets) //shouldn't this be <=?
                {
                    // ask the user if they want to add another pet?
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");

                    //This do-while is used to get a valid response from the user (y or n)
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "y" && anotherPet != "n"); //loop until we get a valid response
                }
            }

            //if we've reached our pet limit, let the user know
            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }

            break;

        // Ensure animal ages and physical descriptions are complete
        case "3":
            //Skip over any animal in the ourAnimals array when the value of pet ID is set to the default value.
            //This loop is used to count the current number of pets inside ourAnimals[][]
            validEntry = false; //this variable is shared accross all switch cases

            for (int i = 0; i < maxPets; i++) //outerloop (maxPets acts as our pet limit for ourAnimals[][])
            {
                if (ourAnimals[i, 0] != "ID #: ")//check the current pet has a valid ID (is not default)
                {
                    //if the age is blank or unknown
                    if (ourAnimals[i, 2] == "" || ourAnimals[i, 2] == "?")
                    {
                        //this do while loop prompts the user for a valid age
                        do
                        {
                            int petAge; //is this variable's scope local to this code block? isolated?
                            Console.WriteLine($"Enter an age for ID #: {ourAnimals[i, 0]}");
                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                animalAge = readResult;
                                validEntry = int.TryParse(animalAge, out petAge); //parse age to an int
                                //validEntry will remain false if the parse was unsuccessful
                            }
                        } while (validEntry == false);

                        //assign the valid age to our current pet
                        ourAnimals[i, 2] = "Age: " + animalAge;
                        
                    }
                }

            }

            break;

        // Ensure animal nicknames and personality descriptions are complete
        case "4":

            Console.WriteLine("U this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        // Edit an animal’s age
        case "5":

            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        // Edit an animal’s personality description
        case "6":

            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        // Display all cats with a specified characteristic
        case "7":

            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        // Display all dogs with a specified characteristic
        case "8":

            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        //what about an exit section?

        //default action section (no proper selection was made)
        default:

            Console.WriteLine("this is the default section");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
    }

} while (menuSelection != "exit"); // iterates until the user chooses to "exit" the application

