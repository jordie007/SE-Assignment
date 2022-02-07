#pragma once
using System;
using namespace std;

public class PaymentPoints : Payment
{
private:

public:
	PaymentPoints(Receipt r, string p, decimal a) : base(r, p, a) { }

	void pay() { }

	void refund()
	{
		if receipt.status != "Refunded"
		{
			receipt.ride.customer.points += ToInt32(amount)
		}
	}
}
