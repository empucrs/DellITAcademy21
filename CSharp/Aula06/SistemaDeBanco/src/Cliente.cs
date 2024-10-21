public class Cliente{
    public string Nome{get;}
    public DateTime DataDeNascimento{get;}   
    public uint ID{get;}
    private static uint sequenciadoDeID = 1;
    public List<ContaAbstrata> listaDeContas;

    public Cliente(string Nome, DateTime dt){
        this.Nome = Nome;
        this.DataDeNascimento=dt;
        this.ID = sequenciadoDeID++;
        listaDeContas = new();
    }

    public override string ToString(){
        double saldo=0;
        foreach(ContaAbstrata conta in listaDeContas)
            saldo+=conta.Saldo;
        return $"{this.Nome} : Total R$ {saldo}";
    }

    public void criaConta(tipoDeConta tc, double saldoInicial, double LimiteContratado){
        ContaAbstrata novaConta;
        switch(tc){
            case tipoDeConta.simples:
                novaConta=new ContaSimples(saldoInicial);
                break;
            case tipoDeConta.poupanca:
                novaConta=new ContaPoupanca(saldoInicial);
                break;
            default:
                novaConta=new ContaCorrente(saldoInicial, LimiteContratado);
                break;
        }
        listaDeContas.Add(novaConta);
    }


}