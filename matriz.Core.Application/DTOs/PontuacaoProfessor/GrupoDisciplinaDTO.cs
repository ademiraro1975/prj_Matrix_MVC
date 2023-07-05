﻿using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class GrupoDisciplinaDTO
    {

        public int Id { get; private set; }
        public string Descricao { get; private set; } = string.Empty;
        public string Tipo { get; private set; } = string.Empty;

        //public  ICollection<CursoDisciplinaCargaHoraria> CursoDisciplinaCargaHorarias { get; } = new List<CursoDisciplinaCargaHoraria>();
        public ICollection<ClasseGrupoDisciplinaDTO> ClasseGrupoDisciplinas { get; } = new List<ClasseGrupoDisciplinaDTO>();

        public GrupoDisciplinaDTO()
        {
            //CursoDisciplinaCargaHorarias = new HashSet<CursoDisciplinaCargaHoraria>();
            ClasseGrupoDisciplinas = new HashSet<ClasseGrupoDisciplinaDTO>();
        }    
    
    }
}
