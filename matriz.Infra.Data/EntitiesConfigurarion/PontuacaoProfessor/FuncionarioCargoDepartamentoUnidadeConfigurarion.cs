using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class FuncionarioCargoDepartamentoUnidadeConfigurarion
    {

        public int Id { get; private set; }
        public bool Ativo { get; private set; } = false;
        public string Emaildocente { get; private set; } = string.Empty;
        public long Matricula { get; private set; }
        public bool SegundoCargo { get; private set; } = false;


        public int AtribuicaoId { get; private set; }
        public int FuncionarioId { get; private set; }
        public int CargoDepartamentoUnidadeId { get; set; }


        public AtribuicaoConfigurarion Atribuicao { get; } = new AtribuicaoConfigurarion();
        public CargoDepartamentoUnidadeConfigurarion CargoDepartamentoUnidade { get; } = new CargoDepartamentoUnidadeConfigurarion();
        public Funcionario Funcionario { get; } = new Funcionario();

        public ICollection<ProfessorConfigurarion> Professores { get; } = new List<ProfessorConfigurarion>();

        public FuncionarioCargoDepartamentoUnidadeConfigurarion()
        {
            Professores = new HashSet<ProfessorConfigurarion>();
        }
    }
}
