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

// Dictionaries

Dictionary<string, string> MyDictionary = new Dictionary<string, string>();

MyDictionary.Add("Name", "Harold Barleta");
MyDictionary.Add("Location", "Los Angeles");

// printing a value from a dictionary
Console.WriteLine(MyDictionary["Name"]);
Console.WriteLine(MyDictionary["Location"]);

// Iterating through a dictionary
// cannot use a for loop since dictionaries do not have indicies

foreach (KeyValuePair<string, string> entry in MyDictionary)
{
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}

// Challenge

Dictionary<string, List<int>> MyDictionary2 = new Dictionary<string, List<int>>();

MyDictionary2.Add("Job", new List<int> { 1 });
MyDictionary2.Add("Level", new List<int> { 5 });
MyDictionary2.Add("Name", new List<int> { 2 });
MyDictionary2.Add("Bob", new List<int> { 3 });
MyDictionary2.Add("Jasmin", new List<int> { 12 });
MyDictionary2.Add("Multi", new List<int> { 23, 2, 5, 55 });
Console.WriteLine(MyDictionary2["Jasmin"]);
MyDictionary2.Remove("Jasmin");
Console.WriteLine("Jasmin is removed");
// Console.WriteLine(MyDictionary2["Jasmin"]);




foreach (KeyValuePair<string, List<int>> entry in MyDictionary2)
{
    // outer for each to iterate through dictionary
    string key = entry.Key;
    // setting the keys into a string variable
    List<int> list = entry.Value;
    // setting the values into a list variable
    Console.WriteLine("Key = {0}, contains {1} values", key, list.Count);
    foreach (int num in list)
    {
        // inner for each to iterate through all values inside list value
        Console.WriteLine(" - Value = {0}", num);
    }
}
// clear all entries in dictionary
MyDictionary2.Clear();



