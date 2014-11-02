namespace _04.CompanyHierarchy
{
    using System.Collections.Generic;

    public interface ISalesEmployee
    {
        IList<Sale> Sales { get; set; }
    }
}
