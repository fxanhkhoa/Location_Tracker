using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Location_Tracker
{
    class GlobalVar
    {
        private static Serial_Data _Serial_Data;
        private static double _Lat;
        private static double _Lon;
        private static double _Distance;
        private static Speed_Time_Calculate _Speed_Time_Calculate;

        public static Speed_Time_Calculate Speed_Time_Calculate
        {
            get { return _Speed_Time_Calculate; }
            set { _Speed_Time_Calculate = value; }
        }

        public static Serial_Data Serial_Data
        {
            get { return _Serial_Data; }
            set { _Serial_Data = value; }
        }

        public static double Lat
        {
            get { return _Lat; }
            set { _Lat = value; }
        }

        public static double Lon
        {
            get { return _Lon; }
            set { _Lon = value; }
        }

        public static double Distance
        {
            get { return _Distance; }
            set { _Distance = value; }
        }
    }
}
