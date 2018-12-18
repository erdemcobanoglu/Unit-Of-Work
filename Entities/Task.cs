using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Task
    {

        public Task()
        {
            //Employee = new Employee();
            //Project = new Project();
        }

        public int ID { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime  FinalDate { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }
        public int EmloyeeId { get; set; }

        public virtual Employee  Employee{ get; set; }

        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }


    }
}
