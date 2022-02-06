using System;

public class RideRequestedState : RideState {
{
private:

public:

	void setState(RideState s)
    {
		state = s
    }

    override void cancelRide(Ride ride)
    {
        Console.WriteLine("Ride is already underway. Ride can no longer be cancelled.");
    }
}
