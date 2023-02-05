// See https://aka.ms/new-console-template for more information
// challenges from Language Fundamentals

string name = "Harold";
bool programmer = true;
int age = 35;
char initials = 'h';
double gpa = 3.15;

Console.WriteLine($"This is my string {name}, This is my boolean {programmer}, This is my Int {age}, This is my char {initials}, This is my double {gpa}");


int height = 41;

if (height >= 42 && height < 78)
{
    Console.WriteLine("You can ride the coaster");
}
else
{
    Console.WriteLine("You cannot ride the coaster shorty");
}

bool complete = false;

if (complete == true)
{
    Console.WriteLine("Order is complete");
}
else
{
    Console.WriteLine("Order is not complete");
}

string FaveDrink = "Matcha";
int DrinkTemp = 31;
if (FaveDrink == "Matcha" && DrinkTemp >= 32)
{
    Console.WriteLine("Thanks for my drink!");
}
else
{
    Console.WriteLine($"I ordered a {FaveDrink} that is {DrinkTemp} temperature fool!");
}

// loops

// for loop
// Declare value | Break condition | increment value

// for loop inclusive of 50
for (int i = 1; i <= 50; i++)
{
    if (i % 10 == 0)
    {
        Console.WriteLine("+10");
        Console.WriteLine(i);

    }
    else
    {
        Console.WriteLine(i);
    }
}

// for loop with only even numbers exclusive of 50

for (int i = 1; i < 50; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

// loop that decrements by threes from 99 to 0 and prints the values divisible by 3

int start = 99;
int end = 0;
while (start >= end)
{
    Console.WriteLine(start);
    start -= 3;
}

// Random class

// creating a new Random class instance
// classes create their own data type
Random rand = new Random();

// built in method Next() : takes in a variety of parameters 
// no parameter will print a random integer and a C# constant

Console.WriteLine(rand.Next());

// one paramter will give a number from 0-9 (10 is exclusive)
Console.WriteLine(rand.Next(10));

// prints a random number between 2 (min parameter) and 7 (8 is the max parameter and is exclusive)
Console.WriteLine(rand.Next(2, 8));

// prints a random number decimal value between 0.0 and 1.0
Console.WriteLine(rand.NextDouble());

// create a loop that runs 15 times and gest a random number between 1 - 10 (inclusive) each time but should only print values equal to 1 or 7. 

Console.WriteLine("This is my dice game");

for (int i = 0; i <= 15; i++)
{
    Console.WriteLine(i);
    int roll = rand.Next(1, 11);
    if (roll == 1 || roll == 7)
    {
        Console.WriteLine($"I rolled a {roll}");
    }
}


