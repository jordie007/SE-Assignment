#pragma once
using System;
using namespace std;

public class UserAccount : Observer
{
private:

    static int id;
    List<Ride> rideList;
    string name;
    string contactNo;
    string emailAddr;
    double rating;

public:

    UserAccount(string n, string cNo, string eA)
    {
        // auto increment id
        name = n;
        contactNo = cNo;
        emailAddr = eA;
    }

    void update(Subject s)
    {
        if (s is Ride)
        {
            // Implementation of phone notification system
            Console.WriteLine("Ride has updated to status: " + s.State.Name)
        }
    }

    public int Id { get; set; }
    public List<Ride> RideList { get; set; }
    public string Name { get; set; }
    public string ContactNo { get; set; }
    public string EmailAddr { get; set; }
    public double Rating { get; set; }

}