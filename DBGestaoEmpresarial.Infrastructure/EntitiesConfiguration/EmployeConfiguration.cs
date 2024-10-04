using DBGestaoEmpresarial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DBGestaoEmpresarial.Infrastructure.ConfigurationEntities
{
    public class EmployeConfiguration : IEntityTypeConfiguration<Employe>
    {
        public void Configure(EntityTypeBuilder<Employe> builder)
        {

            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();

            builder.Property(x => x.Name)
              .HasColumnType("VARCHAR(255)")
              .IsRequired();

            builder.Property(x => x.Salario)
          .HasColumnType("decimal(18,2)")
          .IsRequired();

            builder.Property(x => x.Email).HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.Telefones).HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.idFuncionario).ValueGeneratedOnAdd().IsRequired();

        }

    }
}
