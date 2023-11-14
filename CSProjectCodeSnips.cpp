
#include <iostream>
#include <time.h>
#include<string>
#include "UltNum.h"
#include "Mark.h"
using namespace std;
//code snips
//Operator overloading
//exceptions

int getUserFavNum()
{
    int userEntry;
    const string MSG = "Invalid entry...that sucks...I will choose one for you!";
    cout<<"Enter your favorite number: ";
    cin>>userEntry;
    //exceptions
    if(userEntry <= 0 )
        throw(MSG);
    return userEntry;
}
int main()
{
    int favNum;
    const UltimateNum u;
    //exceptions
    try{
        favNum = getUserFavNum();
        cout<< "Your favorite number is "<< favNum <<endl;
        cout<< "Invalid Input = silly goofy lil prank"<<endl;
    }
    catch(string message)
    {
        cout<<message<<endl;\

        //operator overloading
        cout<<u<<endl; 
        Mark();
    }
}
