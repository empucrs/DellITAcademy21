public class ContaSimples : ContaAbstrata
{
    public ContaSimples(double valorASerDepositado){
        this.deposito(valorASerDepositado);
    }
    public override bool deposito(double valor){
        if(valor<=0) return false;
        Saldo+=valor;
        return true;        
    }

    public override bool saque(double valor)
    {
        if(valor<=0) return false;
        if(Saldo-valor<0) return false;

        Saldo-=valor;
        return true;
    }
}