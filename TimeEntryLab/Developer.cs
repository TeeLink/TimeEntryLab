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
        public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
        public virtual ICollection<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>();

        public virtual ICollection<IndustryComment> IndustryComments { get; set; } = new List<IndustryComment>();
        public virtual ICollection<ClientComment> ClientComments { get; set; } = new List<ClientComment>();
        public virtual ICollection<ProjectComment> ProjectComments { get; set; } = new List<ProjectComment>();



    }
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<Developer> Developers { get; set; } = new List<Developer>();
        public virtual ICollection<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>();

        public virtual ICollection<ProjectComment> ProjectComments { get; set; } = new List<ProjectComment>();

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

        public virtual ICollection<IndustryComment> IndustryComments  { get; set; } = new List<IndustryComment>();
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
        public Client Client { get; set; }
        public Developer Developer { get; set; }

        public virtual ICollection<ClientComment> ClientComments { get; set; } = new List<ClientComment>();

    }
    public class ProjectComment
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public Project Project { get; set; }
        public Developer Developer { get; set; }
    }

    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Developer> Developers { get; set; } = new List<Developer>();

    }

    public class TimeEntry
        {
            public int Id { get; set; }
            public DateTime DateWorked { get; set; }
            public int HoursWorked { get; set; }
            public Developer Developer { get; set; }
            public Project Project { get; set; }
        }


    }


