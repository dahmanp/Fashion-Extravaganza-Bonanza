#pragma once
#include<iostream>
#include<time.h>
using namespace std;

class UltimateNum{
    public:
        int ultNum;
        UltimateNum(){
            srand(time(NULL));
            ultNum = rand() % 1000 + 1;
            
        }
        //operator overloading
    friend ostream& operator<<(ostream& os, const UltimateNum&);       
};
ostream& operator<<(ostream& os, const UltimateNum& u)
{
    os << u.ultNum << " is the your new favorite number!" << endl;
    return os;
}