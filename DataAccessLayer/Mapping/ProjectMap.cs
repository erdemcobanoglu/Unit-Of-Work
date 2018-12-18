using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
  public  class ProjectMap : EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            HasKey(p => p.ID);

            Property(p => p.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.PlanningEndDate)
                 .HasColumnType("datetime")
                 .IsRequired();

            Property(p => p.PlanningStartDate)
                 .HasColumnType("datetime")
                 .IsRequired();

            Property(p => p.StartDate)
                .HasColumnType("datetime")
                 .IsOptional();

            Property(p => p.EndDate)
                .HasColumnType("datetime")
                .IsOptional();
           

        }
    }
}
