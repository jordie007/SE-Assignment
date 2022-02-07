#pragma once
using System;
using namespace std;

public class Rating
{
private:

    static int id;
    int rating;
    UserAccount rater;
    UserAccount ratee;

public:

    Rating(int r, UserAccount ter, UserAccount tee)
    {
        // auto increment id
        rating = r;
        rater = ter;
        ratee = tee;
    }

    public int Id { get; set; }
    public int Rating { get; set; }
    public UserAccount Rater { get; set; }
    public UserAccount Ratee { get; set; }

}