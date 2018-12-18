using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class ProjectRepository : BaseRepository<Project>
    {
        public ProjectRepository(SqlContext context) : base(context)
        {
        }
    }
}
