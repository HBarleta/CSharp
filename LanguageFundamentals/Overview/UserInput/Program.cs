Console.WriteLine("Type an integer and hit enter");
string NumberInput = Console.ReadLine();
if (Int32.TryParse(NumberInput, out int j))
{
    Console.WriteLine($"The integer was : {j}");
    Console.WriteLine(10 + j);
}

