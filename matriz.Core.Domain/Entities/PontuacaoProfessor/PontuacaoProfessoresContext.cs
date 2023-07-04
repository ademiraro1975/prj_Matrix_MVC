using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace matriz.Core.Domain.Entities
{

    public partial class PontuacaoProfessoresContext : DbContext
    {
        public PontuacaoProfessoresContext()
        {
        }

        public PontuacaoProfessoresContext(DbContextOptions<PontuacaoProfessoresContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Auditoria> TblAuditoria { get; set; }

        public virtual DbSet<TblCargo> TblCargos { get; set; }

        public virtual DbSet<TblCursoArea> TblCursoAreas { get; set; }

        public virtual DbSet<TblDetParam> TblDetParams { get; set; }

        public virtual DbSet<TblDetalhePontuacao> TblDetalhePontuacaos { get; set; }

        public virtual DbSet<TblMatriculaProfessor> TblMatriculaProfessors { get; set; }

        public virtual DbSet<TblOperacaoParametro> TblOperacaoParametros { get; set; }

        public virtual DbSet<TblParametro> TblParametros { get; set; }

        public virtual DbSet<TblPontuacao> TblPontuacaos { get; set; }

        public virtual DbSet<TblProcessoAtrib> TblProcessoAtribs { get; set; }

        public virtual DbSet<TblProfessor> TblProfessors { get; set; }

        public virtual DbSet<TblTipoAcesso> TblTipoAcessos { get; set; }

        public virtual DbSet<TblTipoParametro> TblTipoParametros { get; set; }

        public virtual DbSet<TblUnidParametro> TblUnidParametros { get; set; }

        public virtual DbSet<TblUnidade> TblUnidades { get; set; }

        public virtual DbSet<TblUnidadeUsuario> TblUnidadeUsuarios { get; set; }

        public virtual DbSet<TblUsuario> TblUsuarios { get; set; }

        public virtual DbSet<ViewDado> ViewDados { get; set; }

        public virtual DbSet<ViewPontuacao> ViewPontuacaos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Server=172.16.4.122;Database=PontuacaoProfessores;Trusted_Connection=True;TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auditoria>(entity =>
            {
                entity.HasKey(e => e.IdAuditoria).HasName("pk_id_auditoria");

                entity.ToTable("tbl_Auditoria");

                entity.Property(e => e.IdAuditoria).HasColumnName("id_auditoria");
                entity.Property(e => e.Browser)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("browser");
                entity.Property(e => e.DataHora)
                    .HasColumnType("datetime")
                    .HasColumnName("data_hora");
                entity.Property(e => e.Detalhes)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("detalhes");
                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
                entity.Property(e => e.Ip)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ip");
            });

            modelBuilder.Entity<TblCargo>(entity =>
            {
                entity.HasKey(e => e.IdCargo).HasName("pk_id_Cargo");

                entity.ToTable("tbl_Cargo");

                entity.Property(e => e.IdCargo).HasColumnName("id_Cargo");
                entity.Property(e => e.DescricaoCargo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descricao_cargo");
            });

            modelBuilder.Entity<TblCursoArea>(entity =>
            {
                entity.HasKey(e => e.IdCursoArea).HasName("pk_id_curso_area");

                entity.ToTable("tbl_Curso_Area");

                entity.Property(e => e.IdCursoArea).HasColumnName("id_curso_area");
                entity.Property(e => e.DescricaoCursoArea)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("descricao_curso_area");
            });

            modelBuilder.Entity<TblDetParam>(entity =>
            {
                entity.HasKey(e => e.CodigoDetParam).HasName("pk_codigo_det_param");

                entity.ToTable("tbl_Det_Param");

                entity.Property(e => e.CodigoDetParam).HasColumnName("codigo_det_param");
                entity.Property(e => e.CodigoOperacaoParam).HasColumnName("codigo_operacao_param");
                entity.Property(e => e.CodigoParam).HasColumnName("codigo_param");
                entity.Property(e => e.CodigoProcessoAtrib).HasColumnName("codigo_processo_atrib");
                entity.Property(e => e.CodigoTipoParam).HasColumnName("codigo_tipo_param");
                entity.Property(e => e.DataAlteracaoParam)
                    .HasColumnType("date")
                    .HasColumnName("data_alteracao_param");
                entity.Property(e => e.LimiteParam)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("limite_param");
                entity.Property(e => e.UnidadeParam)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("unidade_param");
                entity.Property(e => e.ValorParam)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("valor_param");

                entity.HasOne(d => d.CodigoParamNavigation).WithMany(p => p.TblDetParams)
                    .HasForeignKey(d => d.CodigoParam)
                    .HasConstraintName("fk_codigo_param");

                entity.HasOne(d => d.CodigoProcessoAtribNavigation).WithMany(p => p.TblDetParams)
                    .HasForeignKey(d => d.CodigoProcessoAtrib)
                    .HasConstraintName("fk_codigo_processo_atrib");
            });

            modelBuilder.Entity<TblDetalhePontuacao>(entity =>
            {
                entity.HasKey(e => e.CodigoControlePont).HasName("pk_codigo_controle_pont");

                entity.ToTable("tbl_Detalhe_Pontuacao");

                entity.Property(e => e.CodigoControlePont).HasColumnName("codigo_controle_pont");
                entity.Property(e => e.CodigoParamPont).HasColumnName("codigo_param_pont");
                entity.Property(e => e.CodigoPont).HasColumnName("codigo_pont");
                entity.Property(e => e.DataConclusao)
                    .HasColumnType("date")
                    .HasColumnName("data_conclusao");
                entity.Property(e => e.QuantidadeDias).HasColumnName("quantidade_dias");
                entity.Property(e => e.QuantidadeDiasAnt).HasColumnName("quantidade_dias_ant");
                entity.Property(e => e.QuantidadePont)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("quantidade_pont");
                entity.Property(e => e.QuantidadePontAnt)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("quantidade_pont_ant");
                entity.Property(e => e.TipoPont)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("tipo_pont");
            });

            modelBuilder.Entity<TblMatriculaProfessor>(entity =>
            {
                entity.HasKey(e => e.MatriculaProfessor).HasName("pk_matricula_professor");

                entity.ToTable("tbl_Matricula_Professor");

                entity.Property(e => e.MatriculaProfessor)
                    .ValueGeneratedNever()
                    .HasColumnName("matricula_professor");
                entity.Property(e => e.Cargo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("cargo");
                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("cpf");
                entity.Property(e => e.CursoAreaFieb)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("curso_area_fieb");
                entity.Property(e => e.DataAdmissao)
                    .HasColumnType("date")
                    .HasColumnName("data_admissao");
                entity.Property(e => e.DataAdmissaoFieb)
                    .HasColumnType("date")
                    .HasColumnName("data_admissao_fieb");
                entity.Property(e => e.Formacao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("formacao");
                entity.Property(e => e.IdCursoArea).HasColumnName("id_curso_area");
                entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
                entity.Property(e => e.ListaClassificacaoGeral)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("lista_classificacao_geral");
                entity.Property(e => e.ListaClassificacaoUnid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("lista_classificacao_unid");
                entity.Property(e => e.SituacaoFuncional)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("situacao_funcional");
            });

            modelBuilder.Entity<TblOperacaoParametro>(entity =>
            {
                entity.HasKey(e => e.IdOperacaoParam).HasName("pk_id_Operacao_paran");

                entity.ToTable("tbl_Operacao_Parametro");

                entity.Property(e => e.IdOperacaoParam).HasColumnName("id_Operacao_param");
                entity.Property(e => e.DescricaoOperacaoAcesso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descricao_Operacao_acesso");
            });

            modelBuilder.Entity<TblParametro>(entity =>
            {
                entity.HasKey(e => e.CodigoParam).HasName("pk_codigo_param");

                entity.ToTable("tbl_Parametro");

                entity.Property(e => e.CodigoParam).HasColumnName("codigo_param");
                entity.Property(e => e.CodigoTipoParam).HasColumnName("codigo_tipo_param");
                entity.Property(e => e.DescricaoParam)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descricao_param");
            });

            modelBuilder.Entity<TblPontuacao>(entity =>
            {
                entity.HasKey(e => e.CodigoPont).HasName("pk_codigo_pont");

                entity.ToTable("tbl_Pontuacao");

                entity.Property(e => e.CodigoPont).HasColumnName("codigo_pont");
                entity.Property(e => e.CodigoProcessoAtribPont).HasColumnName("codigo_processo_atrib_pont");
                entity.Property(e => e.DeducoesPont)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("deducoes_pont");
                entity.Property(e => e.MatriculaProfPont).HasColumnName("matricula_prof_pont");
                entity.Property(e => e.PontuacaoEscolaPont)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("pontuacao_escola_pont");
                entity.Property(e => e.PontuacaoFiebPont)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("pontuacao_fieb_pont");
                entity.Property(e => e.TituloPont)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("titulo_pont");
            });

            modelBuilder.Entity<TblProcessoAtrib>(entity =>
            {
                entity.HasKey(e => e.CodigoProcessoAtrib).HasName("pk_codigo_processo_atrib");

                entity.ToTable("tbl_Processo_Atrib");

                entity.Property(e => e.CodigoProcessoAtrib).HasColumnName("codigo_processo_atrib");
                entity.Property(e => e.Ativo)
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasColumnName("ativo");
                entity.Property(e => e.DataFimProcessoAtrib)
                    .HasColumnType("date")
                    .HasColumnName("data_fim_processo_atrib");
                entity.Property(e => e.DataInicioProcessoAtrib)
                    .HasColumnType("date")
                    .HasColumnName("data_inicio_processo_atrib");
                entity.Property(e => e.DescricaoProcessoAtrib)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("descricao_processo_atrib");
                entity.Property(e => e.ObservacoesProcessoAtrib)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("observacoes_processo_atrib");
                entity.Property(e => e.PortariaProcessoAtrib)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("portaria_processo_atrib");
            });

            modelBuilder.Entity<TblProfessor>(entity =>
            {
                entity.HasKey(e => e.Cpf).HasName("pk_cpf");

                entity.ToTable("tbl_Professor");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("cpf");
                entity.Property(e => e.DataNascimento)
                    .HasColumnType("date")
                    .HasColumnName("data_nascimento");
                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");
                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nome");
                entity.Property(e => e.NumDependentes).HasColumnName("num_dependentes");
                entity.Property(e => e.Rg)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("rg");
            });

            modelBuilder.Entity<TblTipoAcesso>(entity =>
            {
                entity.HasKey(e => e.IdTipoAcesso).HasName("pk_id_tipo_acesso");

                entity.ToTable("tbl_Tipo_Acesso");

                entity.Property(e => e.IdTipoAcesso).HasColumnName("id_tipo_acesso");
                entity.Property(e => e.DescricaoTipoAcesso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descricao_tipo_acesso");
            });

            modelBuilder.Entity<TblTipoParametro>(entity =>
            {
                entity.HasKey(e => e.IdTipoParam).HasName("pk_id_tipo_paran");

                entity.ToTable("tbl_Tipo_Parametro");

                entity.Property(e => e.IdTipoParam).HasColumnName("id_tipo_param");
                entity.Property(e => e.AvrevTipoAcesso)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("avrev_tipo_acesso");
                entity.Property(e => e.DescricaoTipoAcesso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descricao_tipo_acesso");
            });

            modelBuilder.Entity<TblUnidParametro>(entity =>
            {
                entity.HasKey(e => e.IdUnidParam).HasName("pk_id_Unid_paran");

                entity.ToTable("tbl_Unid_Parametro");

                entity.Property(e => e.IdUnidParam).HasColumnName("id_Unid_param");
                entity.Property(e => e.DescricaoUnidAcesso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descricao_Unid_acesso");
            });

            modelBuilder.Entity<TblUnidade>(entity =>
            {
                entity.HasKey(e => e.IdUnidade).HasName("pk_id_unidade");

                entity.ToTable("tbl_Unidade");

                entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
                entity.Property(e => e.Bairro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bairro");
                entity.Property(e => e.Cidade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cidade");
                entity.Property(e => e.Endereco)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("endereco");
                entity.Property(e => e.Numero).HasColumnName("numero");
                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("uf");
                entity.Property(e => e.Unidade)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("unidade");
            });

            modelBuilder.Entity<TblUnidadeUsuario>(entity =>
            {
                entity.HasKey(e => e.IdUnidadeUsuario).HasName("pk_id_unidade_usuario");

                entity.ToTable("tbl_Unidade_Usuario");

                entity.Property(e => e.IdUnidadeUsuario).HasColumnName("id_unidade_usuario");
                entity.Property(e => e.IdUnidadeU).HasColumnName("id_unidade_u");
                entity.Property(e => e.IdUsuarioU).HasColumnName("id_usuario_u");

                entity.HasOne(d => d.IdUnidadeUNavigation).WithMany(p => p.TblUnidadeUsuarios)
                    .HasForeignKey(d => d.IdUnidadeU)
                    .HasConstraintName("fk_id_unidade_u");

                entity.HasOne(d => d.IdUsuarioUNavigation).WithMany(p => p.TblUnidadeUsuarios)
                    .HasForeignKey(d => d.IdUsuarioU)
                    .HasConstraintName("fk_id_usuario_u");
            });

            modelBuilder.Entity<TblUsuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario).HasName("pk_id_usuario");

                entity.ToTable("tbl_Usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
                entity.Property(e => e.Ativo).HasColumnName("ativo");
                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");
                entity.Property(e => e.IdTipoAcesso).HasColumnName("id_tipo_acesso");
                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nome");
                entity.Property(e => e.Senha)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("senha");
                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.IdTipoAcessoNavigation).WithMany(p => p.TblUsuarios)
                    .HasForeignKey(d => d.IdTipoAcesso)
                    .HasConstraintName("fk_id_tipo_acesso");
            });

            modelBuilder.Entity<ViewDado>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Dados");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bairro");
                entity.Property(e => e.Cargo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("cargo");
                entity.Property(e => e.Cidade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cidade");
                entity.Property(e => e.CodigoControlePont).HasColumnName("codigo_controle_pont");
                entity.Property(e => e.CodigoDetParam).HasColumnName("codigo_det_param");
                entity.Property(e => e.CodigoParam).HasColumnName("codigo_param");
                entity.Property(e => e.CodigoParamPont).HasColumnName("codigo_param_pont");
                entity.Property(e => e.CodigoPont).HasColumnName("codigo_pont");
                entity.Property(e => e.CodigoProcessoAtrib).HasColumnName("codigo_processo_atrib");
                entity.Property(e => e.CodigoProcessoAtribPont).HasColumnName("codigo_processo_atrib_pont");
                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("cpf");
                entity.Property(e => e.CursoAreaFieb)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("curso_area_fieb");
                entity.Property(e => e.DataAdmissao)
                    .HasColumnType("date")
                    .HasColumnName("data_admissao");
                entity.Property(e => e.DataAdmissaoFieb)
                    .HasColumnType("date")
                    .HasColumnName("data_admissao_fieb");
                entity.Property(e => e.DataAlteracaoParam)
                    .HasColumnType("date")
                    .HasColumnName("data_alteracao_param");
                entity.Property(e => e.DataFimProcessoAtrib)
                    .HasColumnType("date")
                    .HasColumnName("data_fim_processo_atrib");
                entity.Property(e => e.DataInicioProcessoAtrib)
                    .HasColumnType("date")
                    .HasColumnName("data_inicio_processo_atrib");
                entity.Property(e => e.DataNascimento)
                    .HasColumnType("date")
                    .HasColumnName("data_nascimento");
                entity.Property(e => e.DeducoesPont)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("deducoes_pont");
                entity.Property(e => e.DescricaoCursoArea)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("descricao_curso_area");
                entity.Property(e => e.DescricaoParam)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descricao_param");
                entity.Property(e => e.DescricaoProcessoAtrib)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("descricao_processo_atrib");
                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");
                entity.Property(e => e.Endereco)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("endereco");
                entity.Property(e => e.Expr3)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.Formacao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("formacao");
                entity.Property(e => e.IdCursoArea).HasColumnName("id_curso_area");
                entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
                entity.Property(e => e.ListaClassificacaoGeral)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("lista_classificacao_geral");
                entity.Property(e => e.ListaClassificacaoUnid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("lista_classificacao_unid");
                entity.Property(e => e.MatriculaProfPont).HasColumnName("matricula_prof_pont");
                entity.Property(e => e.MatriculaProfessor).HasColumnName("matricula_professor");
                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nome");
                entity.Property(e => e.NumDependentes).HasColumnName("num_dependentes");
                entity.Property(e => e.Numero).HasColumnName("numero");
                entity.Property(e => e.ObservacoesProcessoAtrib)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("observacoes_processo_atrib");
                entity.Property(e => e.PontuacaoEscolaPont)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("pontuacao_escola_pont");
                entity.Property(e => e.PontuacaoFiebPont)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("pontuacao_fieb_pont");
                entity.Property(e => e.PortariaProcessoAtrib)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("portaria_processo_atrib");
                entity.Property(e => e.QuantidadeDias).HasColumnName("quantidade_dias");
                entity.Property(e => e.QuantidadePont)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("quantidade_pont");
                entity.Property(e => e.Rg)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("rg");
                entity.Property(e => e.SituacaoFuncional)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("situacao_funcional");
                entity.Property(e => e.TipoPont)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("tipo_pont");
                entity.Property(e => e.TituloPont)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("titulo_pont");
                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("uf");
                entity.Property(e => e.Unidade)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("unidade");
                entity.Property(e => e.ValorParam)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("valor_param");
            });

            modelBuilder.Entity<ViewPontuacao>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Pontuacao");

                entity.Property(e => e.CodigoProcessoAtribPont).HasColumnName("codigo_processo_atrib_pont");
                entity.Property(e => e.CursoAreaFieb)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("curso_area_fieb");
                entity.Property(e => e.DescricaoCursoArea)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("descricao_curso_area");
                entity.Property(e => e.ListaClassificacaoGeral)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("lista_classificacao_geral");
                entity.Property(e => e.ListaClassificacaoUnid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("lista_classificacao_unid");
                entity.Property(e => e.MatriculaProfessor).HasColumnName("matricula_professor");
                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nome");
                entity.Property(e => e.PontuacaoEscolaPont)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("pontuacao_escola_pont");
                entity.Property(e => e.PontuacaoFiebPont)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("pontuacao_fieb_pont");
                entity.Property(e => e.Unidade)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("unidade");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}