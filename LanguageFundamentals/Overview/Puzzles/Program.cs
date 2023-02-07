// Coin flip

static string HeadsOrTails()
{
    Random randNum = new Random();
    int flip = randNum.Next(1, 3);
    if (flip == 1)
    {
        Console.WriteLine($"You flipped Heads! flip = {flip}");
        return "Heads";
    }
    else
    {
        Console.WriteLine($"You flipped Tails! flip = {flip}");
        return "Tails";
    }
}

HeadsOrTails();

// dice roller

static int DiceRoller(int sides = 6)
// default is 6 sided die or user inputted possible sides
{
    Random randNum = new Random();
    // randNum will determine a random output
    int diceRoll = randNum.Next(1, sides + 1);
    // diceRoll will generate a random roll depending on the sides inputted +1 to be inclusive of the amount inputted
    Console.WriteLine($"You rolled a dice landing on {diceRoll}");
    // logging into console to verify the roll
    return diceRoll;
    // returning the amount as an int
}

DiceRoller(50);

static List<int> StatsRoller(int roll = 4)
{
    List<int> StatsRolled = new List<int>();
    Random randNum = new Random();
    int largestRoll = 0;
    // statRoll to determine how many times the function will run. roll +1 to include up to the amount passed in
    for (int i = 1; i <= roll; i++)
    {
        int statRoll = randNum.Next(1, roll + 1);
        // this will generate a random statRoll
        Console.WriteLine($"You rolled {statRoll}");
        if (statRoll > largestRoll)
        // checking to see what is the largest roll in this call
        {
            largestRoll = statRoll;
            Console.WriteLine($"New high rolled!");
        }
        // adding to list of rolls
        StatsRolled.Add(statRoll);
    }
    // printing the amount of rolls performed and the highest amount rolled
    Console.WriteLine($"You rolled a total of {StatsRolled.Count} times with the highest roll of {largestRoll}");
    return StatsRolled;
}

StatsRoller(10);

// roll until

static string RollUntil(int goal, int diceSide)
{
    if (goal > diceSide)
    {
        return "Goal must be 6 or less";
    }
    int attempts = 0;
    int roll = 0;
    while (goal != roll)
    {
        attempts++;
        roll = DiceRoller(diceSide);
    }
    return $"It took {attempts} attempts to roll a {goal}";
}



// interactive diceroller
static int askForSides()
{
    Console.WriteLine("How many sides to your dice?");
    string howManySides = Console.ReadLine();
    if (Int32.TryParse(howManySides, out int sides))
    {
        Console.WriteLine($"You have chosen {sides} sides for the dice");
        return sides;
    }
    else
    {
        Console.WriteLine("Enter a valid number for sides");
        return askForSides();
    }
}
int userSides = askForSides();
Console.WriteLine($"sides recorded : {userSides}");

static string askAction()
{

    Console.WriteLine("What would you like to do?");
    Console.WriteLine("Enter the number of desired action");
    Console.WriteLine("1) Roll the dice");
    Console.WriteLine("2) Roll the dice until a goal is reached");
    string response = Console.ReadLine();
    return response;
}

string userResponse = askAction();
if (userResponse == "1")
{
    Console.WriteLine($"You've chosen to roll a {userSides} dice");
    DiceRoller(userSides);
}
else if (userResponse == "2")
{
    Console.WriteLine("you have chosen to roll until a goal!");
    Console.WriteLine($"Enter a number equal to or less than {userSides}");
    string userGoal = Console.ReadLine();
    if (Int32.TryParse(userGoal, out int goal))
    {
        if (goal <= userSides)
        {
            string outcome = RollUntil(goal, userSides);
            Console.WriteLine(outcome);
        }
    }
    else
    {
        Console.WriteLine("Choose a valid number!");
    }
}

