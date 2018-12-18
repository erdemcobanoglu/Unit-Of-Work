using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
   public class CustomerMessageMap : EntityTypeConfiguration<CustomerMessage>
    {
        public CustomerMessageMap()
        {
            HasKey(cm => cm.ID);

            Property(cm => cm.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(cm => cm.Description)
                .HasColumnType("nvarchar")
                .HasMaxLength(200)
                .IsRequired();

            Property(cm => cm.CustomerID)
                .IsOptional();
        }
    }
}
