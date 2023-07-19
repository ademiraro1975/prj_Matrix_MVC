using matriz.Core.Application.Interfaces;
using matriz.Core.Application.Interfaces.PontuacaoProfessor;
using matriz.Core.Application.Services;
using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Entities.PontuacaoProfessor;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace matriz.MVC.Principal.Controllers
{

    public class GestorController : Controller
    {

        private readonly IProfessorService _professorService;


        public GestorController(IProfessorService professorService)
        {
            _professorService = professorService;


        }

        public async Task<IActionResult> Index()
        {

            var pizza = await _professorService.ObterListaProfessorAsync();

            return View(pizza);
        }


        public IActionResult Cadastrar(int pizzaId)
        {

            //Carrega as imagens da pizza
            //var fotopizza = _pizzaService.ObterFotoPizzaAsync(pizzaId);
            //ViewBag.ListaFotoPizzas = fotopizza;

            //// Carrega os ingredientes da pizza
            //var ingredientepizza = _pizzaService.ObterIngredientePizzaAsync(pizzaId);
            //ViewBag.ListaIngredientePizzas = ingredientepizza;

            //// Carrega os deatalhes da pizza
            //var pizzaDetalhe = _pizzaService.ObterPizzaDetalheAsync(pizzaId);
            //ViewBag.ListaPizzaDetalhes = pizzaDetalhe;

            //ViewBag.ListaIngrediente = _ingredienteService.ObterListaIngredienteAsync().Result.Select(c => new SelectListItem()
            //{ Text = c.Nome.ToString(), Value = c.IngredienteId.ToString() }).ToList();

            //ViewBag.ListaTipoPizzas = _tipoService.ObterListaTipoAsync().Result.Select(c => new SelectListItem()
            //{ Text = c.Descricao, Value = c.TipoId.ToString() }).ToList();
            //ViewBag.ListaTamanhoPizzas = _tamanhoService.ObterListaTamanhoAsync().Result.Select(c => new SelectListItem()
            //{ Text = c.Descricao, Value = c.TamanhoId.ToString() }).ToList();
            //ViewBag.ListaTabelaPrecoPizzas = _tabelaPrecoService.ObterListaTabelaPrecoAsync().Result.Select(c => new SelectListItem()
            //{ Text = c.Preco.ToString(), Value = c.TabelaPrecoId.ToString() }).ToList();

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(Professor professor)
        {
            //var pizzaId = Request.Form["PizzaId"];
            //var nome = Request.Form["Nome"];
            //var descricao = Request.Form["Descricao"];

            //if (ModelState.IsValid)
            //{

            //    var pizzaSalva = new Pizza(
            //        nome,
            //        descricao
            //        );

            //    var pizid = await _pizzaService.SalvarPizza(pizzaSalva);

            //    pizzaId = pizid.PizzaId.ToString();

            //    //Carrega as imagens da pizza
            //    var fotopizza = _pizzaService.ObterFotoPizzaAsync(Int32.Parse(pizzaId));
            //    ViewBag.ListaFotoPizzas = fotopizza;

            //    // Carrega os ingredientes da pizza
            //    var ingredientepizza = _pizzaService.ObterIngredientePizzaAsync(Int32.Parse(pizzaId));
            //    ViewBag.ListaIngredientePizzas = ingredientepizza;

            //    // Carrega os deatalhes da pizza
            //    var pizzaDetalhe = _pizzaService.ObterPizzaDetalheAsync(Int32.Parse(pizzaId));
            //    ViewBag.ListaPizzaDetalhes = pizzaDetalhe;


            //    ViewBag.ListaIngrediente = _ingredienteService.ObterListaIngredienteAsync().Result.Select(c => new SelectListItem()
            //    { Text = c.Nome.ToString(), Value = c.IngredienteId.ToString() }).ToList(); ;

            //    ViewBag.ListaTipoPizzas = _tipoService.ObterListaTipoAsync().Result.Select(c => new SelectListItem()
            //    { Text = c.Descricao, Value = c.TipoId.ToString() }).ToList(); ;

            //    ViewBag.ListaTamanhoPizzas = _tamanhoService.ObterListaTamanhoAsync().Result.Select(c => new SelectListItem()
            //    { Text = c.Descricao, Value = c.TamanhoId.ToString() }).ToList(); ;

            //    ViewBag.ListaTabelaPrecoPizzas = _tabelaPrecoService.ObterListaTabelaPrecoAsync().Result.Select(c => new SelectListItem()
            //    { Text = c.Preco.ToString(), Value = c.TabelaPrecoId.ToString() }).ToList(); ;


            //    return RedirectToAction("Alterar", new { pizzaId = pizzaId });
            //}

            return View(professor);
        }

        public IActionResult Alterar(int pizzaId)
        {

            //var pizza = _pizzaService.ObterPizzaAsync(pizzaId);

            ////Carrega as imagens da pizza
            //var  fotopizza = _pizzaService.ObterFotoPizzaAsync(pizzaId);
            //ViewBag.ListaFotoPizzas = fotopizza;

            //// Carrega os ingredientes da pizza
            //var ingredientepizza = _pizzaService.ObterIngredientePizzaAsync(pizzaId);
            //ViewBag.ListaIngredientePizzas = ingredientepizza;

            //// Carrega os deatalhes da pizza
            //var pizzaDetalhe = _pizzaService.ObterPizzaDetalheAsync(pizzaId);
            //ViewBag.ListaPizzaDetalhes = pizzaDetalhe;

            //ViewBag.ListaIngrediente = _ingredienteService.ObterListaIngredienteAsync().Result.Select(c => new SelectListItem()
            //{ Text = c.Nome.ToString(), Value = c.IngredienteId.ToString() }).ToList();

            //ViewBag.ListaTipoPizzas = _tipoService.ObterListaTipoAsync().Result.Select(c => new SelectListItem()
            //{ Text = c.Descricao, Value = c.TipoId.ToString() }).ToList(); 
            //ViewBag.ListaTamanhoPizzas = _tamanhoService.ObterListaTamanhoAsync().Result.Select(c => new SelectListItem()
            //{ Text = c.Descricao, Value = c.TamanhoId.ToString() }).ToList(); 
            //ViewBag.ListaTabelaPrecoPizzas = _tabelaPrecoService.ObterListaTabelaPrecoAsync().Result.Select(c => new SelectListItem()
            //{ Text = c.Preco.ToString(), Value = c.TabelaPrecoId.ToString() }).ToList();
 
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Alterar(Professor professor)
        {

            //var pizzaId = Request.Form["PizzaId"];
            //var nome = Request.Form["Nome"];
            //var descricao = Request.Form["Descricao"];

            //if (ModelState.IsValid)
            //{

            //    var pizzaAlterada = new Pizza(
            //        Int32.Parse(pizzaId),
            //        nome,
            //        descricao
            //        );

            //    await _pizzaService.AlterarPizza(pizzaAlterada);

            //    //Carrega as imagens da pizza
            //    var fotopizza = _pizzaService.ObterFotoPizzaAsync(Int32.Parse(pizzaId));
            //    ViewBag.ListaFotoPizzas = fotopizza;

            //    // Carrega os ingredientes da pizza
            //    var ingredientepizza = _pizzaService.ObterIngredientePizzaAsync(Int32.Parse(pizzaId));
            //    ViewBag.ListaIngredientePizzas = ingredientepizza;

            //    // Carrega os deatalhes da pizza
            //    var pizzaDetalhe = _pizzaService.ObterPizzaDetalheAsync(Int32.Parse(pizzaId));
            //    ViewBag.ListaPizzaDetalhes = pizzaDetalhe;

            //    ViewBag.ListaIngrediente = _ingredienteService.ObterListaIngredienteAsync().Result.Select(c => new SelectListItem()
            //    { Text = c.Nome.ToString(), Value = c.IngredienteId.ToString() }).ToList(); ;

            //    ViewBag.ListaTipoPizzas = _tipoService.ObterListaTipoAsync().Result.Select(c => new SelectListItem()
            //    { Text = c.Descricao, Value = c.TipoId.ToString() }).ToList(); ;

            //    ViewBag.ListaTamanhoPizzas = _tamanhoService.ObterListaTamanhoAsync().Result.Select(c => new SelectListItem()
            //    { Text = c.Descricao, Value = c.TamanhoId.ToString() }).ToList(); ;

            //    ViewBag.ListaTabelaPrecoPizzas = _tabelaPrecoService.ObterListaTabelaPrecoAsync().Result.Select(c => new SelectListItem()
            //    { Text = c.Preco.ToString(), Value = c.TabelaPrecoId.ToString() }).ToList(); ;


            //    return RedirectToAction("Alterar", new { pizzaId = pizzaId });
            //}

            return View(professor);
        }

        public IActionResult Consultar(int pizzaId)
        {
            //var pizza = _pizzaService.ObterPizzaAsync(pizzaId);

            ////Carrega as imagens da pizza
            //var fotopizza = _pizzaService.ObterFotoPizzaAsync(pizzaId);
            //ViewBag.ListaFotoPizzas = fotopizza;

            //// Carrega os ingredientes da pizza
            //var ingredientepizza = _pizzaService.ObterIngredientePizzaAsync(pizzaId);
            //ViewBag.ListaIngredientePizzas = ingredientepizza;

            //// Carrega os deatalhes da pizza
            //var pizzaDetalhe = _pizzaService.ObterPizzaDetalheAsync(pizzaId);
            //ViewBag.ListaPizzaDetalhes = pizzaDetalhe;

            return View();
        }
        public IActionResult Excluir(int pizzaId)
        {
            //var pizza = _pizzaService.ObterPizzaAsync(pizzaId);
            ////Carrega as imagens da pizza
            //var fotopizza = _pizzaService.ObterFotoPizzaAsync(pizzaId);
            //ViewBag.ListaFotoPizzas = fotopizza;

            //// Carrega os ingredientes da pizza
            //var ingredientepizza = _pizzaService.ObterIngredientePizzaAsync(pizzaId);
            //ViewBag.ListaIngredientePizzas = ingredientepizza;

            //// Carrega os deatalhes da pizza
            //var pizzaDetalhe = _pizzaService.ObterPizzaDetalheAsync(pizzaId);
            //ViewBag.ListaPizzaDetalhes = pizzaDetalhe;

            return View();
        }

        public async Task<IActionResult> ConfirmaExclussao(int pizzaId)
        {

            //await _pizzaService.ExcluirPizza(pizzaId);
            return RedirectToAction(nameof(Index));

        }

    }

}