#pragma once
using System;
using namespace std;

public class ExcursionBus: Vehicle
{
private:

    decimal deposit;

public:

    ExcursionBus(decimal depo, string plateNo, string vehBrand, string vehModel): base(plateNo, vehBrand, vehModel)
    {
        deposit = depo;
    }

    public decimal deposit { get; set; }

}