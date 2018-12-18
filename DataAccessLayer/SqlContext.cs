using DataAccessLayer.Mapping;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SqlContext : DbContext
    {
        public SqlContext() : base("RedDB")
        {

        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerMessage> CustomerMessages { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Entities.Task> Tasks { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Todo : Mappleme yapıldıktan sonra Add Hatasına bakılacak++
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new CustomerMessageMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new ProjectMap());
            modelBuilder.Configurations.Add(new TaskMap());
            modelBuilder.Configurations.Add(new TitleMap());
            modelBuilder.Configurations.Add(new GenderMap());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
