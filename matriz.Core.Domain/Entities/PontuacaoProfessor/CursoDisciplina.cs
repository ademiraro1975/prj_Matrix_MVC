namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class CursoDisciplina
    {

        public int Id { get; set; }

        public int CursoId { get; set; }
        public int DisciplinaId { get; set; }

        public Curso Curso { get; } = new Curso();
        public Disciplina Disciplina { get; } = new Disciplina();

        //public ICollection<CursoDisciplinaCargaHoraria> CursoDisciplinaCargaHorarias { get; } = new List<CursoDisciplinaCargaHoraria>();
        //public ICollection<ProfessorDisciplina> ProfessorDisciplinas { get; } = new List<ProfessorDisciplina>();

        public CursoDisciplina()
        {
            //CursoDisciplinaCargaHorarias = new HashSet<CursoDisciplinaCargaHoraria>();
            //ProfessorDisciplinas = new HashSet<ProfessorDisciplina>();
        }
    }
}