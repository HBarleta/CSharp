
// this function does not return anything and only prints to console the string parameter FirstName and int parameter Age.
static void FirstFunction(string FirstName, int Age)
{
    Console.WriteLine($"Hello my name is {FirstName} and I am {Age} years old");
}

FirstFunction("Harold", 35);

// This function is a static function that will return an int data type and takes in a list of strings as a parameter
static int ReturnLength(List<string> StringList)
{
    // returns an int data type (length of StringList)
    return StringList.Count;
}
// initialized a string list to be used in the function
List<string> NameList = new List<string>() { "Jerry", "James", "Karl" };
// initialized an int NameCount to store the return of the function ReturnLength
int NameCount = ReturnLength(NameList);
// print to console the int NameCount
Console.WriteLine(NameCount);