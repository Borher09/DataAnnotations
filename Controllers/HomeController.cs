using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AtvDataAnnotations.Models;

namespace AtvDataAnnotations.Controllers;

public class HomeController : Controller
{
    private static List<ClientePremiumViewModel> clientes = new List<ClientePremiumViewModel>();

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(ClientePremiumViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        clientes.Add(model);

        return RedirectToAction("ListaClientes");
    }

    public IActionResult ListaClientes()
    {
        return View(clientes);
    }

    [HttpGet]
    public IActionResult Sucesso()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}