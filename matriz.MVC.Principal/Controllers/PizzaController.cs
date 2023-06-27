using matriz.Core.Application.DTOs.Pizzaria;
using matriz.Core.Application.Interfaces;
using matriz.Core.Application.Services;
using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Entities.Pizzaria;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using System.Drawing;

namespace matriz.MVC.Principal.Controllers
{

    public class PizzaController : Controller
    {

        private readonly IPizzaService _pizzaService;
        private readonly ITipoService _tipoService;
        private readonly ITamanhoService _tamanhoService;
        private readonly ITabelaPrecoService _tabelaPrecoService;
        private readonly IIngredienteService _ingredienteService;

        public PizzaController(IPizzaService pizzaService, ITipoService tipoService,ITamanhoService tamanhoService, ITabelaPrecoService tabelaPrecoService, IIngredienteService ingredienteService )
        {
            _pizzaService = pizzaService;
            _tipoService = tipoService;
            _tamanhoService = tamanhoService;
            _tabelaPrecoService= tabelaPrecoService;
            _ingredienteService= ingredienteService;

        }

        public async Task<IActionResult> Index()
        {

            var pizza = await _pizzaService.ObterListaPizzaAsync();

            return View(pizza);
        }


        public IActionResult Cadastrar(int pizzaId)
        {

            //Carrega as imagens da pizza
            var fotopizza = _pizzaService.ObterFotoPizzaAsync(pizzaId);
            ViewBag.ListaFotoPizzas = fotopizza;

            // Carrega os ingredientes da pizza
            var ingredientepizza = _pizzaService.ObterIngredientePizzaAsync(pizzaId);
            ViewBag.ListaIngredientePizzas = ingredientepizza;

            // Carrega os deatalhes da pizza
            var pizzaDetalhe = _pizzaService.ObterPizzaDetalheAsync(pizzaId);
            ViewBag.ListaPizzaDetalhes = pizzaDetalhe;

            ViewBag.ListaIngrediente = _ingredienteService.ObterListaIngredienteAsync().Result.Select(c => new SelectListItem()
            { Text = c.Nome.ToString(), Value = c.IngredienteId.ToString() }).ToList();

            ViewBag.ListaTipoPizzas = _tipoService.ObterListaTipoAsync().Result.Select(c => new SelectListItem()
            { Text = c.Descricao, Value = c.TipoId.ToString() }).ToList();
            ViewBag.ListaTamanhoPizzas = _tamanhoService.ObterListaTamanhoAsync().Result.Select(c => new SelectListItem()
            { Text = c.Descricao, Value = c.TamanhoId.ToString() }).ToList();
            ViewBag.ListaTabelaPrecoPizzas = _tabelaPrecoService.ObterListaTabelaPrecoAsync().Result.Select(c => new SelectListItem()
            { Text = c.Preco.ToString(), Value = c.TabelaPrecoId.ToString() }).ToList();

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(Pizza pizza)
        {
            var pizzaId = Request.Form["PizzaId"];
            var nome = Request.Form["Nome"];
            var descricao = Request.Form["Descricao"];

            if (ModelState.IsValid)
            {

                var pizzaSalva = new Pizza(
                    nome,
                    descricao
                    );

                var pizid = await _pizzaService.SalvarPizza(pizzaSalva);

                pizzaId = pizid.PizzaId.ToString();

                //Carrega as imagens da pizza
                var fotopizza = _pizzaService.ObterFotoPizzaAsync(Int32.Parse(pizzaId));
                ViewBag.ListaFotoPizzas = fotopizza;

                // Carrega os ingredientes da pizza
                var ingredientepizza = _pizzaService.ObterIngredientePizzaAsync(Int32.Parse(pizzaId));
                ViewBag.ListaIngredientePizzas = ingredientepizza;

                // Carrega os deatalhes da pizza
                var pizzaDetalhe = _pizzaService.ObterPizzaDetalheAsync(Int32.Parse(pizzaId));
                ViewBag.ListaPizzaDetalhes = pizzaDetalhe;


                ViewBag.ListaIngrediente = _ingredienteService.ObterListaIngredienteAsync().Result.Select(c => new SelectListItem()
                { Text = c.Nome.ToString(), Value = c.IngredienteId.ToString() }).ToList(); ;

                ViewBag.ListaTipoPizzas = _tipoService.ObterListaTipoAsync().Result.Select(c => new SelectListItem()
                { Text = c.Descricao, Value = c.TipoId.ToString() }).ToList(); ;

                ViewBag.ListaTamanhoPizzas = _tamanhoService.ObterListaTamanhoAsync().Result.Select(c => new SelectListItem()
                { Text = c.Descricao, Value = c.TamanhoId.ToString() }).ToList(); ;

                ViewBag.ListaTabelaPrecoPizzas = _tabelaPrecoService.ObterListaTabelaPrecoAsync().Result.Select(c => new SelectListItem()
                { Text = c.Preco.ToString(), Value = c.TabelaPrecoId.ToString() }).ToList(); ;


                return RedirectToAction("Alterar", new { pizzaId = pizzaId });
            }

            return View(pizza);
        }

        public IActionResult Alterar(int pizzaId)
        {

            var pizza = _pizzaService.ObterPizzaAsync(pizzaId);

            //Carrega as imagens da pizza
            var  fotopizza = _pizzaService.ObterFotoPizzaAsync(pizzaId);
            ViewBag.ListaFotoPizzas = fotopizza;

            // Carrega os ingredientes da pizza
            var ingredientepizza = _pizzaService.ObterIngredientePizzaAsync(pizzaId);
            ViewBag.ListaIngredientePizzas = ingredientepizza;

            // Carrega os deatalhes da pizza
            var pizzaDetalhe = _pizzaService.ObterPizzaDetalheAsync(pizzaId);
            ViewBag.ListaPizzaDetalhes = pizzaDetalhe;

            ViewBag.ListaIngrediente = _ingredienteService.ObterListaIngredienteAsync().Result.Select(c => new SelectListItem()
            { Text = c.Nome.ToString(), Value = c.IngredienteId.ToString() }).ToList();

            ViewBag.ListaTipoPizzas = _tipoService.ObterListaTipoAsync().Result.Select(c => new SelectListItem()
            { Text = c.Descricao, Value = c.TipoId.ToString() }).ToList(); 
            ViewBag.ListaTamanhoPizzas = _tamanhoService.ObterListaTamanhoAsync().Result.Select(c => new SelectListItem()
            { Text = c.Descricao, Value = c.TamanhoId.ToString() }).ToList(); 
            ViewBag.ListaTabelaPrecoPizzas = _tabelaPrecoService.ObterListaTabelaPrecoAsync().Result.Select(c => new SelectListItem()
            { Text = c.Preco.ToString(), Value = c.TabelaPrecoId.ToString() }).ToList();
 
            return View(pizza);
        }


        [HttpPost]
        public async Task<IActionResult> Alterar(Pizza pizza)
        {

            var pizzaId = Request.Form["PizzaId"];
            var nome = Request.Form["Nome"];
            var descricao = Request.Form["Descricao"];

            if (ModelState.IsValid)
            {

                var pizzaAlterada = new Pizza(
                    Int32.Parse(pizzaId),
                    nome,
                    descricao
                    );

                await _pizzaService.AlterarPizza(pizzaAlterada);

                //Carrega as imagens da pizza
                var fotopizza = _pizzaService.ObterFotoPizzaAsync(Int32.Parse(pizzaId));
                ViewBag.ListaFotoPizzas = fotopizza;

                // Carrega os ingredientes da pizza
                var ingredientepizza = _pizzaService.ObterIngredientePizzaAsync(Int32.Parse(pizzaId));
                ViewBag.ListaIngredientePizzas = ingredientepizza;

                // Carrega os deatalhes da pizza
                var pizzaDetalhe = _pizzaService.ObterPizzaDetalheAsync(Int32.Parse(pizzaId));
                ViewBag.ListaPizzaDetalhes = pizzaDetalhe;

                ViewBag.ListaIngrediente = _ingredienteService.ObterListaIngredienteAsync().Result.Select(c => new SelectListItem()
                { Text = c.Nome.ToString(), Value = c.IngredienteId.ToString() }).ToList(); ;

                ViewBag.ListaTipoPizzas = _tipoService.ObterListaTipoAsync().Result.Select(c => new SelectListItem()
                { Text = c.Descricao, Value = c.TipoId.ToString() }).ToList(); ;

                ViewBag.ListaTamanhoPizzas = _tamanhoService.ObterListaTamanhoAsync().Result.Select(c => new SelectListItem()
                { Text = c.Descricao, Value = c.TamanhoId.ToString() }).ToList(); ;

                ViewBag.ListaTabelaPrecoPizzas = _tabelaPrecoService.ObterListaTabelaPrecoAsync().Result.Select(c => new SelectListItem()
                { Text = c.Preco.ToString(), Value = c.TabelaPrecoId.ToString() }).ToList(); ;


                return RedirectToAction("Alterar", new { pizzaId = pizzaId });
            }

            return View(pizza);
        }

        public IActionResult Consultar(int pizzaId)
        {
            var pizza = _pizzaService.ObterPizzaAsync(pizzaId);

            //Carrega as imagens da pizza
            var fotopizza = _pizzaService.ObterFotoPizzaAsync(pizzaId);
            ViewBag.ListaFotoPizzas = fotopizza;

            // Carrega os ingredientes da pizza
            var ingredientepizza = _pizzaService.ObterIngredientePizzaAsync(pizzaId);
            ViewBag.ListaIngredientePizzas = ingredientepizza;

            // Carrega os deatalhes da pizza
            var pizzaDetalhe = _pizzaService.ObterPizzaDetalheAsync(pizzaId);
            ViewBag.ListaPizzaDetalhes = pizzaDetalhe;

            return View(pizza);
        }
        public IActionResult Excluir(int pizzaId)
        {
            var pizza = _pizzaService.ObterPizzaAsync(pizzaId);
            //Carrega as imagens da pizza
            var fotopizza = _pizzaService.ObterFotoPizzaAsync(pizzaId);
            ViewBag.ListaFotoPizzas = fotopizza;

            // Carrega os ingredientes da pizza
            var ingredientepizza = _pizzaService.ObterIngredientePizzaAsync(pizzaId);
            ViewBag.ListaIngredientePizzas = ingredientepizza;

            // Carrega os deatalhes da pizza
            var pizzaDetalhe = _pizzaService.ObterPizzaDetalheAsync(pizzaId);
            ViewBag.ListaPizzaDetalhes = pizzaDetalhe;

            return View(pizza);
        }

        public async Task<IActionResult> ConfirmaExclussao(int pizzaId)
        {

            await _pizzaService.ExcluirPizza(pizzaId);
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> ExcluirFotoPizza(int fotoPizzaId, int pizzaId)
        {

            await _pizzaService.ExcluirFotoPizza(fotoPizzaId);

            return RedirectToAction("Alterar", new { pizzaId = pizzaId });

        }



        public async Task<IActionResult> ExcluirPizzaIngrediente(int ingredienteId, int pizzaId)
        {


            await _pizzaService.ExcluirPizzaIngrediente(pizzaId, ingredienteId);

            return RedirectToAction("Alterar", new { pizzaId = pizzaId });

        }

        public async Task<IActionResult> ExcluirPizzaDetalhe(int pizzaId, int pizzaDetalheId)
        {


            await _pizzaService.ExcluirPizzaDetalhe(pizzaDetalheId);

            return RedirectToAction("Alterar", new { pizzaId = pizzaId });

        }


        public async Task<IActionResult> AdicionarIngrediente()
        {
            string pizzaId = "0";
            string ingredienteId = "0";
            pizzaId = Request.Form["PizzaId"];
            ingredienteId = Request.Form["IngredienteId"];


            if (ModelState.IsValid)
            {
                var pizzaIngredienteSalvar = new PizzaIngrediente(
                    Int32.Parse(pizzaId),
                    Int32.Parse(ingredienteId)
                    );

                await _pizzaService.SalvarPizzaIngrediente(pizzaIngredienteSalvar);

                return RedirectToAction("Alterar", new { pizzaId = pizzaId });
            }

            return View();
        }
        public async Task<IActionResult> AdicionarPizzaDetalhe()
        {
            var pizzaId = Request.Form["PizzaId"];
            var tipopizza = Request.Form["TipoId"];
            var tamanhopizza = Request.Form["TamanhoId"];
            var tabelapreco = Request.Form["TabelaPrecoId"];


            if (ModelState.IsValid)
            {
                var pissaDetalheAlterada = new PizzaDetalhe(
                     Int32.Parse(pizzaId),
                     Int32.Parse(tabelapreco),
                     Int32.Parse(tamanhopizza),
                     Int32.Parse(tipopizza)
                     );

                await _pizzaService.AdicionarPizzaDetalhe(pissaDetalheAlterada);

                return RedirectToAction("Alterar", new { pizzaId = pizzaId });
            }

            return View();
        }

        public async Task<IActionResult> SalvarFotoPizza(IList<IFormFile> fotoPizza)
        {

            string pizzaId = "0";

            var foto = "";
            pizzaId = Request.Form["PizzaId"];
            var nome = Request.Form["Nome"];
            var descricao = Request.Form["Descricao"];


            if (pizzaId == "" && descricao != "")
            {

                if (ModelState.IsValid)
                {
                    var pizzaSalva = new Pizza(
                        nome,
                        descricao
                        );

                    var pizid = await _pizzaService.SalvarPizza(pizzaSalva);

                    pizzaId = pizid.PizzaId.ToString();
                }
            }

            if (fotoPizza.Count == 0 && descricao == "") 
            {
                return RedirectToAction("Cadastrar", new { pizzaId = pizzaId });
            }

            if (fotoPizza.Count == 0 && descricao != "")
            {
                return RedirectToAction("Alterar", new { pizzaId = pizzaId });
            }

            foreach (var arquivo in fotoPizza)
            {
                //verifica se existem arquivos 
                if (arquivo == null || arquivo.Length == 0)
                {
                    //retorna a viewdata com erro
                    ViewBag.error = "Error: Arquivo(s) não selecionado(s)";
                    return View();
                }

                foto = arquivo.FileName;

            }

            if (ModelState.IsValid)
            {
                var pizzaFotoSalvar = new FotoPizza(
                    Int32.Parse(pizzaId),
                    foto
                    );

                await _pizzaService.SalvarFotoPizza(pizzaFotoSalvar);

                return RedirectToAction("Alterar", new { pizzaId = pizzaId });
            }

            return View();
        }

    }

}