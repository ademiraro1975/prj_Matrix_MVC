using matriz.Core.Application.Interfaces;
using matriz.Core.Domain.Entities.Pizzaria;
using Microsoft.AspNetCore.Mvc;

namespace matriz.MVC.Principal.Controllers
{

    public class TipoController : Controller
    {

        private readonly ITipoService _tipoService;

        public TipoController(ITipoService tipoService)
        {
            _tipoService = tipoService;
        }

        public async Task<IActionResult> Index()
        {

            var pizza = await _tipoService.ObterListaTipoAsync();

            return View(pizza);
        }


        public IActionResult Cadastrar(int pizzaId)
        {

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(Tipo tipo)
        {
            var descricao = Request.Form["Descricao"];

            if (ModelState.IsValid)
            {
                var tipoSalvar = new Tipo(
                    descricao
                    );

                var pizid = await _tipoService.SalvarTipo(tipoSalvar);

                return RedirectToAction(nameof(Index));

            }

            return View(tipo);
        }

        public IActionResult Alterar(int tipoId)
        {

            var tipo = _tipoService.ObterTipoAsync(tipoId);

            return View(tipo);
        }


        [HttpPost]
        public async Task<IActionResult> Alterar(Tipo tipo)
        {
            var tipoId = Request.Form["TipoId"];
            var descricao = Request.Form["Descricao"];

            if (ModelState.IsValid)
            {
                var tipoAlterada = new Tipo(
                    Int32.Parse(tipoId),
                    descricao
                    );

                await _tipoService.AlterarTipo(tipoAlterada);

                return RedirectToAction(nameof(Index));
            }

            return View(tipo);
        }

        public IActionResult Consultar(int tipoId)
        {
            var tipo = _tipoService.ObterTipoAsync(tipoId);

            return View(tipo);
        }
        public IActionResult Excluir(int tipoId)
        {
            var tipo = _tipoService.ObterTipoAsync(tipoId);

            return View(tipo);
        }

        public async Task<IActionResult> ConfirmaExclussao(int tipoId)
        {

            await _tipoService.ExcluirTipo(tipoId);
            return RedirectToAction(nameof(Index));

        }

    }
}
