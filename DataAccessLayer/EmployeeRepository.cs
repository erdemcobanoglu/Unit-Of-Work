using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class EmployeeRepository : BaseRepository<Employee>
    {
        public EmployeeRepository(SqlContext context) : base(context)
        {
        }
    }
}
