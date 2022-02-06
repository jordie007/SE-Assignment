using System;

public class RideDoneState : RideState {
{
private:

	Ride ride;
    string name;

public:

    RideDoneState(Ride r, string n)
    {
        ride = r;
        name = n;
    }

    void cancelRide()
    {
        Console.WriteLine("Ride is already completed. Ride can no longer be cancelled.");
    }
}
