using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompanyHierarchy
{
    public class Developer : Employee, IDeveloper
    {
        private IList<Project> projects;

        public Developer(string id, string firstName, string lastName, decimal salary)
            :base(id, firstName, lastName, salary, Department.Production)
        {
            this.projects = new List<Project>();
        }

        public IList<Project> Projects
        {
            get
            {
                return this.projects;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("projects", "Prjects can't be null.");
                }

                this.projects = value;
            }
        }

        public override string ToString()
        {
            string initial = base.ToString();
            StringBuilder result = new StringBuilder();
            result.AppendLine("Developer: " + initial);

            foreach (var project in this.Projects)
            {
                result.AppendLine(string.Format("\t{0}", project));
            }

            return result.ToString();
        }
    }
}
