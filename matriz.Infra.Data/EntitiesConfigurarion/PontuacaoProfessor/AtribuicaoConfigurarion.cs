using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public class AreaConhecimentoConfiguration : IEntityTypeConfiguration<AreaConhecimento>
    {
        public void Configure(EntityTypeBuilder<AreaConhecimento> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__tblareac__3213E83F32E0915F");

            builder.ToTable("tblareaconhecimento", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.Descricao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descricao");

        }
    }
}
