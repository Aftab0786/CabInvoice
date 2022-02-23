using System.Runtime.Serialization;

namespace CabInvoiceGenerator
{
    [Serializable]
    public class CabInvoiceException : Exception
    {
        public CabInvoiceException(ExceptionType type, string message)
        {
            throw new Exception(message);
            //this.type = type;
        }
        public enum ExceptionType
        {
            INVALID_DISTANCE, INVALID_TIME, NULL_RIDES, INVALID_USER_ID, INVALID_RIDETYPE
        }
        
    }
}