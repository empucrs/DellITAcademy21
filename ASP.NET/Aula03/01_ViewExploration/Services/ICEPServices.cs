using _01_ViewExploration.Models;

namespace _01_ViewExploration.Services;
public interface ICEPServices{

    IEnumerable<CEPViewModel> listaCEPs();
    CEPViewModel? CadastrarCEP(CEPViewModel CEP);
    CEPViewModel? pesquisaCEP(int CEP);

}