<!-- create a new C# program on CLI -->

inside CLI run this command:

dotnet new console -o "NAME_OF_PROGRAM"

C# is a statically type language meaning ANYTHING we type must identify WHAT IT IS at the moment we make it
Data types must be written explicitly from the beginning. IE Floats, whole integers, arrays must be declared when initializing. This allows the program to run more efficiently since declaring them off the bat will allocate the correct amount of memory.
Javascript: var name = "Andy"
C#: string name = "Andy";
Strings in C# will always be a string once declared.
Examples of data types:

<!-- integers or whole numbers -->

int age = 32;

<!-- doubles are decimals or floats -->

double height = 1.894;

<!-- booleans  -->

bool blueEyed = true;

<!-- NOTICE ALL LINES END WITH SEMICOLON!! this is absolutely required with C# -->

<!-- Primitive Types of variables: -->

Name | System Class Name| Description | Bitsize | Example
int | Int32 | an integer value between -2,147,483,648 and 2,147,483,647 | 32bits | 40,000

long | Int64 | an integer between -9,223,372,036,854,775,808 and 9,223,372,036,854,775,807 | 64-bits | 3,000,000,000

short | Int16 | An integer between -32,768 and 32,767 | 16-bits | 342

float | Single | A floating point between -3.402823e38 and 3.402823e38 | 32-bits | 3.14159f

double | Double | A floating point number between -1.79769313486232e308 and 1.79769313486232e308. allows more precision than a float | 64-bits | 3.1415926535897932

char | Char | One unicode character | 16-bits | 'g'

bool | Boolean | A true or false value | 8-bits | true

<!-- STRING INTERPOLATION -->

<!-- Variable to interpolate -->

string place = "Coding Dojo";

<!-- Interpolated string, note the $ -->

Console.WriteLine($"Hello {place}");

<!-- Another option uses place holders  -->
<!-- Note this does not have a $ at the start -->

Console.WriteLine("Hello {0}", place);

<!-- Challenges -->

string name = "Harold";

<!-- strings are in double quotes -->

int age = 35;

bool programmer = true;

char initial = 'H';

<!-- char must be in single quotes -->

<!-- // Random class -->

<!-- // creating a new Random class instance -->
<!-- // classes create their own data type -->

Random rand = new Random();

<!-- // built in method Next() : takes in a variety of parameters -->
<!-- // no parameter will print a random integer and a C# constant -->

Console.WriteLine(rand.Next());

<!-- // one paramter will give a number from 0-9 (10 is exclusive) -->

Console.WriteLine(rand.Next(10));

<!-- // prints a random number between 2 (min parameter) and 7 (8 is the max parameter and is exclusive) -->

Console.WriteLine(rand.Next(2, 8));

<!-- // prints a random number decimal value between 0.0 and 1.0 -->

Console.WriteLine(rand.NextDouble());

<!-- // create a loop that runs 15 times and gest a random number between 1 - 10 (inclusive) each time but should only print values equal to 1 or 7. -->

<!-- LOOPS -->

All loops have a starting point

example

<!-- starting point -->

int i = 1;

<!-- Break condition -->

i <= 10;

<!-- do something -->

print i;

<!-- increment value  -->

i++;

<!-- Random is a built in data type -->

Random class methods:

<!-- Arrays -->

Creating an array

<!-- Declares an array with int data types -->
<!-- new int[5] declares the size of the array. cannot modify an array size after its been initialized. Array sizes are IMMUTABLE. we use arrays when we know EXACTLY the size of the array -->

int[] NumsArr = new int[5];

<!-- once initialized by declaring the size, all values are 0 technically. we can fill these in later on with values -->

<!-- declaring a new array with filled in values like this -->

int [] MyArray2 = new int[] {1,2,3,4,5};

<!-- array values are still called by its index -->

Console.WriteLine(myArray[0])

<!-- reassigning values to an array  -->
<!-- NumsArr at index of 2 is now 9 -->

NumsArr[2] = 9

<!-- Checking array length is the same as JS but with capitalized Length keyword -->

Console.WriteLine(MyArray2.Length);

<!-- built in for loop to iterate through an array -->

foreach(int num in MyArray2){
Console.WriteLine(num);

<!-- will print all values in MyArray2 -->

}

<!-- similarily we can use a for loop to iterate through an array -->

for(int i = 0; i < MyArray2.Length; i++){
Console.WriteLine(MyArray2[i]);
}

<!-- To print out all elements in the array without iterating through the array and printing each element on an individual line use this -->

Console.WriteLine(string.Join(",", THE_ARRAY_YOU_WANT_TO_DISPLAY));

<!-- LISTS vs ARRAYS -->
<!-- lists are a collection type.  -->
<!-- declaring a list of strings -->
<!-- declaring a size its not needed but we can also add values during initilization like arrays -->

List<string> MyList = new List<string>() {"val1", "val2", "val3"};

<!-- adding to a List -->

MyList.Add("new value");

<!-- removing from remove -->
<!-- this will remove a value that equals what is passed in -->

MyList.Remove("Value to remove");

<!-- This will remove a value at index 2 -->

MyList.RemoveAt(2);

<!-- getting the size of a list using Count-->

Console.WriteLine(MyList.Count);

<!-- List Iterations are the same as array -->

foreach(string value in MyList){
Console.WriteLine(value);
}

<!-- adding will always put the new value at the end of the list -->
