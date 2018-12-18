using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Mapping
{
   public class TaskMap: EntityTypeConfiguration<Entities.Task>

    {
        public TaskMap()
        {
            HasKey(t => t.ID);
            Property(t => t.BeginDate).HasColumnType("datetime").IsRequired();
            Property(t => t.FinalDate).HasColumnType("datetime").IsRequired();
            Property(t => t.Status).HasMaxLength(50).HasColumnType("nvarchar").IsRequired();
            //Property(t => t.EmloyeeId)
            //    .IsOptional();

            Property(t => t.Description)
                .HasMaxLength(250)
                .IsRequired()
                .HasColumnType("nvarchar");


        }

    }
}
