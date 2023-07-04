using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class FuncionarioCargoDepartamentoUnidade
    {

        public int Id { get; private set; }
        public bool Ativo { get; private set; } = false;
        public string Emaildocente { get; private set; } = string.Empty;
        public long Matricula { get; private set; }
        public bool SegundoCargo { get; private set; } = false;


        public int AtribuicaoId { get; private set; }
        public int FuncionarioId { get; private set; }
        public int CargoDepartamentoUnidadeId { get; set; }


        public Atribuicao Atribuicao { get; } = new Atribuicao();
        public CargoDepartamentoUnidade CargoDepartamentoUnidade { get; } = new CargoDepartamentoUnidade();
        public Funcionario Funcionario { get; } = new Funcionario();

        public ICollection<Professor> Professores { get; } = new List<Professor>();

        public FuncionarioCargoDepartamentoUnidade()
        {
            Professores = new HashSet<Professor>();
        }
    }
}
