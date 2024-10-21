namespace SistemaDeBanco.teste;

public class BancoTest
{
    [Fact (Skip = "Teste ainda em desenvolvimento")]
    public void CriacaoDoObjeto()
    {
        // preparação
        Banco b = new();
        // ação
        // afirmação
        Assert.Equal((uint) 0, (uint) b.nClientes());
    }
}