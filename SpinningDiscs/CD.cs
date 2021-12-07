using System;
using Application;


namespace SpinningDiscs
{
    public class CD : Disk, IOpticalDisc

    {

        // TODO: Implement your custom interface.
        int NumberOfSongs { get; set; }

        public CD (bool lazerWriten, bool lazerRead, string dataInfo, string soundQuality, string plasticType, int numberOfSongs)
            : base(lazerWriten, lazerRead, dataInfo, soundQuality, plasticType)
        {
            NumberOfSongs = numberOfSongs;
        }

        //public void SpinDisc()
        //{
        //    Console.WriteLine("GFAst");
        //}

        public void Spin()
        {
            Console.WriteLine("GFAst");
        }
    }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
    
}
