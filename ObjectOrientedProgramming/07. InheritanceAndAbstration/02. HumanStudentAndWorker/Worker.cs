//•	Define a class Worker derived from Human with fields WeekSalary and WorkHoursPerDay and method MoneyPerHour() 
//that returns the payment earned by hour by the worker. 

namespace _02.HumanStudentAndWorker
{
    using System;

    public class Worker: Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            :base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("weekSalary", "Noone works for free.");
                }

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("workHoursPerDay", "Work hours can't have negative or zero value.");
                }

                if (value > 12)
                {
                    throw new ArgumentOutOfRangeException("workHoursPerDay", "Law does not allow more than 12 working hours per day.");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = this.WeekSalary / 5 * this.WorkHoursPerDay;

            return moneyPerHour;
        }
    }
}
