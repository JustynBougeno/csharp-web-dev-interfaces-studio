using System;
using Application;
namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            CD myCd = new CD(true, true, "music", "DTS", "Regual", 24);
            DVD myDvd = new DVD(true, true, "music", "DTS", "Regual", 24);



            myCd.Spin();
            myDvd.Spin();
            // TODO: Call each CD and DVD method to verify that they work as expected.
        }
    }
}
