using matriz.Core.Application.Interfaces;
using matriz.Core.Domain.Entities.Pizzaria;
using Microsoft.AspNetCore.Mvc;

namespace matriz.MVC.Principal.Controllers
{

    public class IngredienteController : Controller
    {

        private readonly IIngredienteService _ingredienteService;

        public IngredienteController(IIngredienteService ingredienteService)
        {
            _ingredienteService = ingredienteService;
        }

        public async Task<IActionResult> Index()
        {

            var pizza = await _ingredienteService.ObterListaIngredienteAsync();

            return View(pizza);
        }


        public IActionResult Cadastrar(int pizzaId)
        {

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(Ingrediente ingrediente)
        {
            var nome = Request.Form["Nome"];

            if (ModelState.IsValid)
            {
                var ingredienteSalvar = new Ingrediente(
                    nome
                    );

                var pizid = await _ingredienteService.SalvarIngrediente(ingredienteSalvar);

                return RedirectToAction(nameof(Index));

            }

            return View(ingrediente);
        }

        public IActionResult Alterar(int ingredienteId)
        {

            var ingrediente = _ingredienteService.ObterIngredienteAsync(ingredienteId);

            return View(ingrediente);
        }


        [HttpPost]
        public async Task<IActionResult> Alterar(Ingrediente ingrediente)
        {
            var ingredienteId = Request.Form["IngredienteId"];
            var nome = Request.Form["Nome"];

            if (ModelState.IsValid)
            {
                var ingredienteAlterada = new Ingrediente(
                    Int32.Parse(ingredienteId),
                    nome
                    );

                await _ingredienteService.AlterarIngrediente(ingredienteAlterada);

                return RedirectToAction(nameof(Index));
            }

            return View(ingrediente);
        }

        public IActionResult Consultar(int ingredienteId)
        {
            var ingrediente = _ingredienteService.ObterIngredienteAsync(ingredienteId);

            return View(ingrediente);
        }
        public IActionResult Excluir(int ingredienteId)
        {
            var ingrediente = _ingredienteService.ObterIngredienteAsync(ingredienteId);

            return View(ingrediente);
        }

        public async Task<IActionResult> ConfirmaExclussao(int ingredienteId)
        {

            await _ingredienteService.ExcluirIngrediente(ingredienteId);
            return RedirectToAction(nameof(Index));

        }

    }
}
