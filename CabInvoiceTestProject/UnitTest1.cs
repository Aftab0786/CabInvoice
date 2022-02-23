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
    }
}