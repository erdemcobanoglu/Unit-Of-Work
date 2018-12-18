using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CustomerMessage
    {
        
        public int ID { get; set; }

        public string Name { get; set; }
        

        public string  Status { get; set; }


        public string Description { get; set; }

        public int? CustomerID { get; set; }
        public  virtual Customer  Customer { get; set; }

    }
}
