
// Create a loop that prints all values from 1 - 255
for (int i = 1; i < 256; i++)
{
    Console.WriteLine(i);
}

// create a new loop that generates 5 random numbers from 10 and 20;

Console.WriteLine("Random number generator");
Random rand = new Random();

for (int j = 1; j <= 5; j++)
{

    int OneRand = rand.Next(10, 21);
    Console.WriteLine(OneRand);

}


// modified previous loop to display sum of all random numbers

int sum = 0;
int start = 1;

while (start <= 5)
{
    int NewRandom = rand.Next(10, 21);
    Console.WriteLine("Modified random number generator");
    Console.WriteLine(NewRandom);
    sum += NewRandom;
    start++;
}

Console.WriteLine($"Total sum of all random numbers = {sum}");

for (int i = 1; i < 101; i++)
{
    if (i % 5 == 0 && i % 3 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    else
    {
        Console.WriteLine(i);
    }

}

int start1 = 1;


while (start1 < 101)
{
    if (start1 % 5 == 0 && start1 % 3 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (start1 % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (start1 % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else
    {
        Console.WriteLine(start1);
    }
    start1++;
}