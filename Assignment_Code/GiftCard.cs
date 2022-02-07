#pragma once
using System;
using namespace std;

public class GiftCard
{
private:

    static int id;
    decimal amount

public:

    GiftCard(decimal a)
    {
        // auto increment id
        amount = a;
    }

    public int Id { get; set; }
    public decimal Amount { get; set; }

}