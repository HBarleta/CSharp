public class Vehicle
{
    public string Name { get; set; }
    public int Passengers { get; set; }
    public string Color { get; set; }
    public bool HasEngine { get; set; }
    private int MilesTraveled { get; set; }

    public Vehicle(string name, string color)
    {
        Name = name;
        Color = color;
        // user is allowed to input these properties

        Passengers = 4;
        HasEngine = true;
        MilesTraveled = 0;
        // These properties have default values and does not allow user input during initialization
    }

    public Vehicle(string name, string color, int passengers, bool hasEngine)
    {
        Name = name;
        Color = color;
        HasEngine = hasEngine;
        Passengers = passengers;
        MilesTraveled = 0;
    }

    public void ShowInfo()
    {

        Console.WriteLine(
            $"Name : {Name}, Color : {Color}, Passengers : {Passengers}, Engine? : {HasEngine}, Miles traveled : {MilesTraveled} miles"
        );

    }
    public int Travel(int distance)
    {
        this.MilesTraveled += distance;
        return this.MilesTraveled;
    }

}