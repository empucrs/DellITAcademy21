namespace _01_heranca;
class Program
{
    static void Main(string[] args)
    {
        Animal a = new("Bimbo", "cão", "mamífero");
        Console.WriteLine(a);
        Console.WriteLine("a.Nome="+a.Nome);
        Console.WriteLine("a.Especie="+a.Especie);
        Console.WriteLine("a.Classificao="+a.Classificacao);
        Console.WriteLine(a.print());

        Console.WriteLine("-=-=-=-=-=-=-=-");
        Cachorro c = new();
        Console.WriteLine(c);
        Console.WriteLine("c.Nome="+c.Nome);
        Console.WriteLine("c.Especie="+c.Especie);
        Console.WriteLine("c.Classificao="+c.Classificacao);
        Console.WriteLine(c.print());

        c.alteraClassificacao("doguinho");
        Console.WriteLine(c.print());
    }
}
