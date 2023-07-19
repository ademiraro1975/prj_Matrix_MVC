using matriz.Core.Domain.Entities.PontuacaoProfessor;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {

            builder.HasKey(e => e.Id).HasName("PK__tblprofe__3213E83F02FC7413");

            builder.ToTable("tblprofessor", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.Atribuicao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("atribuicao");
            builder.Property(e => e.FuncionarioCargoDepartamentoUnidadeId)
                .HasColumnName("idfuncionariocargodepartamentounidade");
            builder.Property(e => e.Observacao)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("observacao");
            builder.Property(e => e.RegistroDocente)
                .HasColumnName("registrodocente");

            builder.HasOne(d => d.FuncionarioCargoDepartamentoUnidade)
                .WithMany(p => p.Professores)
                .HasForeignKey(d => d.FuncionarioCargoDepartamentoUnidadeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblprofessor_tblfuncionariocargodepartamentounidade");

        }
    }
}
