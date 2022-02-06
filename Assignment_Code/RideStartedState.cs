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

	void cancelRide(Ride ride)
    {
        Console.WriteLine("Ride is already underway. Ride can no longer be cancelled.");
    }

	public Ride Ride { get; set; }

	public string Name { get; set; }
}