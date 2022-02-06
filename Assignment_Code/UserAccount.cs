using System;

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

    void update(Subject s)
    {
        if (s is Ride)
        {
            // Implementation of phone notification system
            Console.WriteLine("Ride has updated to status: " + s.State.Name)
        }
    }

}