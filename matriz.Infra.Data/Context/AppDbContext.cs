

using matriz.Core.Domain.Entities.PontuacaoProfessor;
using matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace matriz.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public virtual DbSet<AreaConhecimento> AreaConhecimentos { get; set; }
        public virtual DbSet<Atribuicao> Atribuicaos { get; set; }
        public virtual DbSet<Cargo> Cargos { get; set; }
        public virtual DbSet<CargoDepartamentoUnidade> CargoDepartamentoUnidades { get; set; }
        public virtual DbSet<Classe> Classes { get; set; }
        public virtual DbSet<ClasseGrupoDisciplina> ClasseGrupoDisciplinas { get; set; }
        public virtual DbSet<Curso> Cursos { get; set; }
        public virtual DbSet<CursoArea> CursoAreas { get; set; }
        public virtual DbSet<CursoDisciplina> CursoDisciplinas { get; set; }
        public virtual DbSet<CursoHabilitacao> CursoHabilitacaos { get; set; }
        public virtual DbSet<CursoUnidade> CursoUnidades { get; set; }
        public virtual DbSet<CursoUnidadeFundLegal> CursoUnidadeFundLegals { get; set; }
        public virtual DbSet<CursoUnidadePeriodo> CursoUnidadePeriodos { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<DepartamentoUnidade> DepartamentoUnidades { get; set; }
        public virtual DbSet<Disciplina> Disciplinas { get; set; }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<FuncionarioCargoDepartamentoUnidade> FuncionarioCargoDepartamentoUnidades { get; set; }
        public virtual DbSet<FundLegal> FundLegals { get; set; }
        public virtual DbSet<GrupoDisciplina> GrupoDisciplinas { get; set; }
        public virtual DbSet<Habilitacao> Habilitacaos { get; set; }
        public virtual DbSet<LogSistema> LogSistemas { get; set; }
        public virtual DbSet<Modalidade> Modalidades { get; set; }
        public virtual DbSet<Operacao> Operacoes { get; set; }
        public virtual DbSet<Parametro> Parametros { get; set; }
        public virtual DbSet<Periodo> Periodos { get; set; }
        public virtual DbSet<Professor> Professor { get; set; }
        public virtual DbSet<Rotina> Rotinas { get; set; }
        public virtual DbSet<RotinaOperacao> RotinaOperacoes { get; set; }
        public virtual DbSet<Sistema> Sistemas { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Unidade> Unidades { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuarioPermissao> UsuarioPermissao { get; set; }
        public virtual DbSet<DetalheParametro> Detalheparametros { get; set; }
        public virtual DbSet<DetalhePontuacao> Detalhepontuacaos { get; set; }
        public virtual DbSet<MatriculaProfessor> Matriculaprofessors { get; set; }
        public virtual DbSet<OperacaoParametro> Operacaoparametros { get; set; }
        public virtual DbSet<Pontuacao> Pontuacaos { get; set; }
        public virtual DbSet<ProcessoAtribuicao> ProcessoAtribuicaos { get; set; }
        public virtual DbSet<TipoParametro> TipoParametros { get; set; }
        public virtual DbSet<UnidadeParametro> Unidadeparametros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.UseCollation("Latin1_General_CI_AI");
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);


        }

    }
}
