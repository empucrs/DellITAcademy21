namespace _03_interface;
class Program
{
    static void Main(string[] args)
    {
        Pilha p = new();
        p.empilha(new string("Edson"));
        p.empilha(1234);
        p.empilha(4.321);
        p.empilha(true);

        Console.WriteLine(p.Topo);        
        p.desempilha();
        Console.WriteLine(p.Topo);        
        p.desempilha();
        Console.WriteLine(p.Topo);        
        p.desempilha();
        Console.WriteLine(p.Topo);        
        p.desempilha();

        exploraInterface01a(p);
        exploraInterface01b(p);
        exploraInterface02a(p);
        exploraInterface02b(p);
    }

    private static void exploraInterface01a(ITeste01 i1){
        i1.teste01();
    }
    private static void exploraInterface01b(ITeste02 i2){
        i2.teste01();
    }
    private static void exploraInterface02a(ITeste01 i1){
        i1.teste02();
    }
    private static void exploraInterface02b(ITeste02 i2){
        i2.teste02();
    }
}
