using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Title
    {
        public Title()
        {
            Employees =new  HashSet<Employee>();
        }

        public int ID { get; set; }

        public string TitleName { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
