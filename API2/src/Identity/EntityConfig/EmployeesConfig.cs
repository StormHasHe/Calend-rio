using Entities.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.EntityConfig
{
    public class EmployeesConfig : EntityTypeConfiguration<Employee>
    {
        public EmployeesConfig()
        {
            HasKey(x => x.intEmployeeID);

            Property(x => x.txtLogin)
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.txtPassword)
                .IsRequired()
                .HasMaxLength(50);

            ToTable("tblEmployees");
        }
    }
}
