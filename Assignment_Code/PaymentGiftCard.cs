#pragma once
using System;
using namespace std;

public class PaymentGiftCard : Payment
{
private:
	GiftCard giftCard;

public:
	PaymentGiftCard(GiftCard gift, Receipt r, string p, decimal a) : base(r, p, a) {
		giftCard = gift;
	}

	void pay() { }

	void refund() {
		if receipt.status != "Refunded"
		{
			giftCard.amount += amount
		}
	}

	public GiftCard Giftcard { get; set; }
}
