namespace SistemaDeBanco.teste;

public class ContaSimplesTest
{
    [Fact]
    public void CriacaoDeContaSimples()
    {
        // Preparação - arrange
        ContaSimples cs = new(100);

        // Ação - Act
        double resultado = cs.Saldo;

        // Afirmação - assert
        Assert.Equal(100, resultado);
    }

    [Theory]
    [InlineData(100, 100)]
    [InlineData(0, 0)]
    [InlineData(-100, 0)]
    public void CriacaoDeContaSimplesTheory(double deposito, double resultadoEsperado)
    {
        // Preparação - arrange
        ContaSimples cs = new(deposito);

        // Ação - Act
        double resultado = cs.Saldo;

        // Afirmação - assert
        Assert.Equal(resultadoEsperado, resultado);
        
    }
}