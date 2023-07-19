using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class UnidadeConfigurarion
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

        public ICollection<CursoUnidadeConfigurarion> CursoUnidades { get; } = new List<CursoUnidadeConfigurarion>();
        public ICollection<DepartamentoUnidadeConfigurarion> DepartamentoUnidades { get; } = new List<DepartamentoUnidadeConfigurarion>();
        public ICollection<ParametroConfigurarion> Parametros { get; } = new List<ParametroConfigurarion>();
        public ICollection<UsuarioPermissaoConfigurarion> UsuarioPermissaos { get; } = new List<UsuarioPermissaoConfigurarion>();

        public UnidadeConfigurarion()
        {
            CursoUnidades = new HashSet<CursoUnidadeConfigurarion>();
            Parametros = new HashSet<ParametroConfigurarion>();
            DepartamentoUnidades = new HashSet<DepartamentoUnidadeConfigurarion>();
            UsuarioPermissaos = new HashSet<UsuarioPermissaoConfigurarion>();
        }
    }
}