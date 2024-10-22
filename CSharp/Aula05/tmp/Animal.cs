class Animal{
    
    private string nome;
    private string Nome{
        get{return nome;}
        set{this.nome=value;}
    }

    private decimal peso;
    public decimal Peso{
        get{ return peso;}
        set{ this.peso = (value<0)?0M:value; }
    }

    public Animal(string nome, decimal peso){
        this.nome = nome;
        this.peso = peso;
    }

    public virtual string print(){
        string result = string.Empty;

        result += this.GetType().FullName+"{\n";
        result += "  nome:"+this.nome+",\n";
        result += "  peso:"+this.peso+",\n";
        result += "}\n";

        return result;
    }

    public override string ToString()
    {
        return print();
    }

    public virtual string emiteSom(){
        return "um som genérico";
    }

}