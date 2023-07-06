using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class PeriodoDTO
    {
        public PeriodoDTO(int id, DateTime horaFim, DateTime horaInicio, string nome, string sigla)
        {
            Id = id;
            HoraFim = horaFim;
            HoraInicio = horaInicio;
            Nome = nome;
            Sigla = sigla;
        }

        public int Id { get; private set; }
        public DateTime HoraFim { get; private set; }
        public DateTime HoraInicio { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public string Sigla { get; private set; } = string.Empty;


    }
}
