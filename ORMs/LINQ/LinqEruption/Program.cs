

List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// List<Eruption> stratovolcanoEruptions = eruptions.Where(e => e.Type == "Stratovolcano").ToList();
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
// 1.
Eruption? firstInChile = eruptions.FirstOrDefault(eruption => eruption.Location.Equals("Chile"));
Console.WriteLine($"First eruption in chile {firstInChile}");
// 2.Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
Eruption? firstInHawaii = eruptions.FirstOrDefault(eruption => eruption.Location.Equals("Hawaiian Is"));
if (firstInHawaii != null)
{
    Console.WriteLine($"Hawaii's first eruption is {firstInHawaii}");
}
else Console.WriteLine("No hawaiian Eruption found");
// 3.Find the first eruption from the "Greenland" location and print it. If none is found, print "No Greenland Eruption found."
Eruption? firstInGreenland = eruptions.FirstOrDefault(eruption => eruption.Location.Equals("Greenland"));
if (firstInGreenland != null)
{
    Console.WriteLine($"Greenland's first eruption is {firstInGreenland}");
}
else Console.WriteLine("No Greenland Eruption found");
// 4.Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.
Eruption? NewZealandAfter1900 = eruptions.FirstOrDefault(e => e.Year >= 1900 && e.Location.Equals("New Zealand"));
Console.WriteLine(NewZealandAfter1900);
// 5.Find all eruptions where the volcano's elevation is over 2000m and print them.
List<Eruption> Over2000 = eruptions.Where(e => e.ElevationInMeters > 2000).ToList();
Console.WriteLine("List of eruptions over 2000m");
PrintEach(Over2000);
// 6. Find all eruptions where the volcano's name starts with "L" and print them. Also print the number of eruptions found.
List<Eruption> VolcanoeStartsWithL = eruptions.Where(e => e.Volcano.StartsWith("L")).ToList();
Console.WriteLine("List of volcanoe eruptions that start with L");
Console.WriteLine($"Number of eruptions found: {VolcanoeStartsWithL.Count}");
PrintEach(VolcanoeStartsWithL);
// 7.Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
int HighestElevation = eruptions.Max(eruptions => eruptions.ElevationInMeters);
Console.WriteLine($"Highest elevation: {HighestElevation}m");
// 8. Use the highest elevation variable to find and print the name of the Volcano with that elevation.
Eruption? EruptionWithHighestElevation = eruptions.FirstOrDefault(e => e.ElevationInMeters.Equals(HighestElevation));
Console.WriteLine(EruptionWithHighestElevation);
// 9. Print all Volcano names alphabetically. 
List<Eruption> SortedEruptions = eruptions.OrderBy(eruption => eruption.Volcano).ToList();
Console.WriteLine("Sorted list by alphabetical order");
PrintEach(SortedEruptions);
// 10. Print the sum of all the elevations of the volcanoes combined.
int allElevations = eruptions.Sum(e => e.ElevationInMeters);
Console.WriteLine($"Combined elevations : {allElevations}");
// 11. Print whether any volcanoes erupted in the year 2000 (Hint: look up the Any query)
bool Year2000Eruptions = eruptions.Any(e => e.Year == 2000);
Console.WriteLine($"Did any volcanoes erupt in the year 2000? {Year2000Eruptions}");
// 12. Find all stratovolcanoes and print just the first three (Hint: look up Take)
List<Eruption> Top3StratoVolcanoe = eruptions.Where(e => e.Type.Equals("Stratovolcano")).Take(3).ToList();
Console.WriteLine("Top 3 StratoVolcanoes");
PrintEach(Top3StratoVolcanoe);
// 13. Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
List<Eruption> sortedVolcanoesBefore1000 = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano).ToList();
Console.WriteLine("Sorted list of eruptions before year 1000");
PrintEach(sortedVolcanoesBefore1000);
// Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.
List<string> sortedVolcanoesBefore1000V2 = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano).Select(e => e.Volcano).ToList();
Console.WriteLine(string.Join(",", sortedVolcanoesBefore1000V2));

// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(List<Eruption> eruptions, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption eruption in eruptions)
    {
        Console.WriteLine(eruption.ToString());
    }
}
