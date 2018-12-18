using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Customer
    {
       
       

        public Customer()
        {
            this.CustomerMessages = new HashSet<CustomerMessage>();
            this.Projects = new HashSet<Project>();
        }

        
        public int ID { get; set; }

        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string ProjectStatus { get; set; }
        public virtual ICollection<CustomerMessage> CustomerMessages { get; set; }
        public virtual ICollection<Project> Projects { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }



    }
}
