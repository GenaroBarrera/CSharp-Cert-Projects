//Discover Value types
//An integral type is a simple value type that represents whole numbers with no fraction (such as -1, 0, 1, 2, 3).

//Signed integral types 
//A signed type uses its bytes to represent an equal number of positive and negative numbers
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

//Unsigned integral types
//An unsigned type uses its bytes to represent only positive numbers
Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

//A floating point is a simple value type that represents numbers to the right of the decimal place.
Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
/* 
Note: when to use float, double, or decimal

Performing math on binary floating-point values can produce results that may surprise you if you're used to decimal (base 10) math. 
Often, binary floating-point math is an approximation of the real value. 
Therefore, float and double are useful because large numbers can be stored using a small memory footprint. 
However, float and double should only be used when an approximation is useful. 
For example, being a few thousandths off when calculating the splatter of a snowball in a video game is close enough.

When you need a more precise answer, you should use decimal. 
Each value of type decimal has a relatively large memory footprint, however performing math operations gives you a more precise result. 
So, you should use decimal when working with financial data or any scenario where you need an accurate result from a calculation.
*/

//Discover reference types
//Reference types include arrays, classes, and strings. Reference types are treated differently from value types regarding the way values are stored when the application is executing.

/* A value type variable stores its values directly in an area of storage called the stack. 
The stack is memory allocated to the code that is currently running on the CPU (also known as the stack frame, or activation frame). 
When the stack frame has finished executing, the values in the stack are removed.

A reference type variable stores its values in a separate memory region called the heap. 
The heap is a memory area that is shared across many applications running on the operating system at the same time. 
The .NET Runtime communicates with the operating system to determine what memory addresses are available, and requests an address where it can store the value.
 */

int[] data; //defines a variable "data" that can hold a value of type int array.
data = new int[3]; //The new keyword informs .NET Runtime to create an instance of int array

//Modify the code example to perform both operations in a single line of code
int[] data2 = new int[3];

//The string data type is also a reference type.
string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);

//Value Type (int): In this example, val_A and val_B are integer value types.
int val_A = 2;
int val_B = val_A;
val_B = 5;

Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}"); //outputs 2
Console.WriteLine($"val_B: {val_B}"); //outputs 5
// When val_B = val_A is executed, the value of val_A is copied and stored in val_B. 
// So, when val_B is changed, val_A remains unaffected.

//Reference Type (array): In this example, ref_A and ref_B are array reference types.
int[] ref_A= new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}"); //outputs 5
Console.WriteLine($"ref_B[0]: {ref_B[0]}"); //outputs 5
// When ref_B = ref_A is executed, ref_B points to the same memory location as ref_A. 
// So, when ref_B[0] is changed, ref_A[0] also changes because they both point to the same memory location. 
// This is a key difference between value types and reference types.

/* Choose the data type that meets the boundary value range requirements of your
application

Your choice of a data type can help to set the boundaries for the size of the
data you might store in that particular variable. For example, if you know a
particular variable should only store a number between 1 and 10,000 —
otherwise it's outside of the boundaries of what would be expected — you
would likely avoid byte and sbyte since their ranges are too low.

Furthermore, you would likely not need int, long, uint, or ulong because they
can store more data than is necessary. Likewise, you would probably skip
float, double, and decimal if you do not need fractional values. You might
narrow it down to short and ushort, both of which may be viable. If you are
confident that a negative value would have no meaning in your application,
you might choose ushort (positive unsigned integer, 0 to 65,535). Any value
assigned to a variable of type ushort outside of the boundary of 0 to 65535
would throw an exception, thereby helping you enforce a degree of sanity
checking in your application.

Start with choosing the data type to fit the data (not to optimize
performance)

You may be tempted to choose the data type that uses the fewest bits to store
data thinking it improves your application's performance. However, some of the
best advice related to application performance (that is, how fast your
application runs) is to not "prematurely optimize". Resist the temptation to
guess which parts of your code, including the selection of data types, may
impact performance.

Many assume that because a given data type stores less information it must use
less of the computer's processor and memory than a data type that stores more.
Instead, choose the right fit for your data; later you can empirically measure
the performance of your application using profiling tools that provide factual
insights into the parts of your application that negatively impact
performance. */



