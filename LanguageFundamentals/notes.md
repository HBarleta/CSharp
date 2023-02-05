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
