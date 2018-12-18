using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee
    {
        public Employee()
        {
            this.Tasks = new HashSet<Task>();


            this.Reports = new HashSet<Report>();  //Report Eklendi
        }

        public int ID { get; set; }


        public string SocialNumber { get; set; }


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }


        public string Address { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }

        public int TitleId { get; set; }
        public Title Title { get; set; }

        public int GenderId { get; set; }
        public Gender Gender { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public ICollection<Task> Tasks { get; set; }

        public ICollection<Report> Reports { get; set; }  //Report Eklendi

        public override string ToString()
        {
            return FirstName + " " + LastName;

        }

    }
}
