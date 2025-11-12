// Exercise - Use the string's IndexOf() and Substring() helper methods
// Write code to find parenthesis pairs embedded in a string

/* string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('('); // Find the position of the opening parenthesis
int closingPosition = message.IndexOf(')'); // Find the position of the closing parenthesis

// Console.WriteLine(openingPosition); //outputs 13
// Console.WriteLine(closingPosition); //outputs 36

//Add code to retrieve the value between parenthesis
int length = closingPosition - openingPosition; // Calculate the length of the substring inside the parentheses
Console.WriteLine(message.Substring(openingPosition, length)); // Extract and display the substring including the opening parentheses
 */

// The result is close, however the output includes the opening parenthesis. In this exercise, the inclusion of the
// parenthesis isn't desired. To remove the parenthesis from output, you have to update the code to skip the index of
// the parenthesis itself.

//Modify the starting position of the sub string

/* string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

//openingPosition += 1; // Move the starting position one index forward to skip the opening parenthesis

int length = closingPosition - (openingPosition+=1); //another way to update the starting position
Console.WriteLine(message.Substring(openingPosition, length)); */

// Avoid magic values
//Hardcoded strings like "<span>" in the previous code listing are known as "magic strings" and
// hardcoded numeric values like 6 are known as "magic numbers". 

/* string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>"; //assign "magic strings" such as <span> to named constants
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan); // Find the position of the opening tag
int closingPosition = message.IndexOf(closeSpan); // Find the position of the closing tag

openingPosition += openSpan.Length; // Move the starting position forward to skip the opening tag, using the Length property of the constant
int length = closingPosition - openingPosition; // Calculate the length of the substring between the tags
Console.WriteLine(message.Substring(openingPosition, length)); // Extract and display the substring between the tags */

//Exercise - Use the string's IndexOf() and LastIndexOf() helper methods

//LastIndexOf() returns the last position of a character or string inside of another string.
//IndexOfAny() returns the first position of an array of char that occurs inside of another string.

// Exercise - Use the Remove() and Replace() methods

// The Remove() method works like the Substring() method, except that it deletes the specified characters in the string.
// The Replace() method swaps all instances of a string with a new string.

// Exercise - Complete a challenge to extract, replace, and remove data from an input string

//Expected output:
//Quantity: 5000
//Output: <h2>Widgets &reg;</h2><span>5000</span>

/* 
1 Begin adding your solution code to the starter code under the comment // Your work here.
2 Set the quantity variable to the value obtained by extracting the text between the <span> and </span> tags.
3 Set the output variable to the value of input, then remove the <div> and </div> tags.
4 Replace the HTML character ™ (&trade;) with ® (&reg;) in the output variable.
5 Run your solution and verify the output matches the expected output. 
*/

/* In HTML, you define the structure of a document using tags. A tag is composed of:

    an opening angle bracket <
    a closing angle bracket >
    a word describing the type of tag, so for example: <div>, <span>, <h2> etc.

Each tag has a corresponding closing tag that introduces a forward slash character /. So, if you see <div> there should be a corresponding </div> tag.

The content between the opening and closing tag is the content of that tag. The content can include text and other tags.

A set of tags can be embedded inside another set of tags, giving an HTML document its hierarchical structure. */

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
// Extract the "quantity"
const string openSpan = "<span>"; //define constant for opening span tag
const string closeSpan = "</span>"; //define constant for closing span tag

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; //get the index of <span> and add its length to get the start of the quantity value
int quantityEnd= input.IndexOf(closeSpan); //index of </span> tag, not adding length since we want the start of </span>
int quantityLength = quantityEnd - quantityStart; //calculate the character length of the quantity value
quantity = input.Substring(quantityStart, quantityLength); //extract the quantity value using Substring()
quantity = $"Quantity: {quantity}"; //format the quantity string

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;"; //define constant for trademark symbol
const string regSymbol = "&reg;"; //define constant for registered trademark symbol
output = input.Replace(tradeSymbol, regSymbol); //replace trademark symbol with registered trademark symbol

// Remove the opening <div> tag
const string openDiv = "<div>"; //define constant for opening div tag
int divStart = output.IndexOf(openDiv); //get the index of <div> tag
output = output.Remove(divStart, openDiv.Length); //remove the <div> tag using Remove()

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>"; //define constant for closing div tag
int divCloseStart = output.IndexOf(closeDiv); //get the index of </div> tag
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length); //remove the </div> tag using Remove() and add "Output:" to the beginning of the string

Console.WriteLine(quantity); //print the quantity
Console.WriteLine(output); //print the output

