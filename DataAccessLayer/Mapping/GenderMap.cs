using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Mapping
{
   public class GenderMap : EntityTypeConfiguration<Gender>
    {
        public GenderMap()
        {
            HasKey(g => g.ID);

            Property(g => g.GenderType).
                HasMaxLength(50).
                HasColumnType("nvarchar").
                IsRequired();

        }
       

    }
}
