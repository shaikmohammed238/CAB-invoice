using Cab_Invoice_Generator;
using day30_Cab_Invoice_Generator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CabInvoiceGeneratorTest
{
    class CabInvoiceGeneratorTest
    {
        private CabInvoiceGenerator cabInvoiceGenerator;

        [SetUp]
        public void Setup() //SetUp Method.
        {
            this.cabInvoiceGenerator = new CabInvoiceGenerator();
        }
        /* UC1.1:-  Test Method for calculating fare when fare is greater than minimum fare.
         */
        [Test]
        public void GivenDistanceAndTime_FareGreaterThanMinimumFareShouldReturnFare() //create method to calculate greater than minimum fare
        {
            try
            {
                double distance = 10.0; //declare distance veriable and value  // totalFare = (distance * CostPerKilometer) + (time * CostPerMinute);
                double time = 10;    //declare time veriable and value    // (10.0 * 10.0) + (10 * 1.0)= 110
                double expected = 110; //total fare
                double totalFare = this.cabInvoiceGenerator.CalculateFare(distance, time); //call method and passing value
                Assert.AreEqual(expected, totalFare); //check equal or not
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        /*UC1.2:- Test Method for calculating fare when fare is less than minimum fare.
         */
        [Test]
        public void GivenDistanceAndTime_WhenTotalFareIsLessThanMinimumFare_ShouldReturnMinimumFare() //create method to print minimum fare
        {
            try
            {
                double distance = 0.1;
                double time = 1;             // (0.1 * 10.0) + (1 * 1.0)=2
                double MinimumFare = 5.0;      //total fare
                double totalFare = this.cabInvoiceGenerator.CalculateFare(distance, time);  //call method and passing value
                Assert.AreEqual(MinimumFare, totalFare); // check equal or not
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /* UC2:- Invoice generator should now take in multiple rides,and Calculate Aggregate total for all.
        */
        [Test]
        public void GivenDistanceAndTimeForMultipleRides_ShouldReturnAggregateFare() // Method to Calculate Aggregate Fare Of Multiple Rides
        {
            try
            {

                Rides[] ride = { new Rides(4.0, 5.0), new Rides(3.0, 5.0) }; // store multiple ride rideDistance, Ridetime
                double aggregateFare = this.cabInvoiceGenerator.GetMultipleRideFare(ride); //call GetMultipleRideFare method and calculat fare
                Assert.AreEqual(40.0, aggregateFare);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /* UC3:- Test Method To Get Enhanced Invoice Summary With More Ride Details.
       */

        [Test]
        public void GivenDistanceAndTimeForMultipleRides_WhenProper_ShouldReturnInvoiceSummary()
        {
            InvoiceSummary invoiceSummary = new InvoiceSummary(2, 605);
            Rides[] rides = { new Rides(30, 30), new Rides(25, 25) };
            InvoiceSummary invoiceSummaryOne = this.cabInvoiceGenerator.CalculateFare(rides);
            Assert.AreEqual(invoiceSummary, invoiceSummaryOne);
        }
        /* UC4:- Invoice Service.
                 - Given a User Id, the invoice Service gets the list of rides from the RideRepository, and return the Invoice.
         */
        [Test]
        public void GivenDistanceAndTimeForMultipleRides_WhenUserFound_ShouldReturnInvoiceSummary() // Test Method To Get Invoice Summary By User Id.
        {
            try
            {
                string userId = "omkhawshi0@gmail.com"; //userid
                Rides[] rides = { new Rides(3, 5), new Rides(4, 5) }; //multiple ride
                this.cabInvoiceGenerator.MapRidesToUser(userId, rides); //call method
                InvoiceSummary invoiceSummary = this.cabInvoiceGenerator.GetInvoiceSummary(userId); //call method
                InvoiceSummary invoiceSummaryOne = new InvoiceSummary(2, 80);
                Assert.AreEqual(invoiceSummary, invoiceSummaryOne); //check value equal or not
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
