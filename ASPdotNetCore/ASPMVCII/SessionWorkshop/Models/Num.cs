namespace SessionWorkshop.Models;

public class Num
{
    public int NumVal { get; set; }

    // class method to manipulate number displayed on screen;
    public int AddOne(int val, string action)
    {
        Random rand = new Random();
        if (action == "multiply")
        {
            return val *= 2;
        }
        else if (action == "add")
        {
            return val += 1;
        }
        else if (action == "subtract")
        {
            return val -= 1;
        }
        else
        {
            return val += rand.Next(100);
        }
    }
}