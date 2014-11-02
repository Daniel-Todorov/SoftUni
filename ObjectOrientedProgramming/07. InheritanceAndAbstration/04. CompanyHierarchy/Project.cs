using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.CompanyHierarchy
{
    public class Project : IProject
    {
        private string name;
        private DateTime startDate;
        private string details;
        private ProjectState state;

        public Project(string name, DateTime startDate, string details)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.details = details;
            this.state = ProjectState.Opened;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("name", "Name cannot be empty or null");
                }

                this.name = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return this.startDate;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("startDate", "Start date cannot be null.");
                }

                this.startDate = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("details", "Details cannot be null or empty.");
                }

                this.details = value;
            }
        }

        public ProjectState State
        {
            get
            {
                return this.state;
            }
            private set
            {
                this.state = value;
            }
        }

        public void CloseProject()
        {
            this.State = ProjectState.Closed;
        }

        public override string ToString()
        {
            return string.Format("Project: {0}, {1}, {2}{3} {4}{5}", this.Name, this.StartDate.ToShortDateString(), Environment.NewLine, this.Details, Environment.NewLine, this.State);
        }
    }
}
