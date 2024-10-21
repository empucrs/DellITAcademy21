class ContaCorrente : ContaPoupanca
{
    private double LimiteContratado;
    public ContaCorrente(double valorASerDepositado, double lcontratado) : base(valorASerDepositado){
        if(lcontratado<100) this.LimiteContratado=100;
        else if(lcontratado>1000) this.LimiteContratado=1000;
        else this.LimiteContratado=lcontratado;
    }

    public override bool saque(double valor){
        if(valor<=0) return false;
        if(valor>(Saldo+LimiteContratado)) return false;

        Saldo-=valor;
        return true;
    }

    public override void operacaoExtraordinaria(double valorReferencial){
        if(Saldo<0){
            double valorDeJuros = (Saldo*-1)*valorReferencial;
            Saldo-=valorDeJuros;
        }
    }
}