using Microsoft.AspNetCore.Mvc;
using _01_ViewExploration.Models;
using _01_ViewExploration.Services;

namespace _01_ViewExploration.Controllers;

public class CEPController : Controller{

    private readonly ICEPServices CEPServices;

    public CEPController(ICEPServices Service){
        CEPServices=Service;
    }

    public IActionResult Index(){

        IEnumerable<CEPViewModel> list = CEPServices.listaCEPs();

        return View("ListaCEPObj", list);
    }

    public IActionResult Cadastra(){
        return View();
    }

    [HttpPost]
    public IActionResult Cadastra(CEPViewModel CEP){

        if(ModelState.IsValid)
            CEPServices.CadastrarCEP(CEP);

        return View("ListaCEPObj", CEPServices.listaCEPs());
    }

}
