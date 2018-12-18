using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
   public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // todo :
            HasKey(e => e.ID);

            Property(e => e.SocialNumber)
                .HasMaxLength(20)
                .HasColumnType("varchar")
                .IsRequired();

            Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            Property(e => e.LastName)
                .HasMaxLength(60)
                .HasColumnType("varchar")
                .IsRequired();

            Property(e => e.BirthDate)
                .HasColumnType("datetime")
                .IsRequired();

            Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();
           


            Property(e => e.Password)
                .HasColumnType("nvarchar")
                .HasMaxLength(15)
                .IsRequired();

            Property(e => e.UserName)
           .HasColumnType("nvarchar")
           .HasMaxLength(20)
           .IsRequired();

            // Employee with Gender
            HasRequired(e => e.Gender)
                  .WithMany(e => e.Employees)
                  .HasForeignKey(e => e.GenderId);

            //Employee with Title
            HasRequired(e => e.Title)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.TitleId);


            //Employe with Task
            HasMany(e => e.Tasks)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.EmloyeeId);

            #region ReportEklendi
            HasMany(r => r.Reports)
                   .WithRequired(e => e.EmployeeAnalyst)
                   .HasForeignKey(e => e.AnalystID); 
            #endregion


        }
    }
}
