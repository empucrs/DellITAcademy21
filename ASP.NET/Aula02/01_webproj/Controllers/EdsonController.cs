using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using _01_webproj.Models;

public class EdsonController : Controller
{
    public void Acao01(){
        Console.WriteLine("Uma mensagem vinda do controlador"+this.GetType().Name);
    }

    public string Acao02(){
        return "Edson Ifarraguirre Moreno";
    }

    public int Acao03(){
        return 47;
    }

    public ErrorViewModel Acao04(){
        return new ErrorViewModel(){RequestId="Teste de erro"};

    }

    public IActionResult Acao05(int? id){
        switch(id){
            case 200: return Accepted(); break;
            case 404: return NotFound(); break;
            default: return NoContent(); break;
        }
    }

    //https://localhost:7054/Edson/Acao06?nome=Edson%20Moreno&idade=48
    public string Acao06(string nome, int idade){
        if(!ModelState.IsValid) Console.WriteLine("Há uma falha no modelo enviado");
        return $"Nome:{nome}; idade:{idade}";
    }

    [NonAction]
    public string Acao07(){
        return "uma acao que nao deveria ser acessada";
    }

}