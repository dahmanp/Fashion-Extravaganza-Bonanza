#include <iostream>
#include <time.h>
#include<string>
#include "Mark.h"
using namespace std;
//code snips:
//Operator overloading
//exceptions
//constructor/destructor
//while and do while loop


class UltimateNum{
    public:
        int ultNum;
        UltimateNum(){
            srand(time(NULL));
            ultNum = rand() % 1000 + 1;
            
        }
        ~UltimateNum(){cout<<"Play Again Soon! ;)"<<endl;}
        
        //operator overloading
    friend ostream& operator<<(ostream& os, const UltimateNum&);       
};
ostream& operator<<(ostream& os, const UltimateNum& u)
{
    os << u.ultNum << " is the your new favorite number!" << endl;
    return os;
}

int getUserFavNum()
{
    int userEntry;
    //random while and do while loop 
    //because we dont have one in our unity code :)
    int i = 0;
    int a = 123;
    
    while(i == 0)
    {
        cout<<endl; 
        i++;
    }
    
    do{
        a++;
    }
    while (a <= 124);
    
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
        cout<< "WOW! Your favorite number is "<< favNum << "? ME TOO! "<<endl;
        cout<< "HINT: Invalid Input = silly goofy lil prank"<<endl;
    }
    catch(string message)
    {
        cout<<message<<endl;\

        //operator overloading
        cout<<u<<endl; 
        Mark();
    }
}
