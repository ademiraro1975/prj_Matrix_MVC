using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using matriz.Core.Domain.Entities;

namespace matriz.Infra.Data.EntitiesConfigurarion
{
    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {

            builder.HasKey(e => e.Id)
                .HasName("PK__tblender__3213E83F59063A47");

            builder.ToTable("tblEstado", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.Descricao)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nome");
            builder.Property(e => e.Sigla)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("uf");

        }
    }
}
