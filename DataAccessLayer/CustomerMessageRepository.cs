using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerMessageRepository : BaseRepository<CustomerMessage>
    {
        public CustomerMessageRepository(SqlContext context) : base(context)
        {
        }
    }
}
