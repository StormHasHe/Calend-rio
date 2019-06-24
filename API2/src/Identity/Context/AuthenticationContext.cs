using System;
using System.Data.Entity;
using Entities.Identity;
using Identity.EntityConfig;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Identity.Context
{
    public class AuthenticationContext : DbContext, IDisposable
    {
        public AuthenticationContext()
            : base("CalendarioOperacaoConn")
        {
            Database.SetInitializer<AuthenticationContext>(null);
        }

        public static AuthenticationContext Create()
        {
            return new AuthenticationContext();
        }

        public DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeesConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}