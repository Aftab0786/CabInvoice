using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        public double totalFare;
        public double average;
        public int numofRides;

        public InvoiceSummary(int numofRides, double totalFare)
        {
            this.totalFare = totalFare;
            this.numofRides = numofRides;
            this.average = totalFare / numofRides;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is InvoiceSummary))
            {
                return false;
            }
            InvoiceSummary imputedObject = (InvoiceSummary)obj;
            return this.numofRides == imputedObject.numofRides && this.totalFare == imputedObject.totalFare && this.average == imputedObject.average;
        }
    }
}
