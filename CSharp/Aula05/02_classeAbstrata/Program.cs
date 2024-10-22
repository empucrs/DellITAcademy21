namespace _02_classeAbstrata;
class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[]{ "Ana", "Bruno", "Carlos", "Diana", "Eduardo", 
                                    "Fernanda", "Gabriel", "Helena", "Isabela", "João",
                                    "Larissa", "Marcelo", "Nathalia", "Otávio", "Paula"};

        Funcionario [] lista = new Funcionario[10];

        Random r = new Random();
        for(int i=0; i<lista.Length; i++)
            if(r.NextInt64()%2==0)
                lista[i]=new Atendente(nomes[r.Next()%nomes.Length], 20+r.Next()%25, 10.0+r.NextDouble()*40.0);
            else
                lista[i]=new Diretor(nomes[r.Next()%nomes.Length], 44, 50.0+r.NextDouble()*70.0, 600.0+r.NextDouble()*900.0);

        foreach (var funcionario in lista)
            Console.WriteLine(funcionario);

    }
}
