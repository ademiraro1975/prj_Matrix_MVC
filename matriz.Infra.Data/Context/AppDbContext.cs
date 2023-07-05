﻿using matriz.Core.Domain.Entities;
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
        public virtual DbSet<DetalheParametro> DetalheParametros { get; set; }
        public virtual DbSet<DetalhePontuacao> DetalhePontuacaos { get; set; }
        public virtual DbSet<Disciplina> Disciplinas { get; set; }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<FuncionarioCargoDepartamentoUnidade> FuncionarioCargoDepartamentoUnidades { get; set; }
        public virtual DbSet<FuncionarioPermissao> FuncionarioPermissaos { get; set; }
        public virtual DbSet<FundLegal> FundLegals { get; set; }
        public virtual DbSet<GrupoDisciplina> GrupoDisciplinas { get; set; }
        public virtual DbSet<Habilitacao> Habilitacaos { get; set; }
        public virtual DbSet<LogSistema> LogSistemas { get; set; }
        public virtual DbSet<MatriculaProfessor> MatriculaProfessors { get; set; }
        public virtual DbSet<Modalidade> Modalidades { get; set; }
        public virtual DbSet<Operacao> Operacaos { get; set; }
        public virtual DbSet<OperacaoParametro> OperacaoParametros { get; set; }
        public virtual DbSet<Parametro> Parametros { get; set; }
        public virtual DbSet<Periodo> Periodos { get; set; }
        public virtual DbSet<Pontuacao> Pontuacaos { get; set; }
        public virtual DbSet<ProcessoAtribuicao> ProcessoAtribuicaos { get; set; }
        public virtual DbSet<Professor> Professors { get; set; }
        public virtual DbSet<Rotina> Rotinas { get; set; }
        public virtual DbSet<RotinaOperacao> RotinaOperacaos { get; set; }
        public virtual DbSet<Sistema> Sistemas { get; set; }
        public virtual DbSet<TipoAcesso> TipoAcessos { get; set; }
        public virtual DbSet<TipoParametro> TipoParametros { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Unidade> Unidades { get; set; }
        public virtual DbSet<UnidadeParametro> UnidadeParametros { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuarioPermissao> UsuarioPermissaos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.UseCollation("Latin1_General_CI_AI");
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        }

    }
}
