using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using matriz.Core.Domain.Entities;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {

            builder.ToTable("tblfuncionario", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");

            builder.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo");

            builder.Property(e => e.CPF)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("cpf");

            builder.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");

            builder.Property(e => e.FotoUrl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('https://stgwebfiebbrs001.blob.core.windows.net/foto/f519f0b8-2f0a-4379-8cc0-10b8dc8e7c5b.jpg')")
                .HasColumnName("foto_url");

            builder.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");

            builder.Property(e => e.RG)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("rg");

        }
    }
}
