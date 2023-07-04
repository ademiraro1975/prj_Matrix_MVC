using Microsoft.AspNetCore.Mvc;
using matriz.Core.Application.Interfaces;
using matriz.MVC.Gestor.Models;
using System.Diagnostics;
using matriz.Core.Application.Services;

namespace matriz.MVC.Gestor.Controllers;

[AuthorizationFilterAttibute]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IFuncionarioService _funcionarioService;
    private readonly IFuncionarioPermissaoService _funcionarioPermissaoService;

    public HomeController(IFuncionarioService funcionarioService, IFuncionarioPermissaoService funcionarioPermissaoService, ILogger<HomeController> logger)
    {
        _funcionarioService = funcionarioService;
        _funcionarioPermissaoService = funcionarioPermissaoService;
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        var email = User.Identity?.Name;

        if (email is not null)
        {
            var funcionarioPermissoes = await _funcionarioPermissaoService.ObterFuncionarioPermissaoAsync(email, "souSecretaria");

            var funcionarioId = funcionarioPermissoes.Select(f => f.FuncionarioId).FirstOrDefault();
            HttpContext.Session.SetInt32("funcionarioId", funcionarioId);

            var unidadeId = funcionarioPermissoes.Where(r => r.Rotina.Equals("DIPLOMA")).Select(f => f.UnidadeId).FirstOrDefault();
            HttpContext.Session.SetInt32("unidadeId", unidadeId);

            var fotoUrl = funcionarioPermissoes.Select(f => f.FotoUrl).FirstOrDefault() ?? string.Empty;
            HttpContext.Session.SetString("fotoUrl", fotoUrl);

            var nomeFuncionario = funcionarioPermissoes.Select(f => f.Nome).FirstOrDefault() ?? string.Empty;
            HttpContext.Session.SetString("nomeFuncionario", nomeFuncionario);

        }

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
