using System.Diagnostics;

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

        Object [] listaDePets = new object[5];
        listaDePets[0]= new Animal("coisa", 1.25M);
        listaDePets[1]= new Cachorro("doginho", 5M);
        listaDePets[2]= new Gato("bichano", "12,1");
        Console.WriteLine("xxxxxxx");
        foreach(Object o in listaDePets){
            Console.WriteLine(o??"objeto não existe");            
            if(o is Animal) Console.WriteLine((o as Animal)?.print());
            if(o is Cachorro) Console.WriteLine((o as Cachorro)?.print());
            if(o is Gato) Console.WriteLine((o as Gato)?.print());
            Console.WriteLine("---------");
        }

        Estatico.imprime();
        Estatico e = new("um novo valor");
        e.imprimeObj();
        
    }
}
