namespace _02_polimorfismo;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Animal a = new("toto", 12.5M);
        Console.WriteLine(a);
        Console.WriteLine(a.emiteSom());
        Console.WriteLine("-=-=-=-=-=-=-");

        a = new Cachorro("rex", 12.75M);
        Console.WriteLine(a);
        Console.WriteLine(a.print());
        Console.WriteLine(a.emiteSom());
        // Erro em tempo de projeto/compilação pq o método não é conhecido pela classe base
        //a.pega();

        Console.WriteLine("a é um Animal?   "+ (a is Animal));
        Console.WriteLine("a é um Cachorro? "+ (a is Cachorro));
        Console.WriteLine("a é um Gato?     "+ (a is Gato));

        if(a is Cachorro){
            Console.WriteLine("Atuando como cachorro");
            Console.WriteLine((a as Cachorro));
            Console.WriteLine((a as Cachorro)?.print());
            Console.WriteLine((a as Cachorro)?.emiteSom());
            (a as Cachorro)?.pega();
        }

        a = new Gato("mito", "2,45");
        Console.WriteLine(a);
        Console.WriteLine(a.print());
        Console.WriteLine(a.emiteSom());
        // Erro em tempo de projeto/compilação pq o método não é conhecido pela classe base
        //a.pega();

        Console.WriteLine("a é um Animal?   "+ (a is Animal));
        Console.WriteLine("a é um Cachorro? "+ (a is Cachorro));
        Console.WriteLine("a é um Gato?     "+ (a is Gato));

        if(a is Gato){
            Console.WriteLine("Atuando como gato");
            Console.WriteLine((a as Gato));
            Console.WriteLine((a as Gato)?.print());
            Console.WriteLine((a as Gato)?.emiteSom());
            (a as Gato)?.missi();
        }

public class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public int Subtrair(int a, int b)
    {
        return a - b;
    }
}

    }
}


using Xunit;

public class CalculadoraTests
{
    private readonly Calculadora _calculadora;

    public CalculadoraTests()
    {
        _calculadora = new Calculadora();
    }

    // Teste com Fact (um cenário específico)
    [Fact]
    public void Somar_DeveRetornarSomaCorreta()
    {
        // Arrange
        int a = 2;
        int b = 3;

        // Act
        int resultado = _calculadora.Somar(a, b);

        // Assert
        Assert.Equal(5, resultado);
    }

    // Teste com Theory (vários cenários)
    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(-2, -3, -5)]
    [InlineData(100, 50, 150)]
    [InlineData(-10, 20, 10)]
    public void Somar_DeveRetornarSomaCorretaParaVariosValores(int a, int b, int esperado)
    {
        // Act
        int resultado = _calculadora.Somar(a, b);

        // Assert
        Assert.Equal(esperado, resultado);
    }

    // Teste com Fact
    [Fact]
    public void EhPositivo_DeveRetornarTrueParaPositivos()
    {
        // Arrange
        int numero = 10;

        // Act
        bool resultado = _calculadora.EhPositivo(numero);

        // Assert
        Assert.True(resultado);
    }

    // Teste com Theory
    [Theory]
    [InlineData(10, true)]
    [InlineData(-5, false)]
    [InlineData(0, false)]
    public void EhPositivo_DeveRetornarCorretoParaDiversosValores(int numero, bool esperado)
    {
        // Act
        bool resultado = _calculadora.EhPositivo(numero);

        // Assert
        Assert.Equal(esperado, resultado);
    }
}
