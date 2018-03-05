using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Location_Tracker
{
    class Speed_Time_Calculate
    {
        private double Cur_Speed;
        private double TimeRemain;

        public double getSpeed()
        {
            Calculate_Speed_Distance();
            return Cur_Speed;
        }

        public double get_TimeRemain()
        {
            return TimeRemain;
        }

        private void Calculate_Speed_Distance()
        {
            String data = GlobalVar.Serial_Data.GetData();
            double newLat = Convert.ToDouble(data.Substring(5, 9));
            double newLon = Convert.ToDouble(data.Substring(15, 11));

            double R = 6378137;
            double dLat,dLong,a,c,d; // d: Distance between new and last point

            try
            {
                dLat = Rad(newLat - GlobalVar.Lat);
                dLong = Rad(newLon - GlobalVar.Lon);
               
                a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                     Math.Cos(Rad(GlobalVar.Lat)) * Math.Cos(Rad(newLat)) *
                     Math.Sin(dLong / 2) * Math.Sin(dLong / 2);
                c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
                d = R * c;
                GlobalVar.Distance = d;

                Cur_Speed = d / 2;

                // Update Lat Long
                GlobalVar.Lat = newLat;
                GlobalVar.Lon = newLon;
            }
            catch
            {

            }
        }

        private double Rad(double x)
        {
            return x * Math.PI / 180;
        }
    }
}
