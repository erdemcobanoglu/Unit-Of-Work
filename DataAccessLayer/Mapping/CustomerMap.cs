using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
   public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            HasKey(c => c.ID);

            Property(c => c.Phone)
                .HasColumnType("nvarchar")
                .HasMaxLength(20)
                .IsRequired();

            Property(c => c.Email)
                .HasColumnType("nvarchar")
                .HasMaxLength(25)
                .IsRequired();

            Property(c => c.CompanyName)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.ProjectStatus)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.ContactPerson)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();


            HasMany(c => c.CustomerMessages)
                .WithRequired(c => c.Customer)
                .HasForeignKey(c => c.CustomerID);

            HasMany(c => c.Projects)
                .WithRequired(c => c.Customer)
                .HasForeignKey(c => c.CustomerID);

            Property(c => c.Password)
                .HasColumnType("nvarchar")
                .HasMaxLength(15)
                .IsRequired();

            Property(u => u.UserName)
               .HasColumnType("nvarchar")
               .HasMaxLength(15)
               .IsRequired();

        }
    }
}
