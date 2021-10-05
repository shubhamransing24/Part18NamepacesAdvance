using System;
using ProjecA.TeamA;
using ProjectB.TeamA;

namespace Part18NamepacesAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            //we refere the class A and The class B from different assembly
            A a = new A();
            a.Print();
            B b = new B();
            b.Print();

        }
    }
}
