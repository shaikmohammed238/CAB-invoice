using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice_Generator
{/* UC3:- The Invoice generator should now return the following as a part of the invoice.
                 - Total Number Of Ride
                 - Total Fare
                 - Average Fare Per Ride
         */
    public class InvoiceSummary
    {
        public int NumberOfRides;
        public double TotalFare;
        public double AverageFarePerRide;

        public InvoiceSummary(int numberOfRides, double totalFare) // Initializes a new instance
        {
            this.NumberOfRides = numberOfRides;
            this.TotalFare = totalFare;
            this.AverageFarePerRide = this.TotalFare / this.NumberOfRides; //calculate AverageFarePerRide
        }
        // Overriding Equals Method.

        public override bool Equals(object obj) => obj is InvoiceSummary summary &&
                   this.NumberOfRides == summary.NumberOfRides &&
                   this.TotalFare == summary.TotalFare &&
                   this.AverageFarePerRide == summary.AverageFarePerRide;


        // Overriding GetHashCode Method.

        public override int GetHashCode() => HashCode.Combine(this.NumberOfRides, this.TotalFare, this.AverageFarePerRide);
    }
}