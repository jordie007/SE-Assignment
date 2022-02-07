#pragma once
using System;
using namespace std;

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

    public Ride Ride { get; set; }

    public string Name { get; set; }
}
