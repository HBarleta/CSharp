// See https://aka.ms/new-console-template for more information


int[] NumsArr = new int[5] { 1, 2, 3, 4, 5 };

Console.WriteLine(NumsArr[1]);

foreach (int num in NumsArr)
{
    Console.WriteLine(num);
}

string[] StringArr = new string[] { "Nissan", "Toyota", "Honda", "Mitsubishi" };

Console.WriteLine(StringArr[1]);

foreach (string maker in StringArr)
{
    if (maker == "Honda")
    {

        Console.WriteLine($"I own a {maker}");
    }
}

for (int idx = 0; idx < StringArr.Length; idx++)
{
    Console.WriteLine($"{StringArr[idx]} are japanese");
}

//  Challenges

// create an array of integers that holds 8 values

int[] NumbersArray = new int[8];

NumbersArray[2] = 17;
// NumbersArray[4] = "Hello";
// Compile error due to "cannot implicitly covert string to int"
Console.WriteLine(NumbersArray[2]);

foreach (int num in NumbersArray)
{
    Console.WriteLine(num);
}

for (int idx = 0; idx < NumbersArray.Length; idx++)
{
    Console.WriteLine($"This is a for loop printing out values {NumbersArray[idx]}");
}

Console.WriteLine(string.Join(",", NumbersArray));

// lists practice
// Declaring a new list
List<string> bikes = new List<string>();

bikes.Add("Honda");
bikes.Add("Aprilla");
bikes.Add("Jacob");

Console.WriteLine(bikes[0]);
// bikes.Remove("Honda");
Console.WriteLine(bikes[1]);

foreach (string bike in bikes)
{
    Console.WriteLine(bike);
}

Console.WriteLine(string.Join(",", bikes));

// challenges

// create a list of grocery items and iterate through them

List<string> GroceryList = new List<string>() { "Celery", "Carrots", "Milk", "Cheese", "Beer" };

foreach (string item in GroceryList)
{

    // Console.Write($"One item on the list is: {item} ");
    Console.WriteLine(item);
}

Console.WriteLine(GroceryList);

Random randNum = new Random();
int length = GroceryList.Count;

Console.WriteLine($"A random item: {GroceryList[randNum.Next(0, length)]}");