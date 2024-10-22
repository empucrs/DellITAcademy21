public class Diretor: Funcionario{
    public double ValorHora{
        get; private set;
    }
    public double Beneficio{
        get; private set;
    }
    public Diretor(string n, int ch, double valorHora, double beneficio):base(n,ch){
        this.ValorHora=valorHora;        
        this.Beneficio=beneficio;
    }

    public override double salario()
    {
        return CargaHoraria*ValorHora*4.5+Beneficio;
    }
}