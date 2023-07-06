using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class Unidade
    {
        public int Id { get; private set; }
        public int CEPId { get; private set; }
        public string CNPJ { get; private set; } = string.Empty;
        public int Codigo { get; private set; }
        public string Decreto { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string EmailSecretariaUnidadeEscolar { get; set; } = string.Empty;
        public string Nome { get; private set; } = string.Empty;
        public string NomeAbreviado { get; private set; } = string.Empty;
        public string NomeCompleto { get; private set; } = string.Empty;
        public string EnderecoNumero { get; private set; } = string.Empty;
        public string Telefone { get; private set; } = string.Empty;

        public int EntidadeId { get; private set; }
        public int IdEndereco { get; private set; }

        //public Entidade Entidade { get; } = new Entidade();
        //public Endereco Endereco { get; } = new Endereco();

        public ICollection<CursoUnidade> CursoUnidades { get; } = new List<CursoUnidade>();
        public ICollection<DepartamentoUnidade> DepartamentoUnidades { get; } = new List<DepartamentoUnidade>();
        public ICollection<Parametro> Parametros { get; } = new List<Parametro>();
        public ICollection<UsuarioPermissao> UsuarioPermissaos { get; } = new List<UsuarioPermissao>();

        public Unidade()
        {
            CursoUnidades = new HashSet<CursoUnidade>();
            Parametros = new HashSet<Parametro>();
            DepartamentoUnidades = new HashSet<DepartamentoUnidade>();
            UsuarioPermissaos = new HashSet<UsuarioPermissao>();
        }
    }
}