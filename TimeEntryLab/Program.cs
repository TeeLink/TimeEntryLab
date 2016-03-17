using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeEntryLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new TimeEntryDBContext();

            var developers = db.Developers.ToList();
        }
    }
}
