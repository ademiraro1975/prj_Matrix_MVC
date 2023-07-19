using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using matriz.Core.Domain.Entities.PontuacaoProfessor;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class ClasseGrupoDisciplinaConfiguration : IEntityTypeConfiguration<ClasseGrupoDisciplina>
    {
        public void Configure(EntityTypeBuilder<ClasseGrupoDisciplina> builder)
        {

            builder.ToTable("tblclassegrupodisciplina", "dbo");

            builder.Property(e => e.Id)
                .HasColumnName("id");
            builder.Property(e => e.ClasseId)
                .HasColumnName("idclasse");
            builder.Property(e => e.GrupoDisciplinaId)
                .HasColumnName("idgrupodisciplina");

            builder.HasOne(d => d.Classe)
                .WithMany(p => p.ClasseGrupoDisciplinas)
                .HasForeignKey(d => d.ClasseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblclassegrupodisciplina_tblclasse");

            builder.HasOne(d => d.GrupoDisciplina)
                .WithMany(p => p.ClasseGrupoDisciplinas)
                .HasForeignKey(d => d.GrupoDisciplinaId)
                .HasConstraintName("FK_tblclassegrupodisciplina_tblgrupodisciplina");

        }
    }
}
