class CadastroCliente
{

    private Cliente [] lista;

    public Cliente this[int id]{
        get{ 
            Cliente x = new Cliente (lista[id].Nome);
            return x;
        }
        set{ lista[id] = value;}
    }
    public CadastroCliente (int capacidade){
        lista = new Cliente [capacidade];
    }
    
}