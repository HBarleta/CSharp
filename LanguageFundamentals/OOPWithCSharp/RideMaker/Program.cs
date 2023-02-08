
Vehicle HondaS2000 = new Vehicle("S2000", "Sebring Silver", 2, true);
Vehicle Bicycle = new Vehicle("Huffy", "black");
Vehicle Trike = new Vehicle("Jalopy", "yellow");
Vehicle Airplane = new Vehicle("Boeing 757", "Black", 753, true);

Bicycle.ShowInfo();
Trike.ShowInfo();
HondaS2000.ShowInfo();
HondaS2000.Travel(100);
HondaS2000.ShowInfo();
List<Vehicle> VehiclesList = new List<Vehicle>() {
    HondaS2000,
    Bicycle,
    Trike,
    Airplane
};


foreach (Vehicle v in VehiclesList)
{
    Console.WriteLine($"***Here is the vehicle info for {v.Name} in VehiclesList***");
    v.ShowInfo();
}

// Bonus

Airplane.ShowInfo();
// MilesTraveled is public therefore allowing the user to change this property after initialization;
// Airplane.MilesTraveled = 350;
// By making MilesTraveled private, it does not allow the user to alter any properties that are defaulted and protected in the class.
// Creating protections allows the developer to maintain control of key properties that may need specific data for later use.
Airplane.ShowInfo();

