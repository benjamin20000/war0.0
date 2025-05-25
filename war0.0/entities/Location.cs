using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    internal class Location 
    {
        public double Latitude;
        public double Longitude;
        public double Altitude;

        public Location(double latitude = 0, double longitude = 0, double altitude = 0)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Altitude = altitude;
        }

        public double[] getLocation()
        {
            double[] res = new double[3];
            res[0] = Latitude;
            res[1] = Longitude;
            res[2] = Altitude;
            return res;
        }

        public void setLocation(double latitude, double longitude, double altitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Altitude = altitude;
        }

        public void printLocation()
        {
            Console.WriteLine($"Latitude: {this.Latitude}, Longitude: {this.Longitude}, Altitude: {this.Altitude}");
             
        }
    }
}
