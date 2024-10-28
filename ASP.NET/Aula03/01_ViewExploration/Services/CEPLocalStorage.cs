using System.Collections.Concurrent;
using _01_ViewExploration.Models;
namespace _01_ViewExploration.Services;

public class CEPLocalStorage: ICEPServices{

    private ConcurrentDictionary<int, CEPViewModel> localStorageInMemory;

    public CEPLocalStorage() {
        localStorageInMemory = new();

        localStorageInMemory.TryAdd(90840450, new CEPViewModel(){CEP=90840450, Estado="RS", Cidade="Porto Alegres", Bairro="Santa Tereza", Logradouro="Alvaro Osimo Caetano"});
        localStorageInMemory.TryAdd(90850130, new CEPViewModel(){CEP=90850130, Estado="RS", Cidade="Porto Alegres", Bairro="Menino Deus", Logradouro="Dona Augusta"});
        localStorageInMemory.TryAdd(90690000, new CEPViewModel(){CEP=90690000, Estado="RS", Cidade="Porto Alegres", Bairro="Partenon", Logradouro="Ipiranga"});
        localStorageInMemory.TryAdd(92110001, new CEPViewModel(){CEP=92110001, Cidade="Canoas", Estado="RS", Bairro="Niteroi", Logradouro="Venancio Aires"});

    }

    public CEPViewModel? CadastrarCEP(CEPViewModel CEP)
    {
        localStorageInMemory.TryAdd(CEP.CEP, CEP);
        return CEP;
    }

    public IEnumerable<CEPViewModel> listaCEPs()
    {
        return localStorageInMemory.Values;
    }

    public CEPViewModel? pesquisaCEP(int CEP)
    {
        throw new NotImplementedException();
    }
}