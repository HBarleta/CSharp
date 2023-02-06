// Three basic arrays
// Create an integer array with the values 0 through 9 inside.
int[] NumsArr = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// check if the array is correct
foreach (int num in NumsArr)
{
    Console.WriteLine(num);
}

// Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
string[] StringArr = new string[] { "Tim", "Martin", "Nikki", "Sara" };
// checking if array is correct with string.Join function
Console.WriteLine(string.Join(",", StringArr));

// Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true. (Tip: do this using logic! Do not hard-code the values in!
bool[] BoolArr = new bool[10];

for (int i = 0; i < BoolArr.Length; i++)
{
    if (i % 2 != 0)
    {
        BoolArr[i] = true;
    }
    else
    {
        BoolArr[i] = false;
    }
}
// check if all values are correct 
foreach (bool answer in BoolArr)
{
    Console.WriteLine(answer);
}

// List of Flavors
// Create a string List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5!)
List<string> FlavorsList = new List<string>() { "Chocolate", "Vanilla", "Strawberry", "RockyRoad", "Cherry", "BaseballNut", "Mocha" };
// check if list is correct
Console.WriteLine(string.Join(",", FlavorsList));
// Output the length of the List after you added the flavors.
Console.WriteLine(FlavorsList.Count);
// Output the third flavor in the List.
Console.WriteLine($"{FlavorsList[2]} is third on this list");
// Now remove the third flavor using its index location.
FlavorsList.Remove(FlavorsList[2]);
// Output the length of the List again. It should now be one fewer.
Console.WriteLine(FlavorsList.Count);
// checking all values 
Console.WriteLine(string.Join(",", FlavorsList));

// User Dictionary
// Create a dictionary that will store string keys and string values.
Dictionary<string, string> MyDict = new Dictionary<string, string>();
// Add key/value pairs to the dictionary where:
Random randNum = new Random();
foreach (string name in StringArr)
{
    // initialize a random index 
    // Each value is a randomly selected flavor from your flavors List (remember Random from earlier?)
    int idx = randNum.Next(0, 7);
    // Each key is a name from your names array (this can be done by hand or using logic)
    MyDict.Add(name, FlavorsList[idx]);
}
// Loop through the dictionary and print out each user's name and their associated ice cream flavor.

foreach (KeyValuePair<string, string> entry in MyDict)
{
    Console.WriteLine($"Name: {entry.Key} -- Favorite Ice Cream Flavor: {entry.Value}");
}
