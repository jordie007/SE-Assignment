using System;

public class RideStartedState : RideState {
{
private:

	Ride ride;
	string name;

public:

	RideStartedState(Ride r, string n)
	{
		ride = r;
		name = n;
	}

	override void cancelRide(Ride ride)
    {
        Console.WriteLine("Ride is already underway. Ride can no longer be cancelled.");
    }
}