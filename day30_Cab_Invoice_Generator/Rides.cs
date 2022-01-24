using System;
using System.Collections.Generic;
using System.Text;

namespace day30_Cab_Invoice_Generator
{
    public class Rides // Rides Class For Storing Information Of Rides.
    {
        public double RideDistance; // Variable For Storing Ride Distance Of A Particular Ride.

        public double RideTime; // Variable For Storing Ride Time Of A Particular Ride.

        public Rides(double rideDistance, double rideTime) //Initializes a new instance 
        {
            this.RideDistance = rideDistance;  // Ride Distance Of A Ride
            this.RideTime = rideTime;            // Ride Time Of A Ride
        }
    }
}
