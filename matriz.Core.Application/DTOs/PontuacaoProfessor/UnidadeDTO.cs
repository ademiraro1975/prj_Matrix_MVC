using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class UnidadeDTO
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

        public Entidade Entidade { get; } = new Entidade();
        public Endereco Endereco { get; } = new Endereco();

        public ICollection<CursoUnidadeDTO> CursoUnidades { get; } = new List<CursoUnidadeDTO>();
        public ICollection<DepartamentoUnidadeDTO> DepartamentoUnidades { get; } = new List<DepartamentoUnidadeDTO>();
        public ICollection<Ingressante> Ingressantes { get; } = new List<Ingressante>();
        public ICollection<ParametroDTO> Parametros { get; } = new List<ParametroDTO>();
        public ICollection<UsuarioPermissaoDTO> UsuarioPermissaos { get; } = new List<UsuarioPermissaoDTO>();

        public UnidadeDTO()
        {
            Ingressantes = new HashSet<Ingressante>();
            CursoUnidades = new HashSet<CursoUnidadeDTO>();
            Parametros = new HashSet<ParametroDTO>();
            DepartamentoUnidades = new HashSet<DepartamentoUnidadeDTO>();
            UsuarioPermissaos = new HashSet<UsuarioPermissaoDTO>();
        }
    }
}