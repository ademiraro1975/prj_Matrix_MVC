using matriz.Core.Domain.Entities.PontuacaoProfessor;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class TipoUsuarioConfiguration : IEntityTypeConfiguration<TipoUsuario>
    {
        public void Configure(EntityTypeBuilder<TipoUsuario> builder)
        {

            builder.HasKey(e => e.Id);

            builder.ToTable("tipousuario", "acesso");

            builder.Property(e => e.Id)
                .HasColumnName("idtipousuario");
            builder.Property(e => e.Descricao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descricao");
            builder.Property(e => e.Hierarquia)
                .HasColumnName("hierarquia");
            builder.Property(e => e.Nomenclatura)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nomenclatura");

        }
    }
}
