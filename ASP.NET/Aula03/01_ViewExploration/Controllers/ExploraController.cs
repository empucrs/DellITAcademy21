using Microsoft.AspNetCore.Mvc;

namespace _01_ViewExploration.Controllers;

public class ExploraController : Controller
{

    public IActionResult Principal()
    {
        //configurações iniciais
        ViewData["nome"]= "Edson Moreno";
        ViewData["titulo"] = "um projeto inicial";
        ViewData["outra"] = 1234.54;

        ViewBag.umExemplo = true;

        //chamada da view
        return View("Index");
    }



}
