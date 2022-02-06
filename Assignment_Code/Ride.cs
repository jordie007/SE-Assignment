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
	Receipt receipt;

	DriverAccount driver;
	CustomerAccount customer;

	RideState rideRequestedState;
	RideState driverAssignedState;
	RideState customerCancelledState;
	RideState customerWaitingState;
	RideState driverArrivedState;
	RideState rideStartedState;
	RideState rideDoneState;

	RideState state;

	public:
	Ride(departing, dropOffPoint, start)
	{
		pickUpPoint = departing;
		destination = dropOffPoint;
		startTime = start;
		// auto increment ref no

		rideRequestedState = new RideRequestedState(this);
		driverAssignedState = new DriverAssignedState(this);
		customerCancelledState = new CustomerCancelledState(this);
		customerWaitingState = new CustomerWaitingState(this);
		driverArrivedState = new DriverArrivedState(this);
		rideStartedState = new RideStartedState(this);
		rideDoneState = new RideDoneState(this);

		setState(rideRequestedState)

	}

	void setState(RideState s)
	{
		state = s

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

	public RideState RideRequestedState { get; set; }
	public RideState DriverAssignedState { get; set; }
	public RideState CustomerCancelledState { get; set; }
	public RideState CustomerWaitingState { get; set; }
	public RideState DriverArrivedState { get; set; }
	public RideState RideStartedState { get; set; }
	public RideState RideDoneState { get; set; }

}