static void PrintList(List<string> MyList)
{
    // foreach (string name in MyList)
    // {
    //     Console.WriteLine(name);
    // }

    // for (int i = 0; i < MyList.Count; i++)
    // {
    //     Console.WriteLine(MyList[i]);
    // }
    // 3 different methods of printing MyList to console
    Console.WriteLine(string.Join(",", MyList));
}

List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };
PrintList(TestStringList);

// Given a List of integers, calculate and print the sum of the values.

static void SumOfNumbers(List<int> IntList)
{
    // initializing a sum variable to hold running count of sum of all elements
    int sum = 0;
    foreach (int num in IntList)
    {
        // adding each element to sum variable
        sum += num;
    }
    // printing to console the total sum of all elements in IntList 
    Console.WriteLine(sum);
}

List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };
SumOfNumbers(TestIntList);

// Given a List of integers, find and return the largest value in the List.

static int FindMax(List<int> IntList)
{
    // Setting the Greatest varible to first element in list
    int Greatest = IntList[0];
    foreach (int num in IntList)
    {
        // checking to see if current number in list is greater than first element
        if (num > Greatest)
        {
            // if it is greater than current Greatest, assign that number to the new value of Greatest variable
            Greatest = num;
        }
    }
    // Print to console to check if method is running correctly
    Console.WriteLine(Greatest);
    // return the Greatest value from the IntList
    return Greatest;
}

List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };
FindMax(TestIntList2);

// Given a List of integers, return the List with all the values squared.

static List<int> SquareValues(List<int> IntList)
// using a for loop to iterate through the list
{
    for (int i = 0; i < IntList.Count; i++)
    {
        // reassigning the current element to the square of that element;
        IntList[i] *= IntList[i];
        // printing to console to check if logic is working
        Console.WriteLine(IntList[i]);
    }
    // returning the newly mutated list after function is complete
    return IntList;

}
List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };

SquareValues(TestIntList3);
// checking the values to make sure list was mutated according to function logic
Console.WriteLine(string.Join(",", TestIntList3));

// Given an array of integers, return the array with all values below 0 replaced with 0.
static int[] NonNegatives(int[] IntArray)
{
    // for loop to iterate through array and check every element
    for (int i = 0; i < IntArray.Length; i++)
    {
        // logic to check if current element in IntArray is negative
        if (IntArray[i] < 0)
        {
            // checking logic is properly identifying the negative number
            Console.WriteLine($"{IntArray[i]} is a negative number");
            // reassigning the negative number to 0
            IntArray[i] = 0;
        }
    }
    // return newly mutated array argument
    return IntArray;
}
// creating a new int array
int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };

NonNegatives(TestIntArray);
// checking to see if TestIntArray was mutated according to logic
Console.WriteLine(string.Join(",", TestIntArray));

// Given a dictionary, print the contents of the said dictionary.

static void PrintDictionary(Dictionary<string, string> MyDictionary)
{
    // dictionary iteration to access key and value pairs
    foreach (KeyValuePair<string, string> entry in MyDictionary)
    {
        // printing to console each Key and Value pair
        Console.WriteLine($"Key: {entry.Key} -- Value: {entry.Value}");
    }

}

Dictionary<string, string> TestDict = new Dictionary<string, string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);

// Given a search term, return true or false whether the given term is a key in a dictionary.

static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
{
    // iterating through dictionary to check if SearchTerm matches current key
    foreach (KeyValuePair<string, string> entry in MyDictionary)
    {
        // logic to check if SearchTerm matches current key in MyDictionary
        if (entry.Key == SearchTerm)
        {
            Console.WriteLine(entry.Key);
            // function will return true if a key matches SearchTerm
            return true;

        }

    }
    // otherwise function will return false if no keys match SearchTerm
    return false;

}
// this should return true
Console.WriteLine(FindKey(TestDict, "RealName"));
// this should return false
Console.WriteLine(FindKey(TestDict, "Name"));

// Given a List of names and a List of integers, create a dictionary where the key is a name from the List of names and the value is a number from the List of numbers. Assume that the two Lists will be of the same length. Don't forget to print your results to make sure it worked.

static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string, int> GeneratedDict = new Dictionary<string, int>();
    // iterating through Numbers list assuming Names list is also the same length
    for (int i = 0; i < Numbers.Count; i++)
    {
        GeneratedDict.Add(Names[i], Numbers[i]);
    }
    // one method of checking keys/values in return dict
    Console.WriteLine(string.Join(",", GeneratedDict));
    // another method of checking keys/values in return dict
    // iterating through return dict using KVP
    foreach (KeyValuePair<string, int> entry in GeneratedDict)
    {
        // printing to console the key and value in return dict to check if logic in GenerateDictionary method is correct
        Console.WriteLine($"Key : {entry.Key} - Value: {entry.Value}");
    }
    return GeneratedDict;
}

List<string> NamesList = new List<string>() { "Harold", "Jerry", "Max", "Job" };
List<int> NumbersList = new List<int>() { 1, 35, 25, 69 };

GenerateDictionary(NamesList, NumbersList);

