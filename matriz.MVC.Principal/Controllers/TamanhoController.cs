using matriz.Core.Application.Interfaces;
using matriz.Core.Domain.Entities.Pizzaria;
using Microsoft.AspNetCore.Mvc;

namespace matriz.MVC.Principal.Controllers
{

    public class TamanhoController : Controller
    {

        private readonly ITamanhoService _tamanhoService;

        public TamanhoController(ITamanhoService tamanhoService)
        {
            _tamanhoService = tamanhoService;
        }

        public async Task<IActionResult> Index()
        {

            var pizza = await _tamanhoService.ObterListaTamanhoAsync();

            return View(pizza);
        }


        public IActionResult Cadastrar(int pizzaId)
        {

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(Tamanho tamanho)
        {
            var descricao = Request.Form["Descricao"];
            var numPedaco = Request.Form["NumPedaco"];

            if (ModelState.IsValid)
            {
                var tamanhoSalvar = new Tamanho(
                    descricao,
                    Int32.Parse(numPedaco)
                    );

                var pizid = await _tamanhoService.SalvarTamanho(tamanhoSalvar);

                return RedirectToAction(nameof(Index));

            }

            return View(tamanho);
        }

        public IActionResult Alterar(int tamanhoId)
        {

            var tamanho = _tamanhoService.ObterTamanhoAsync(tamanhoId);

            return View(tamanho);
        }


        [HttpPost]
        public async Task<IActionResult> Alterar(Tamanho tamanho)
        {
            var tamanhoId = Request.Form["TamanhoId"];
            var descricao = Request.Form["Descricao"];
            var numPedaco = Request.Form["NumPedaco"];

            if (ModelState.IsValid)
            {
                var tamanhoAlterada = new Tamanho(
                    Int32.Parse(tamanhoId),
                    descricao,
                    Int32.Parse(numPedaco)
                    );

                await _tamanhoService.AlterarTamanho(tamanhoAlterada);

                return RedirectToAction(nameof(Index));
            }

            return View(tamanho);
        }

        public IActionResult Consultar(int tamanhoId)
        {
            var tamanho = _tamanhoService.ObterTamanhoAsync(tamanhoId);

            return View(tamanho);
        }
        public IActionResult Excluir(int tamanhoId)
        {
            var tamanho = _tamanhoService.ObterTamanhoAsync(tamanhoId);

            return View(tamanho);
        }

        public async Task<IActionResult> ConfirmaExclussao(int tamanhoId)
        {

            await _tamanhoService.ExcluirTamanho(tamanhoId);
            return RedirectToAction(nameof(Index));

        }

    }
}
