using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class Sistema
    {

        public int Id { get;private set; }
        public string Descricao { get;private set; } = string.Empty;
        public string Nomenclatura { get; private set; } = string.Empty;

        public ICollection<LogSistema> LogSistemas { get; } = new List<LogSistema>();
        public ICollection<Rotina> Rotinas { get; } = new List<Rotina>();
        public Sistema()
        {
            LogSistemas = new HashSet<LogSistema>();
            Rotinas = new HashSet<Rotina>();
        }
    }
}
