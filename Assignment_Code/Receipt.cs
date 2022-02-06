using System;

public class Receipt
{
private:
	decimal amount;
	string status; // "Refunded", "Paid", "Unpaid"
	int pointsEarned;
	Ride ride;

	List<Payment> paymentList;

public:
	Receipt(Ride r)
	{
		status = "Unpaid";
		pointsEarned = 0;
		ride = r;
	}

	void calculatePoints()
    {
		// implementation for points calculation
	}

	public decimal Amount { get; set; }
	public string Status { get; set; }
	public int PointsEarned { get; set; }
	public List<Payment> PaymentList { get; set; }
}
