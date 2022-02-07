#pragma once
using System;
using namespace std;

public abstract class  Payment
{
private:
	string purpose; // Booking Fee, Trip Fare, Deposit
	decimal amount;
	string status; // A refunded receipt may not refund all payments
	Receipt receipt;

public:

	Payment(Receipt r, string p, decimal a)
    {
		receipt = r;
		purpose = p;
		amount = a;
		status = "Paid"
    }

	abstract void pay();
	abstract void refund();

    public string Purpose { get; set; }
	public decimal Amount { get; set; }
	public string Status { get; set; }
	public Receipt Receipt { get; set; }
}
