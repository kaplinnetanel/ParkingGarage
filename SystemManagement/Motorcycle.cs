using System;
using System.Runtime.Intrinsics.Arm;
namespace SystemManagement.System
{
    public class CarMotorcycle : SystemParking
    {
        public CarMotorcycle(int id, int timeEnterin, string status) : base(id, timeEnterin, "CarMotorcycle")
        { }
        public override int PaymentCalculation(int sum)
            {
                return sum * 8;
            }



    }



}