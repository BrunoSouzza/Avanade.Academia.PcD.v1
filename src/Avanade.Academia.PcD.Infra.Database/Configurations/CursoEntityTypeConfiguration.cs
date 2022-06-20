using Avanade.Academia.PcD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avanade.Academia.PcD.Infra.Database.Configurations
{
    public class CursoEntityTypeConfiguration : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.Property(c => c.Descricao)
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(c => c.Nome)
                   .HasMaxLength(100)
                   .IsRequired();
        }
    }
}
