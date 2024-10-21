class Lampada
{
    private bool estaLigada;
    private int conta;
    private bool lampadaEstragada;

    public void trocaEstado(){
        if(!lampadaEstragada){
            estaLigada = !estaLigada;
            conta++;
            if(conta> 50)
                lampadaEstragada=true;
        }
        else{
            Console.WriteLine("A lampada estragou");
        }
    }

    public bool ligada(){
        return (!lampadaEstragada)&&(estaLigada);
    }
}