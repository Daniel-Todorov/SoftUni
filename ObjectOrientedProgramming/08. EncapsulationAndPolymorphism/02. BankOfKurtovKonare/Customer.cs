namespace _02.BankOfKurtovKonare
{
    public class Customer
    {
        public Customer(string name, string Id, CustomerType type)
        {
            this.Name = name;
            this.Id = Id;
            this.Type = type;
        }

        public string Name { get; set; }

        public string Id { get; set; }

        public CustomerType Type { get; set; }
    }
}
