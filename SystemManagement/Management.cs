using System;

namespace SystemManagement.System
{
    abstract public class SystemParking
    {
        public int Id { get; }
        public int TimeEntering { get; }
        public string Status { get; }
        protected SystemParking(int id , int timeEnterin , string status)
            {
                Id = id;
                TimeEntering = timeEnterin;
                Status = status;
        
            }
        public abstract int PaymentCalculation();
    }

}