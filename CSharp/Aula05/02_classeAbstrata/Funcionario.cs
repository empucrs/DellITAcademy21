public abstract class Funcionario
{
    public string Nome{
        get; private set;
    }
    public int CargaHoraria{
        get; private set;
    }

    public Funcionario(string n, int ch){
        this.Nome=n;
        this.CargaHoraria=ch;   
    }

    public abstract double salario();

    public override string ToString()
    {
        return this.GetType().Name+": "+this.Nome+"; R$"+salario();
    }

}