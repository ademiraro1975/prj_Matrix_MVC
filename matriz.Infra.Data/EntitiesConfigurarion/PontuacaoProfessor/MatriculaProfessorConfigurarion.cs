using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using matriz.Core.Domain.Entities.PontuacaoProfessor;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class MatriculaProfessorConfigurarion : IEntityTypeConfiguration<MatriculaProfessor>
    {
        public void Configure(EntityTypeBuilder<MatriculaProfessor> builder)
        {
            builder.HasKey(e => e.idmatriculaprofessor)
                .HasName("PK_idmatriculaprofessor");

            builder.ToTable("matriculaprofessor", "pontuacaop");

            builder.Property(e => e.idmatriculaprofessor)
                .HasColumnName("idmatriculaprofessor");
            builder.Property(e => e.Cargo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cargo");
            builder.Property(e => e.CursoAreaFieb)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("curso_area_fieb");
            builder.Property(e => e.DataAdmissao)
                .HasColumnType("date")
                .HasColumnName("data_admissao");
            builder.Property(e => e.DataAdmissaoFieb)
                .HasColumnType("date")
                .HasColumnName("data_admissao_fieb");
            builder.Property(e => e.Formacao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("formacao");
            builder.Property(e => e.idcursoarea)
                .HasColumnName("idcursoarea");
            builder.Property(e => e.idprofessor)
                .HasColumnName("idprofessor");
            builder.Property(e => e.ListaClassificacaoGeral)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("lista_classificacao_geral");
            builder.Property(e => e.ListaClassificacaoUnidade)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("lista_classificacao_unid");
            builder.Property(e => e.SituacaoFuncional)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("situacao_funcional");
        }
    }
}

