class Gato: Animal{

    public Gato(string nomeDoBichano, string pesoDoAnimal): base(nomeDoBichano, Decimal.Parse(pesoDoAnimal)) { }

    public override string ToString()
    {
        return "A classe é o gatinho\n";
    }

    public override string print(){
        return "Um texto elaborado a partir do gatinho usando o override";
    }

    public override string emiteSom()
    {
        return "miauuuuuuuuuuuuuuuu";
    }

    public void missi(){
        Console.WriteLine("ronroando um pouco...");
    }

}