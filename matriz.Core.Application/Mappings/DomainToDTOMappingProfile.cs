using AutoMapper;
using matriz.Core.Application.DTOs;
using matriz.Core.Application.DTOs.PontuacaoProfessor;
using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Entities.PontuacaoProfessor;
using System.Collections.Generic;

namespace matriz.Core.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile() 
        { 

            CreateMap<AreaConhecimento, AreaConhecimentoDTO>().ReverseMap();
            CreateMap<Atribuicao, AtribuicaoDTO>().ReverseMap();
            CreateMap<CargoDepartamentoUnidade, CargoDepartamentoUnidadeDTO>().ReverseMap();
            CreateMap<Cargo, CargoDTO>().ReverseMap();
            CreateMap<Classe, ClasseDTO>().ReverseMap();
            CreateMap<ClasseGrupoDisciplina, ClasseGrupoDisciplinaDTO>().ReverseMap();
            CreateMap<CursoArea, CursoAreaDTO>().ReverseMap();
            CreateMap<CursoDisciplina, CursoDisciplinaDTO>().ReverseMap();
            CreateMap<Curso, CursoDTO>().ReverseMap();
            CreateMap<CursoHabilitacao, CursoHabilitacaoDTO>().ReverseMap();
            CreateMap<CursoUnidade, CursoUnidadeDTO>().ReverseMap();
            CreateMap<CursoUnidadeFundLegal, CursoUnidadeFundLegalDTO>().ReverseMap();
            CreateMap<CursoUnidadePeriodo, CursoUnidadePeriodoDTO>().ReverseMap();
            CreateMap<Departamento, DepartamentoDTO>().ReverseMap();
            CreateMap<DepartamentoUnidade, DepartamentoUnidadeDTO>().ReverseMap();
            CreateMap<DetalheParametro, DetalheParametroDTO>().ReverseMap();
            CreateMap<DetalhePontuacao, DetalhePontuacaoDTO>().ReverseMap();
            CreateMap<Disciplina, DisciplinaDTO>().ReverseMap();
            CreateMap<FuncionarioCargoDepartamentoUnidade, FuncionarioCargoDepartamentoUnidadeDTO>().ReverseMap();
            CreateMap<Funcionario, FuncionarioDTO>().ReverseMap();
            CreateMap<FuncionarioPermissao, FuncionarioPermissaoDTO>().ReverseMap();
            CreateMap<FundLegal, FundLegalDTO>().ReverseMap();
            CreateMap<GrupoDisciplina, GrupoDisciplinaDTO>().ReverseMap();
            CreateMap<Habilitacao, HabilitacaoDTO>().ReverseMap();
            CreateMap<LogSistema, LogSistemaDTO>().ReverseMap();
            CreateMap<MatriculaProfessor, MatriculaProfessorDTO>().ReverseMap();
            CreateMap<Modalidade, ModalidadeDTO>().ReverseMap();
            CreateMap<Operacao, OperacaoDTO>().ReverseMap();
            CreateMap<OperacaoParametro, OperacaoParametroDTO>().ReverseMap();
            CreateMap<Parametro, ParametroDTO>().ReverseMap();
            CreateMap<Periodo, PeriodoDTO>().ReverseMap();
            CreateMap<Pontuacao, PontuacaoDTO>().ReverseMap();
            CreateMap<ProcessoAtribuicao, ProcessoAtribuicaoDTO>().ReverseMap();
            CreateMap<Professor, ProfessorDTO>().ReverseMap();
            CreateMap<Rotina, RotinaDTO>().ReverseMap();
            CreateMap<RotinaOperacao, RotinaOperacaoDTO>().ReverseMap();
            CreateMap<Sistema, SistemaDTO>().ReverseMap();
            CreateMap<TipoAcesso, TipoAcessoDTO>().ReverseMap();
            CreateMap<TipoParametro, TipoParametroDTO>().ReverseMap();
            CreateMap<TipoUsuarioDTO, TipoUsuarioDTO>().ReverseMap();
            CreateMap<Unidade, UnidadeDTO>().ReverseMap();
            CreateMap<UnidadeParametro, UnidadeParametroDTO>().ReverseMap();
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
            CreateMap<UsuarioPermissao, UsuarioPermissaoDTO>().ReverseMap();

        }
    }
}
