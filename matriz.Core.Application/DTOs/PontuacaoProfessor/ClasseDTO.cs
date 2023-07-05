using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class ClasseDTO
    {
        public ClasseDTO(int id, int ano, int ciclo, string classeNome, int nivel, int numeroAlunos, string turma, int cursoUnidadeId, int periodoId)
        {
            Id = id;
            Ano = ano;
            Ciclo = ciclo;
            ClasseNome = classeNome;
            Nivel = nivel;
            NumeroAlunos = numeroAlunos;
            Turma = turma;
            CursoUnidadeId = cursoUnidadeId;
            PeriodoId = periodoId;
        }

        public int Id { get; private set; }
        public int Ano { get; private set; }
        public int Ciclo { get; private set; }
        public string ClasseNome { get; private set; } = string.Empty;
        public int Nivel { get; private set; }
        public int NumeroAlunos { get; private set; }
        public string Turma { get; private set; } = string.Empty;
        public int CursoUnidadeId { get; private set; }
        public int PeriodoId { get; private set; }


    }
}
