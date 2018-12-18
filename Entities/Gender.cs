using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Gender
    {

        public Gender()
        {
            this.Employees = new HashSet<Employee>();
        }


        public int ID { get; set; }
        public string GenderType {get;set;}

        public virtual ICollection<Employee> Employees { get; set; }   


    }
}
