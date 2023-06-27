using matriz.Core.Application.Interfaces;
using matriz.Core.Domain.Entities.Pizzaria;
using Microsoft.AspNetCore.Mvc;

namespace matriz.MVC.Principal.Controllers
{

    public class TabelaPrecoController : Controller
    {

        private readonly ITabelaPrecoService _tabelaPrecoService;

        public TabelaPrecoController(ITabelaPrecoService tabelaPrecoService)
        {
            _tabelaPrecoService = tabelaPrecoService;
        }

        public async Task<IActionResult> Index()
        {

            var tabelaPreco = await _tabelaPrecoService.ObterListaTabelaPrecoAsync();

            return View(tabelaPreco);
        }


        public IActionResult Cadastrar(int pizzaId)
        {

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(TabelaPreco tabelaPreco)
        {
            var preco = Request.Form["Preco"];

            if (ModelState.IsValid)
            {
                var tabelaPrecoSalvar = new TabelaPreco(
                    Decimal.Parse(preco)
                    );

                var pizid = await _tabelaPrecoService.SalvarTabelaPreco(tabelaPrecoSalvar);

                return RedirectToAction(nameof(Index));

            }

            return View(tabelaPreco);
        }

        public IActionResult Alterar(int tabelaPrecoId)
        {

            var tabelaPreco = _tabelaPrecoService.ObterTabelaPrecoAsync(tabelaPrecoId);

            return View(tabelaPreco);
        }


        [HttpPost]
        public async Task<IActionResult> Alterar(TabelaPreco tabelaPreco)
        {
            var tabelaPrecoId = Request.Form["TabelaPrecoId"];
            var preco = Request.Form["Preco"];

            if (ModelState.IsValid)
            {
                var tabelaPrecoAlterada = new TabelaPreco(
                    Int32.Parse(tabelaPrecoId),
                    Decimal.Parse(preco)
                    );

                await _tabelaPrecoService.AlterarTabelaPreco(tabelaPrecoAlterada);

                return RedirectToAction(nameof(Index));
            }

            return View(tabelaPreco);
        }

        public IActionResult Consultar(int ingredienteId)
        {
            var tabelaPreco = _tabelaPrecoService.ObterTabelaPrecoAsync(ingredienteId);

            return View(tabelaPreco);
        }
        public IActionResult Excluir(int tabelaPrecoId)
        {
            var tabelaPreco = _tabelaPrecoService.ObterTabelaPrecoAsync(tabelaPrecoId);

            return View(tabelaPreco);
        }

        public async Task<IActionResult> ConfirmaExclussao(int tabelaPrecoId)
        {

            await _tabelaPrecoService.ExcluirTabelaPreco(tabelaPrecoId);
            return RedirectToAction(nameof(Index));

        }

    }
}
