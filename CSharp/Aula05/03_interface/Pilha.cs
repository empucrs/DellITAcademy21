public class Pilha : IPilha, ITeste01, ITeste02
{
    private Object [] lista;
    private int count;
    public Pilha(){
        lista = new object[10];
        count=0;
    }

    public object? Topo{
        get{
            return (count>0)?lista[count-1]:null;
        }
    }

    public object? desempilha()
    {
        if(count>0)
            return lista[--count];
        return null;
    }

    public void empilha(object o)
    {
        if(count<lista.Length)
            lista[count++]=o;
    }
    public void teste01(){
        Console.WriteLine("Uma implementação que deve valer tanto para ITeste01 quanto ITeste02");
    }
    void ITeste01.teste02(){
        Console.WriteLine("Uma implementação que só vale para ITeste01");
    }

    void ITeste02.teste02(){
        Console.WriteLine("Uma implementação que só vale para ITeste02s");
    }


}