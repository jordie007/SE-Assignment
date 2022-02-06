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
        Console.WriteLine("Ride already cancelled.");
    }
}
