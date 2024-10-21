using System.Data.SqlTypes;

class Cachorro : Animal{
    public string Raca{
        get;
        private set;
    }
    public Cachorro():base("sem detalhes na criação"){
        this.Raca="sem detalhes na criação";
    }  
    public Cachorro(string nome, string especie, string classificacao, string raca):base(nome, especie, classificacao){
        this.Raca = raca;
    }
    public void alteraRaca(string raca){
        this.Raca=raca;        
    }
    public void alteraNome(string nome){
        this.Nome=nome;        
    }

    public void alteraClassificacao(string classificacao){
        setClassificacao(classificacao);
        Raca="uma nova raça";
    }

    public override string print(){
        string result;
        result = this.GetType().Name+"{\n";
        result += base.print()+",\n";
        result += "  Raca="+this.Raca+"\n}";
        return result;
    }

    public override string ToString()
    {
        return base.ToString()+" au au au au";
    }

}