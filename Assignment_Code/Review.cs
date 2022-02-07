#pragma once
using System;
using namespace std;

public class Review
{
private:

    static int id;
    string review
    UserAccount reviewer;
    UserAccount reviewee;

public:

    Review(string r, UserAccount er, UserAccount ee)
    {
        // auto increment id
        review = r;
        reviewer = er;
        reviewee = ee;
    }

    public int Id { get; set; }
    public string Review { get; set; }
    public UserAccount Reviewer { get; set; }
    public UserAccount Reviewee { get; set; }

}