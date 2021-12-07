using System;
using Application;

namespace SpinningDiscs
{
    public class DVD : Disk, IOpticalDisc
    {

        // TODO: Implement your custom interface.
        int NumberOfScenes { get; set; }

        public DVD(bool lazerWriten, bool lazerRead, string dataInfo, string soundQuality, string plasticType, int numberOfScenes) : base(lazerWriten, lazerRead, dataInfo, soundQuality, plasticType)
        {
            NumberOfScenes = numberOfScenes;
        }



        //public void SpinDisc()
        //{
        //    Console.WriteLine("I'm a movie");
        //}

        public void Spin()
        {
            Console.WriteLine("I'm a movie");
        }
       // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
    }
}
