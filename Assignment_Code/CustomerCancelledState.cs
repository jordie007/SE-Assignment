using System;

public class CustomerCancelledState : RideState {
{
private:

    Ride ride;
    string name;

public:

	CustomerCancelledState(Ride r, string n)
    {
        ride = r;
        name = n;
    }

    void cancelRide(Ride ride)
    {
        Console.WriteLine("Ride already cancelled.");
    }

    public Ride Ride { get; set; }

    public string Name { get; set; }

}
