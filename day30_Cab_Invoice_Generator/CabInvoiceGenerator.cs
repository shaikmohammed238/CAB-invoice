using System;
using System.Collections.Generic;
using System.Text;

namespace day30_Cab_Invoice_Generator
{  /* UC1:- Calculating Fare of a Ride. 
             - Given Distance and Time, the invoice generator should return the total fare for the journey.
             - Cost.Rs.10 per kilometer+Rs.1 Per minute.
             - Minimum Fare-Rs.5.
    */
    public class CabInvoiceGenerator
    {
        private static readonly double CostPerKilometer = 10.0; // Declare varible only read value
        private static readonly double CostPerMinute = 1.0;
        private static readonly double MinimumFare = 5.0;
        private double totalFare = 0.0;   //declare veriable    
        public double CalculateFare(double distance, double time) //create method to Calculating Fare
        {
            this.totalFare = (distance * CostPerKilometer) + (time * CostPerMinute); //calculate fare
            return Math.Max(this.totalFare, MinimumFare); //return value
        }
    }
}
