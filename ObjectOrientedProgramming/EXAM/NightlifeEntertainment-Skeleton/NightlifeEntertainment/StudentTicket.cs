namespace NightlifeEntertainment
{
    using System;

    public class StudentTicket : Ticket
    {
        public StudentTicket(IPerformance performance)
            : base(performance, TicketType.Student)
        {
        }

        protected override decimal CalculatePrice()
        {
            decimal reducedPrice = base.CalculatePrice() * 0.8M;

            return reducedPrice;
        }
    }
}
