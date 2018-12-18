using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
   public class ReportMap : EntityTypeConfiguration<Report>
    {
        public ReportMap()
        {
            HasKey(r => r.ID);

            Property(r => r.Title)
                .HasMaxLength(25)
                .HasColumnType("varchar")
                .IsRequired();

            Property(r => r.Description)
                .HasMaxLength(250)
                .HasColumnType("nvarchar")
                .IsRequired();
            


        }
    }

}
