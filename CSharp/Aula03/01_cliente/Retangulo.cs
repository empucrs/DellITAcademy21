class Retangulo
{
    private int x,y; // canto inferior esquerdo
    private int altura, largura;

    public int umaPropriedade{
        get; private set;
    }
    public int xInfEsquerdo{
        get{ return x; }
        private set{ x = value; }
    }
    public int yInfEsquerdo{
        get { return y; }
    }
    public int xSupEsquerdo{
        get{ return xInfEsquerdo; }
    }

    public int ySupEsquerdo{
        get{ return y+altura; }
    }

    public int xInfDireito{
        get{ return x+largura;}
    }

    public int xSuperiorDireito{
        get{return xInfDireito;}
    }

    public int yInfDireito{
        get{return y;}
    }
    public int ySuperiorDireito{
        get{return ySupEsquerdo;}
    }
    

    public Retangulo(int x, int y, int altura, int largura){
        this.x = x;
        this.y = y;
        this.altura = altura;
        this.largura = largura;
    }
}