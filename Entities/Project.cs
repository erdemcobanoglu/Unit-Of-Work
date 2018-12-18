using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Project
    {
        public Project()
        {
            this.Tasks = new HashSet<Entities.Task>();   
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime PlanningStartDate { get; set; }
        public DateTime PlanningEndDate { get; set; }
        public int CustomerID { get; set; }

        public virtual Customer Customer { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public virtual ICollection<Task> Tasks { get; set; }

        
    }
}
