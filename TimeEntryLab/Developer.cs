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

        public virtual ICollection<IndustryComment> Comments { get; set; }
        public virtual ICollection<ClientComment> Clients { get; set; }
        public virtual ICollection<ProjectComment> Projects { get; set; }



    }
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StateDate { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<Developer> Developers { get; set; } = new List<Developer>();
    }

    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

        public virtual  Industry Industry { get; set; }

    }

    public class Industry
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<IndustryComment> Comments { get; set; } 
    }
    public class IndustryComment
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public Industry Industry { get; set; }
        public Developer Developer { get; set; }
    }
    public class ClientComment
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public Client Industry { get; set; }
        public Developer Developer { get; set; }
    }
    public class ClientComment
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public Client Industry { get; set; }
        public Developer Developer { get; set; }
    }

    //public class Comment
    //{
    //    public int Id { get; set; }
    //    public string Notes { get; set; }

    //    public virtual Industry Industry { get; set; }
    //    public virtual Client Client { get; set; }
    //    public virtual Project Project { get; set; }

    //    public virtual ICollection<Developer> Developers { get; set; } = new List<Developer>();
    //}
}
