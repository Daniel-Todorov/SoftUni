namespace _04.CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SalesEmployee : Employee, ISalesEmployee
    {
        private IList<Sale> sales;

        public SalesEmployee(string id, string firstName, string lastName, decimal salary, IList<Sale> sales):
            base(id, firstName, lastName, salary, Department.Sales)
        {
            this.Sales = sales;
        }

        public SalesEmployee(string id, string firstName, string lastName, decimal salary)
            :this(id, firstName, lastName, salary, new List<Sale>())
        {

        }

        public IList<Sale> Sales
        {
            get
            {
                return this.sales;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("sales", "Sales cannot be null.");
                }

                this.sales = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("Salesperson: " + base.ToString());
            foreach (var sale in this.Sales)
            {
                result.AppendLine("\t" + sale.ToString());
            }

            return result.ToString();
        }
    }
}
