using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class GenderRepository : BaseRepository<GenderRepository>
    {
        public GenderRepository(SqlContext context) : base(context)
        {
        }
    }
}
