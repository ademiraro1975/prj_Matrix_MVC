using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class FuncionarioCargoDepartamentoUnidadeDTO
    {

        public int Id { get; private set; }
        public bool Ativo { get; private set; } = false;
        public string Emaildocente { get; private set; } = string.Empty;
        public long Matricula { get; private set; }
        public bool SegundoCargo { get; private set; } = false;


        public int AtribuicaoId { get; private set; }
        public int FuncionarioId { get; private set; }
        public int CargoDepartamentoUnidadeId { get; set; }


        public AtribuicaoDTO Atribuicao { get; } = new AtribuicaoDTO();
        public CargoDepartamentoUnidadeDTO CargoDepartamentoUnidade { get; } = new CargoDepartamentoUnidadeDTO();
        public Funcionario Funcionario { get; } = new Funcionario();

        public ICollection<ProfessorDTO> Professores { get; } = new List<ProfessorDTO>();

        public FuncionarioCargoDepartamentoUnidadeDTO()
        {
            Professores = new HashSet<ProfessorDTO>();
        }
    }
}
