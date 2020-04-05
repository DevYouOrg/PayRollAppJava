using System;

namespace PayrollApp
{
    public class Employee
    {
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }
        public string Name { get; set; }
        public double BasePay { get; set; }
        public double TotalPay { get; set; }

        public Employee()
        {
            //Name = name;

            //Sets a default value
            HourlyRate = 20.75;
        }

        public double CalculateTotalPay()
        {
            BasePay = HoursWorked * HourlyRate;

            TotalPay = BasePay;

            return TotalPay;
        }

    }
}
