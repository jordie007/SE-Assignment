using System;

public class RideState {
{
private:
	RideState rideRequestedState;
	RideState driverAssignedState;
	RideState customerCancelledState;
	RideState customerWaitingState;
	RideState driverArrivedState;
	RideState rideStartedState;
	RideState rideDoneState;

	RideState state;

public:

	RideState(Ride r) {
		ride = r

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

	virtual void cancelRide(Ride ride)
    {
		Vehicle vehicle = ride.driver.Vehicle
		depositRefund = true

		if (vehicle is Van)
		{
			Console.WriteLine("Booking Fee:" + vehicle.BookingFee);

		}

		if (vehicle is ExcursionBus || vehicle is Van)
		{
			Console.WriteLine("Deposit:" + vehicle.Deposit);
			DateTime currentDate = DateTime.Now;
			if (ride.startTime.AddDays(3) >= currentDate)
			{
				depositRefund = false;
				Console.WriteLine("Deposit fee will not be refunded upon cancellation.");
			}
		}

		while option != "Y" {
			Console.WriteLine("Are you sure you want to cancel this booking? [Y/N]");
			string option = Console.ReadLine();

			switch (option)
			{
				case "Y":

					break;

				case "N":

					return;

				default:
					Console.WriteLine("Invaid Response.");
					Console.WriteLine("");
			}
		}

		setState(customerCancelledState);

		// observer pattern

		foreach (var payment in ride.Receipt.PaymentList)
        {
			if (payment.Purpose == "Booking Fee") || (payment.Purpose == "Deposit Fee" && depositRefund) {
				payment.refund();
				payment.Status = "Refunded";
			}
        }

		// implement email receipt system

		ride.Receipt.Status = "Refunded";
		Console.WriteLine("Ride has been cancelled");
	}
}
