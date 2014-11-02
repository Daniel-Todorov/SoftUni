namespace NightlifeEntertainment
{
    using System;

    public class VipTicket : Ticket
    {
        public VipTicket(IPerformance performance)
            : base(performance, TicketType.VIP)
        {
        }

        protected override decimal CalculatePrice()
        {
            decimal reducedPrice = base.CalculatePrice() * 1.5M;

            return reducedPrice;
        }
    }
}
