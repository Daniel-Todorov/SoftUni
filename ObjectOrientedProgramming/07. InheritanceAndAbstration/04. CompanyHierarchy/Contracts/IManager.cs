using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompanyHierarchy
{
    public interface IManager
    {
        IList<Employee> Employees { get; set; }
    }
}
