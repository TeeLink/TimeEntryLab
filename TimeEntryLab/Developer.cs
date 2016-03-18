using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeEntryLab
{
    public class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }

        public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
    }
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StateDate { get; set; }

        public virtual ICollection<Developer> Developers { get; set; } = new List<Developer>();
    }

    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Project> Projects { get; set; } = new List<Project>();



    }
}
