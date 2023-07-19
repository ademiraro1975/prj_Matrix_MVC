using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using matriz.Core.Domain.Entities.PontuacaoProfessor;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class CursoDisciplinaConfiguration : IEntityTypeConfiguration<CursoDisciplina>
    {
        public void Configure(EntityTypeBuilder<CursoDisciplina> builder)
        {

            builder.HasKey(e => e.Id).HasName("PK__tblcurso__3213E83F06CD04F7");

            builder.ToTable("tblcursodisciplina", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.CursoId)
                .HasColumnName("idcurso");
            builder.Property(e => e.DisciplinaId)
                .HasColumnName("iddisciplina");

            builder.HasOne(d => d.Curso)
                .WithMany(p => p.CursoDisciplinas)
                .HasForeignKey(d => d.CursoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblcursodisciplina_tblcurso");

            builder.HasOne(d => d.Disciplina)
                .WithMany(p => p.CursoDisciplinas)
                .HasForeignKey(d => d.DisciplinaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblcursodisciplina_tbldisciplina");

        }
    }
}

