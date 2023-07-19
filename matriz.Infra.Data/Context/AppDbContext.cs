using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Entities.PontuacaoProfessor;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace matriz.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public virtual DbSet<AreaConhecimentoConfigurarion> AreaConhecimentos { get; set; }
        public virtual DbSet<AtribuicaoConfigurarion> Atribuicaos { get; set; }
        public virtual DbSet<CargoConfigurarion> Cargos { get; set; }
        public virtual DbSet<CargoDepartamentoUnidadeConfigurarion> CargoDepartamentoUnidades { get; set; }
        public virtual DbSet<ClasseConfigurarion> Classes { get; set; }
        public virtual DbSet<ClasseGrupoDisciplinaConfigurarion> ClasseGrupoDisciplinas { get; set; }
        public virtual DbSet<CursoConfigurarion> Cursos { get; set; }
        public virtual DbSet<CursoAreaConfigurarion> CursoAreas { get; set; }
        public virtual DbSet<CursoDisciplinaConfigurarion> CursoDisciplinas { get; set; }
        public virtual DbSet<CursoHabilitacaoConfigurarion> CursoHabilitacaos { get; set; }
        public virtual DbSet<CursoUnidadeConfigurarion> CursoUnidades { get; set; }
        public virtual DbSet<CursoUnidadeFundLegalConfigurarion> CursoUnidadeFundLegals { get; set; }
        public virtual DbSet<CursoUnidadePeriodoConfigurarion> CursoUnidadePeriodos { get; set; }
        public virtual DbSet<DepartamentoConfigurarion> Departamentos { get; set; }
        public virtual DbSet<DepartamentoUnidadeConfigurarion> DepartamentoUnidades { get; set; }
        public virtual DbSet<DetalheParametroConfigurarion> DetalheParametros { get; set; }
        public virtual DbSet<DetalhePontuacaoConfigurarion> DetalhePontuacaos { get; set; }
        public virtual DbSet<DisciplinaConfigurarion> Disciplinas { get; set; }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<FuncionarioCargoDepartamentoUnidadeConfigurarion> FuncionarioCargoDepartamentoUnidades { get; set; }
        public virtual DbSet<FuncionarioPermissaoConfigurarion> FuncionarioPermissaos { get; set; }
        public virtual DbSet<FundLegalConfigurarion> FundLegals { get; set; }
        public virtual DbSet<GrupoDisciplinaConfigurarion> GrupoDisciplinas { get; set; }
        public virtual DbSet<HabilitacaoConfigurarion> Habilitacaos { get; set; }
        public virtual DbSet<LogSistemaConfigurarion> LogSistemas { get; set; }
        public virtual DbSet<MatriculaProfessorConfigurarion> MatriculaProfessors { get; set; }
        public virtual DbSet<ModalidadeConfigurarion> Modalidades { get; set; }
        public virtual DbSet<OperacaoConfigurarion> Operacaos { get; set; }
        public virtual DbSet<OperacaoParametroConfigurarion> OperacaoParametros { get; set; }
        public virtual DbSet<ParametroConfigurarion> Parametros { get; set; }
        public virtual DbSet<PeriodoConfigurarion> Periodos { get; set; }
        public virtual DbSet<PontuacaoConfigurarion> Pontuacaos { get; set; }
        public virtual DbSet<ProcessoAtribuicaoConfigurarion> ProcessoAtribuicaos { get; set; }
        public virtual DbSet<ProfessorConfigurarion> Professors { get; set; }
        public virtual DbSet<RotinaConfigurarion> Rotinas { get; set; }
        public virtual DbSet<RotinaOperacaoConfigurarion> RotinaOperacaos { get; set; }
        public virtual DbSet<SistemaConfigurarion> Sistemas { get; set; }
        public virtual DbSet<TipoAcessoConfigurarion> TipoAcessos { get; set; }
        public virtual DbSet<TipoParametroConfigurarion> TipoParametros { get; set; }
        public virtual DbSet<TipoUsuarioConfigurarion> TipoUsuarios { get; set; }
        public virtual DbSet<UnidadeConfigurarion> Unidades { get; set; }
        public virtual DbSet<UnidadeParametroConfigurarion> UnidadeParametros { get; set; }
        public virtual DbSet<UsuarioConfigurarion> Usuarios { get; set; }
        public virtual DbSet<UsuarioPermissaoConfigurarion> UsuarioPermissaos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.UseCollation("Latin1_General_CI_AI");
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        }

    }
}
