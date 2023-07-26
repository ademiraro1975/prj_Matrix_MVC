using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using matriz.Core.Application.Interfaces;
using matriz.Core.Application.Mappings;
using matriz.Core.Application.Services;
using matriz.Core.Domain.Interfaces;
using matriz.Infra.Data.Context;
using matriz.Infra.Data.Repositories;
using matriz.Core.Domain.Interfaces.PontuacaoProfessor;
using matriz.Core.Application.Interfaces.PontuacaoProfessor;
using matriz.Core.Application.Services.PontuacaoProfessor;
using matriz.Infra.Data.Repositories.PontuacaoProfessor;

namespace matriz.Infra.IoC
{
    public static class DependencyInjection
    {
        private static readonly string _conectionString = "Server=172.16.4.122;Database=DadosSAADB;Trusted_Connection=True;TrustServerCertificate=True;";
        //private static readonly string _conectionStringMatrizDB = "Server=172.16.4.122;Database=MATRIZDB;Trusted_Connection=True;TrustServerCertificate=True;";

        //private static readonly string _conectionString = "Server=10.102.1.4;Database=DadosSAADB;User ID=fieb;Password=hb@C1#qB3;";

        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            //var configuration = DatabaseConfiguration.Configuration;
            services.AddDbContext<AppDbContext>(
                    options => options.UseSqlServer(_conectionString,b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));


            //Repositories
            services.AddScoped<IAulaRegistroRepository, AulaRegistroRepository>();
            services.AddScoped<IAulaRegistroAlunoRepository, AulaRegistroAlunoRepository>();
            services.AddScoped<IAvaliacaoRepository, AvaliacaoRepository>();
            services.AddScoped<IBrowserRepository, BrowserRepository>();
            services.AddScoped<IConteudoProfessorRepository, ConteudoProfessorRepository>();
            services.AddScoped<IConteudoProfessorAulaRepository, ConteudoProfessorAulaRepository>();
            services.AddScoped<IConteudoProfessorClasseRepository, ConteudoProfessorClasseRepository>();
            services.AddScoped<IEmailLoginTesteRepository, EmailLoginTesteRepository>();
            services.AddScoped<IFaltaDetalheRepository, FaltaDetalheRepository>();
            services.AddScoped<IGrupoParametroRepository, GrupoParametroRepository>();
            services.AddScoped<ILancamentosAulaRepository, LancamentosAulaRepository>();
            services.AddScoped<ILogConselhoRepository, LogConselhoRepository>();
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<IMedalhaRepository, MedalhaRepository>();
            services.AddScoped<IMedalhaAlunoRepository, MedalhaAlunoRepository>();
            services.AddScoped<IMensagemRepository, MensagemRepository>();
            services.AddScoped<INotaAvaliacaoRepository, NotaAvaliacaoRepository>();
            services.AddScoped<IOcorrenciaRepository, OcorrenciaRepository>();
            services.AddScoped<IOcorrenciaOfficeRepository, OcorrenciaOfficeRepository>();
            services.AddScoped<IParametroRepository, ParametroRepository>();
            services.AddScoped<IParametroValidacaoRepository, ParametroValidacaoRepository>();
            services.AddScoped<IPeriodoAtivoRepository, PeriodoAtivoRepository>();
            services.AddScoped<IPeriodoAtivoProfessorRepository, PeriodoAtivoProfessorRepository>();
            services.AddScoped<IPeriodoNotaRepository, PeriodoNotaRepository>();
            services.AddScoped<IPlataformaRepository, PlataformaRepository>();
            services.AddScoped<IProcedimentoRepository, ProcedimentoRepository>();
            services.AddScoped<IProcedimentoAlunoRepository, ProcedimentoAlunoRepository>();
            services.AddScoped<IQuestaoRepository, QuestaoRepository>();
            services.AddScoped<IQuestionarioRepository, QuestionarioRepository>();
            services.AddScoped<IQuestionarioAlunoRepository, QuestionarioAlunoRepository>();
            services.AddScoped<IRespostaRepository, RespostaRepository>();
            services.AddScoped<ISituacaoComentarioRepository, SituacaoComentarioRepository>();
            services.AddScoped<ITipoAcessoRepository, TipoAcessoRepository>();
            services.AddScoped<ITipoAvaliacaoRepository, TipoAvaliacaoRepository>();
            services.AddScoped<ITipoLogRepository, TipoLogRepository>();
            services.AddScoped<ITipoLoginRepository, TipoLoginRepository>();
            services.AddScoped<ITipoMedalhaRepository, TipoMedalhaRepository>();
            services.AddScoped<ITipoMensagemRepository, TipoMensagemRepository>();
            services.AddScoped<ITipoOcorrenciaOfficeRepository, TipoOcorrenciaOfficeRepository>();
            services.AddScoped<ITipoParametroRepository, TipoParametroRepository>();
            services.AddScoped<ITipoPontuacaoRepository, TipoPontuacaoRepository>();
            services.AddScoped<ITipoProcedimentoRepository, TipoProcedimentoRepository>();
            services.AddScoped<ITipoQuestaoRepository, TipoQuestaoRepository>();
            services.AddScoped<ITipoQuestionarioRepository, TipoQuestionarioRepository>();
            services.AddScoped<ITipoRotinaRepository, TipoRotinaRepository>();
            services.AddScoped<ITipoSolicitanteRepository, TipoSolicitanteRepository>();



            //Services
            services.AddScoped<IAvaliacaoService, AvaliacaoService>();
            services.AddScoped<IAulaRegistroService, AulaRegistroService>();
            services.AddScoped<IAulaRegistroAlunoService, AulaRegistroAlunoService>();
            services.AddScoped<IAvaliacaoService, AvaliacaoService>();
            services.AddScoped<IBrowserService, BrowserService>();
            services.AddScoped<IConteudoProfessorService, ConteudoProfessorService>();
            services.AddScoped<IConteudoProfessorAulaService, ConteudoProfessorAulaService>();
            services.AddScoped<IConteudoProfessorClasseService, ConteudoProfessorClasseService>();
            services.AddScoped<IEmailLoginTesteService, EmailLoginTesteService>();
            services.AddScoped<IFaltaDetalheService, FaltaDetalheService>();
            services.AddScoped<IGrupoParametroService, GrupoParametroService>();
            services.AddScoped<ILancamentosAulaService, LancamentosAulaService>();
            services.AddScoped<ILogConselhoService, LogConselhoService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IMedalhaService, MedalhaService>();
            services.AddScoped<IMedalhaAlunoService, MedalhaAlunoService>();
            services.AddScoped<IMensagemService, MensagemService>();
            services.AddScoped<INotaAvaliacaoService, NotaAvaliacaoService>();
            services.AddScoped<IOcorrenciaService, OcorrenciaService>();
            services.AddScoped<IOcorrenciaOfficeService, OcorrenciaOfficeService>();
            services.AddScoped<IParametroService, ParametroService>();
            services.AddScoped<IParametroValidacaoService, ParametroValidacaoService>();
            services.AddScoped<IPeriodoAtivoService, PeriodoAtivoService>();
            services.AddScoped<IPeriodoAtivoProfessorService, PeriodoAtivoProfessorService>();
            services.AddScoped<IPeriodoNotaService, PeriodoNotaService>();
            services.AddScoped<IPlataformaService, PlataformaService>();
            services.AddScoped<IProcedimentoService, ProcedimentoService>();
            services.AddScoped<IProcedimentoAlunoService, ProcedimentoAlunoService>();
            services.AddScoped<IQuestaoService, QuestaoService>();
            services.AddScoped<IQuestionarioService, QuestionarioService>();
            services.AddScoped<IQuestionarioAlunoService, QuestionarioAlunoService>();
            services.AddScoped<IRespostaService, RespostaService>();
            services.AddScoped<ISituacaoComentarioService, SituacaoComentarioService>();
            services.AddScoped<ITipoAcessoService, TipoAcessoService>();
            services.AddScoped<ITipoAvaliacaoService, TipoAvaliacaoService>();
            services.AddScoped<ITipoLogService, TipoLogService>();
            services.AddScoped<ITipoLoginService, TipoLoginService>();
            services.AddScoped<ITipoMedalhaService, TipoMedalhaService>();
            services.AddScoped<ITipoMensagemService, TipoMensagemService>();
            services.AddScoped<ITipoOcorrenciaOfficeService, TipoOcorrenciaOfficeService>();
            services.AddScoped<ITipoParametroService, TipoParametroService>();
            services.AddScoped<ITipoPontuacaoService, TipoPontuacaoService>();
            services.AddScoped<ITipoProcedimentoService, TipoProcedimentoService>();
            services.AddScoped<ITipoQuestaoService, TipoQuestaoService>();
            services.AddScoped<ITipoQuestionarioService, TipoQuestionarioService>();
            services.AddScoped<ITipoRotinaService, TipoRotinaService>();
            services.AddScoped<ITipoSolicitanteService, TipoSolicitanteService>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;
        }
    }
}