public class Estatico{

    private string valor;
    private static string outroValor="um valor qualquer";

    public Estatico(string str)    {
        this.valor=str;
    }
    public static void imprime(){
        Console.WriteLine("Uma mensagem estática (de classe)");
        Console.WriteLine("o conteudo do atribudo valor eh "+outroValor);        
    }

    public void imprimeObj(){
        Console.WriteLine("Uma mensagem dinâmica (de instancia)");
        Console.WriteLine("o conteudo do atribudo valor eh "+valor);        
        Console.WriteLine("o conteudo do atribudo outroValor eh "+outroValor);        
    }
    
}