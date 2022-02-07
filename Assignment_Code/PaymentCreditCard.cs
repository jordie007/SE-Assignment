#pragma once
using System;
using namespace std;

public class PaymentCreditCard : Payment
{
	private:
	int creditCardNo

	public:
	PaymentCreditCard(int creditNo, Receipt r, string p, decimal a) : base(r, p, a)
	{
		creditCardNo = creditNo
	}

	void pay() { }

	void refund()
	{
		if receipt.status != "Refunded"
		{
			// implementation for credit card system refund
		}
	}

	public int CreditCardNo { get; set; }
}
