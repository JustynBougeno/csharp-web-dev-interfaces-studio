using System;
using System.Collections.Generic;
namespace SpinningDiscs
{
    public abstract class Disk
    {
            bool LazerWriten { get; set; }
            bool LazerRead { get; set; }
            string DataInfo { get; set; }
            string SoundQuality { get; set; }
            string PlasticType { get; set; }

            public Disk(bool lazerWriten, bool lazerRead, string dataInfo, string soundQuality, string plasticType)
            {
                LazerWriten = lazerWriten;
                LazerRead = lazerRead;
                DataInfo = dataInfo;
                SoundQuality = soundQuality;
                PlasticType = plasticTypeType;

            }

    }
}