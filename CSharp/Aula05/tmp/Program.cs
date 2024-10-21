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
    }
}
