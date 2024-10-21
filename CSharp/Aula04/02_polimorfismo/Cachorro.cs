class Cachorro: Animal{

    public Cachorro(string nome, decimal peso): base(nome, peso) { }

    public override string ToString()
    {
        return "A classe é a " + this.GetType().Name + "\n";
    }

    public new string print(){
        return "Um texto elaborado a partir do cachorro usando o new";
    }

    public override string emiteSom()
    {
        return "au au au au";
    }

    public void pega(){
        Console.WriteLine("Partiu graveto...");
    }

}