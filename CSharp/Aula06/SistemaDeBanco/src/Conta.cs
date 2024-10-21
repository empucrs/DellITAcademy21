public enum tipoDeConta {simples, poupanca, corrente};
public abstract class ContaAbstrata{
    public double Saldo { get; protected set; }
    public DateTime DataDaCriacao { get; }
    public uint ID{get; }
    private static uint sequenciadoDeID=1;

    public ContaAbstrata(){
        this.Saldo = 0;
        this.DataDaCriacao = DateTime.Now;
        this.ID = sequenciadoDeID++;
    }

    public abstract Boolean saque(double valor);
    public abstract Boolean deposito(double valor);
    
}