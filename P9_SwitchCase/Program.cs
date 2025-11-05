/*
//switch-case example

int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel) //switch expression encased in ()
{
    
    // case 100: //note: all the cases must match the type of the switch expression
    //     title = "Junior Associate";
    //     break; //The break keyword is one of several ways to end a switch section
    //     //above is a single switch section, using the case switch label. 

    //     //If you forget the break keyword (or, optionally, the return keyword) the compiler will generate an error.
    

    //using multiple switch labels
    case 100:
    case 200: 
        title = "Senior Associate";
        break;

    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default: //default switch label is used incase no other case is matched
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");
*/

//challenge activity: convert if-elseif-else construct to switch case construct

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-'); //we're splitting the sku string by - and placing it into a string[] product

string type = "";
string color = "";
string size = "";

switch (product[0]) //this element holds the product number (type)
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "other";
        break;
}

switch (product[1]) //this element holds the color code (color)
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2]) //this element holds the size code (size)
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One size fits all";
        break;
}

//display the item corresponding to the SKU
Console.WriteLine($"Product: {size} {color} {type}");



