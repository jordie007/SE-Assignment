#pragma once
using System;
using namespace std;

public class Van: Vehicle
{
private:

    decimal deposit;
    decimal bookingFee;

public:

    Van(decimal depo, decimal fee, string plateNo, string vehBrand, string vehModel): base(plateNo, vehBrand, vehModel)
    {
        deposit = depo;
        bookingFee = fee;
    }

    public decimal deposit { get; set; }
    public decimal bookingFee { get; set; }

}