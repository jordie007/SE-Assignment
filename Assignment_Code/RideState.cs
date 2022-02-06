using System;

public class RideState {
{

private: 
	
	Ride ride;

public:

	RideState(Ride r)
	{
		ride = r;
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

		ride.setState(customerCancelledState);

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
