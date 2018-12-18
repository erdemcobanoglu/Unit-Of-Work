using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
  public  class TitleMap : EntityTypeConfiguration<Title>
    {
        public TitleMap()
        {
            HasKey(t => t.ID);

            Property(t => t.TitleName)
             .HasMaxLength(50)
             .HasColumnType("varchar")
             .IsRequired();
     
                
      }
    }
}
