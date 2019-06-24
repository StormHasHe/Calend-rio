using System;
using System.Data.Entity;
using DataAccess.EntityConfig;
using Entities.CalendarioOperacao;

namespace DataAccess.Context
{
    public class ApplicationContext : DbContext, IDisposable
    {
        public ApplicationContext()
            : base("CalendarioOperacaoConn")
        {
            Database.SetInitializer<ApplicationContext>(null);
        }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }

        public DbSet<Aula> Aulas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AulaConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}