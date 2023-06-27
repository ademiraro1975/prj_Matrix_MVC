using matriz.Core.Application.Interfaces;
using matriz.Core.Application.Services;
using matriz.Core.Domain.Entities.Pizzaria;
using Microsoft.AspNetCore.Mvc;

namespace matriz.MVC.Principal.Controllers;

public class RefrigeranteController : Controller
{

    private readonly IRefrigeranteService _refrigeranteService;


    public RefrigeranteController(IRefrigeranteService refrigeranteService)
    {
        _refrigeranteService = refrigeranteService;
    }
    public async Task<IActionResult> Index()
    {

        var refrigerante = await _refrigeranteService.ObterListaRefrigeranteAsync();

        return View(refrigerante);
    }


    public IActionResult Cadastrar(int refrigeranteId)
    {

        var fotorefrigerante = _refrigeranteService.ObterFotoRefrigeranteAsync(refrigeranteId);

        ViewBag.ListaFotoRefrigerantes = fotorefrigerante;

        return View();

    }

    [HttpPost]
    public async Task<IActionResult> Cadastrar(Refrigerante refrigerante)
    {
        var nome = Request.Form["Nome"];
        var descricao = Request.Form["Descricao"];

        if (ModelState.IsValid)
        {
            var refrigeranteSalvo = new Refrigerante(
                nome,
                descricao
                );

            var refrid = await _refrigeranteService.SalvarRefrigerante(refrigeranteSalvo);

            return RedirectToAction("Alterar", new { refrigeranteId = refrid.RefrigeranteId });
        }

        return View(refrigerante);
    }

    public IActionResult Alterar(int refrigeranteId)
    {

        var refrigerante = _refrigeranteService.ObterRefrigeranteAsync(refrigeranteId);

        var fotorefrigerante = _refrigeranteService.ObterFotoRefrigeranteAsync(refrigeranteId);

        ViewBag.ListaFotoRefrigerantes = fotorefrigerante;

        return View(refrigerante);
    }



    [HttpPost]
    public async Task<IActionResult> Alterar(Refrigerante refrigerante)
    {
        var refrigeranteId = Request.Form["RefrigeranteId"];
        var nome = Request.Form["Nome"];
        var descricao = Request.Form["Descricao"];

        if (ModelState.IsValid)
        {
            var refrigeranteAlterado = new Refrigerante(
                Int32.Parse(refrigeranteId),
            nome,
            descricao
                );

            await _refrigeranteService.AlterarRefrigerante(refrigeranteAlterado);
            return RedirectToAction(nameof(Index));
        }

        return View(refrigerante);
    }

    public IActionResult Consultar(int refrigeranteId)
    {
        var refrigerante = _refrigeranteService.ObterRefrigeranteAsync(refrigeranteId);
        var fotorefrigerante = _refrigeranteService.ObterFotoRefrigeranteAsync(refrigeranteId);

        ViewBag.ListaFotoRefrigerantes = fotorefrigerante;
        return View(refrigerante);
    }
    public IActionResult Excluir(int refrigeranteId)
    {
        var refrigerante = _refrigeranteService.ObterRefrigeranteAsync(refrigeranteId);
        var fotorefrigerante = _refrigeranteService.ObterFotoRefrigeranteAsync(refrigeranteId);

        ViewBag.ListaFotoRefrigerantes = fotorefrigerante;
        return View(refrigerante);
    }

    public async Task<IActionResult> ConfirmaExclussao(int refrigeranteId)
    {

        await _refrigeranteService.ExcluirRefrigerante(refrigeranteId);
        return RedirectToAction(nameof(Index));

    }
    public async Task<IActionResult> ExcluirFotoRefrigerante(int fotoRefrigeranteId, int refrigeranteId)
    {

        await _refrigeranteService.ExcluirFotoRefrigerante(fotoRefrigeranteId);

        return RedirectToAction("Alterar", new { refrigeranteId = refrigeranteId });

    }

    public async Task<IActionResult> SalvarFotoRefrigerante(IList<IFormFile> fotoRefrigerante)
    {
        string RefrigeranteId = "0";

        var foto = "";
        RefrigeranteId = Request.Form["RefrigeranteId"];
        var nome = Request.Form["Nome"];
        var descricao = Request.Form["Descricao"];

        if (RefrigeranteId == "" && descricao != "")
        {

            if (ModelState.IsValid)
            {
                var refrigeranteSalva = new Refrigerante(
                    nome,
                    descricao
                    );

                var refrid = await _refrigeranteService.SalvarRefrigerante(refrigeranteSalva);

                RefrigeranteId = refrid.RefrigeranteId.ToString();
            }
        }
        if (fotoRefrigerante.Count == 0 && descricao == "")
        {
            return RedirectToAction("Cadastrar", new { pizzaId = RefrigeranteId });
        }

        if (fotoRefrigerante.Count == 0 && descricao != "")
        {
            return RedirectToAction("Alterar", new { pizzaId = RefrigeranteId });
        }

        foreach (var arquivo in fotoRefrigerante)
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
            var refrigeranteFotoSalvar = new FotoRefrigerante(
                Int32.Parse(RefrigeranteId),
                foto
                );

            await _refrigeranteService.SalvarFotoRefrigerante(refrigeranteFotoSalvar);

            return RedirectToAction("Alterar", new { refrigeranteId = RefrigeranteId });
        }

        return View();
    }
}

