using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        public RideType ridetype;
        public readonly double MINIMUM_FARE;
        public readonly double MINIMUM_COST_PER_KM;
        public readonly int COST_PER_TIME;

        public InvoiceGenerator()
        {
            this.MINIMUM_FARE = MINIMUM_FARE;
            this.MINIMUM_COST_PER_KM = MINIMUM_COST_PER_KM;
            this.COST_PER_TIME = COST_PER_TIME;
        }
        public InvoiceGenerator(RideType type)
        {
            this.ridetype = type;
            try
            {
                if (this.ridetype.Equals(RideType.NORMAL))
                {
                    this.MINIMUM_COST_PER_KM = 10;
                    this.COST_PER_TIME = 1;
                    this.MINIMUM_FARE = 5;
                } 
                if (this.ridetype.Equals(RideType.PREMIUM))
                {
                    this.MINIMUM_COST_PER_KM = 15;
                    this.COST_PER_TIME = 2;
                    this.MINIMUM_FARE = 20;
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_RIDETYPE, "invalid ride type");
            }
           

        }
        public double CalculateFare(double distance, int time)
        {
            double totalfare = 0;
            try
            {
                if(distance <= 0)
                {
                    try
                    {

                        throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_DISTANCE, "Invalid Distance");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
                if(time <= 0)
                {
                   
                    
                  throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_TIME, "Invalid Time");
                    
                    
                }
                totalfare = distance * MINIMUM_COST_PER_KM + time * COST_PER_TIME;
             }
            catch(CabInvoiceException ex)
            {
                Console.WriteLine(ex);

            }
            return Math.Max(totalfare, MINIMUM_FARE);


        }
    }
}
