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
