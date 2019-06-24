using System.Data.Entity.ModelConfiguration;
using Entities.CalendarioOperacao;

namespace DataAccess.EntityConfig
{
    public class AulaConfig : EntityTypeConfiguration<Aula>
    {
        public AulaConfig()
        {
            HasKey(u => u.Id);

            Property(u => u.Data)
                .IsRequired();

            Property(u => u.Local)
                .IsRequired()
                .HasMaxLength(50);

            Property(u => u.Tipo)
                .IsRequired()
                .HasMaxLength(50);

            Property(u => u.Subtipo)
                .IsRequired();

            Property(u => u.JSONObj)
                .IsRequired();

            Property(u => u.Status)
                .IsRequired();

            Property(u => u.ResponsavelID)
                .IsRequired();

            Property(u => u.SeguidoresID)
                .IsRequired();

            ToTable("Aulas");
        }
    }
}