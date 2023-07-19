using matriz.Core.Domain.Entities.PontuacaoProfessor;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class FundLegalConfiguration : IEntityTypeConfiguration<FundLegal>
    {
        public void Configure(EntityTypeBuilder<FundLegal> builder)
        {

            builder.HasKey(e => e.Id)
                .HasName("PK__tblfundl__3213E83FBF02791C");

            builder.ToTable("tblfundlegal", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.Fundlegal)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("fundlegal");

        }
    }
}
