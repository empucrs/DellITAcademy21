class Cliente{
    private string nome;
    public string Nome{
        get{return nome;}
    }
    private decimal limiteCredito;
    private uint clienteID;

    public string Propriedade{
        get{return "alguma coisa";}
    }

    public string oiStr;
    public string boraLa{
        get{return oiStr;}
        set{oiStr = value;}
    }

    public const string umTexto = "um texto padrao informado pelo Edson";

    // regra para sobreescrita de métodos (construtor ou demais)
    // deve ter a mesma assinatura (modificador + tipo de retorno + nome do método )
    // deve variar (Quantidade e/ou tipos dos parametros)
    //public Cliente(uint umID, string valorParaOiStr){}
    public Cliente(uint umID){
        this.clienteID = umID;
    }
    public Cliente(string umNome){
        this.nome=umNome;
    }
    // erro -> Já existe um método com um parametro string
    //public Cliente(string umOiStr){}

    public Cliente(string umNome, uint umID){
        this.nome = umNome;
        this.clienteID = umID;
    }

    public Cliente(){
        this.nome="João ninguem";
        this.limiteCredito=0;
        this.clienteID=0;
    }

    // Erro... as variaveis locais a um método precisam ser inicializadas
    /*
    public string metodoComElementosNaoAnulaveis(){
        int xuxu;
        return xuxu.ToString();
    }
    */

    public void aumentaLimite(decimal valor){
        this.limiteCredito+=valor;
        Console.WriteLine(this+"; limite => "+this.limiteCredito);
    }

    public void metodoOut01(int x, int y, int w){
        w=x+y;
    }

    public void metodoOut02(int x, int y, out int w){
        w=x+y;
    }

    // erro de compilação pois o w não está garantidamente inicializado
    /*
    public void metodoOut03(int x, int y, out int w){
        w=x+y+w;
    }
    */
    public void metodoRef04(int x, int y, ref int w){
        w=x+y+w;
    }

    public void metodoRef05(int x, int y, ref int w){
        w=x+y;
    }

    public int metodoParam01(params int [] valores){
        int resultado=0;

        foreach(int i in valores)
            resultado+=i;

        return resultado;

    }





}