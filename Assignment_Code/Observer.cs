#pragma once
using System;
using namespace std;

public interface Observer
{
    void update(Subject s);
}
