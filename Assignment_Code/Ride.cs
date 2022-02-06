using System;

public class Ride
{
private:
	int refNo;
	decimal fare;
	string pickUpPoint;
	string destination;
	DateTime startTime;
	DateTime endTime;
	RideState rideState;
	Receipt receipt;

	DriverAccount driver;
	CustomerAccount customer;

	public:
	Ride(departing, dropOffPoint, start)
	{
		pickUpPoint = departing;
		destination = dropOffPoint;
		startTime = start;
		// auto increment ref no

		rideState = new RideState(this);
		receipt = new Receipt(this)
	}

	void calculateFare()
	{
		// implementation for fare calculation
	}

	void cancelRide()
    {
		rideState.cancelRide()
	}

	public int RefNo { get; set; }
	public decimal Fare { get; set; }
	public string PickUpPoint { get; set; }
	public string Destination { get; set; }
	public DateTime StartTime { get; set; }
	public DateTime EndTime { get; set; }

	public DriverAccount Driver { get; set; }
	public CustomerAccount Customer { get; set; }

	public RideState State { get; set; }
	public Receipt Receipt { get; set; }

}