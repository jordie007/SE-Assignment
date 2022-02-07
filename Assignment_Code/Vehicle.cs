#pragma once
using System;
using namespace std;

public class Vehicle
{
private:

    string licencePlateNo;
    string brand;
    string model;

public:

    Vehicle(string plateNo, string vehBrand, string vehModel)
    {
        licencePlateNo = plateNo;
        brand = vehBrand;
        model = vehModel;
    }

    public string LicencePlateNo { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
}