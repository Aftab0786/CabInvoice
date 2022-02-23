using CabInvoiceGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabInvoiceTestProject
{
    [TestClass]
    public class CabInvoiceGeneratorTestClass
    {
        [TestMethod]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            ///AAA
            //Arrange
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 5;
            int time = 6; // 5*10 + 6*1 = 56
            double expected = 56;

            //Act
           double actual = invoiceGenerator.CalculateFare(distance, time);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fare")]
        public void GivenMultipleRideShouldReturnAggregateTotalFare()
        {
            double expected = 60;
            //Arrange
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);
            //Act
            double actual = invoiceGenerator.CalculateFare(rides);
            //Assert
            Assert.AreEqual(expected, actual);
            

            
        }
    }
}