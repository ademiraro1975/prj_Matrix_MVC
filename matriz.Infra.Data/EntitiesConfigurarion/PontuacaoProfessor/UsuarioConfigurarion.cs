using matriz.Core.Domain.Entities.PontuacaoProfessor;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {

            builder.HasKey(e => e.Id);

            builder.ToTable("usuario", "acesso");

            builder.Property(e => e.Id)
                .HasColumnName("idusuario");
            builder.Property(e => e.FuncionarioId)
                .HasColumnName("idfuncionario");
            builder.Property(e => e.TipoUsuarioId)
                .HasColumnName("idtipousuario");

            builder.HasOne(d => d.Funcionario)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.FuncionarioId)
                .HasConstraintName("FK_usuario_funcionario");

            builder.HasOne(d => d.TipoUsuario)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.TipoUsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_usuario_tipousuario");

        }
    }
}
