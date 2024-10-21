class Atendente: Funcionario{
    public double ValorHora{
        get; private set;
    }
    public Atendente(string n, int ch, double valorHora):base(n, ch){
        this.ValorHora=valorHora;
    }

    public override double salario(){
        return this.CargaHoraria*this.ValorHora*4.5;
    }
    
}