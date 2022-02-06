using System;

public class DriverAccount : UserAccount
{
private:

    string bankAccNo;
    string bankName;
    decimal amount;
    Vehicle vehicle;

public:

    DriverAccount(string bankNo, string bankNa, string n, string cNo, string eA) : base(n, cNo, eA)
    {
        bankAccNo = bankNo;
        bankName = bankNa;
        amount = 0;
    }

}