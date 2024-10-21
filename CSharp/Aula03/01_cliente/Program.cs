// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Cliente c = new Cliente("Jose Adroaldo", 10);
Console.WriteLine(c);

Console.WriteLine(Cliente.umTexto);
// Erro... somente pode-se acessar a constante a partir da definição da classe.
//Console.WriteLine(c.umTexto);

c.aumentaLimite(1000.99M);

Lampada l = new Lampada();
Console.WriteLine("Lampada ligada? "+l.ligada());
l.trocaEstado();
Console.WriteLine("Lampada ligada? "+l.ligada());

/*
for(int i=0; i<60; i++){
    l.trocaEstado();
    Console.WriteLine("Lampada ligada? "+l.ligada());
}
*/
// MODIFICADORES DE METODOS (OUT/REF/PARAM)
int a=10;
int b=20;
int d=5;

c.metodoOut01(a, b, d);
Console.WriteLine(" => "+d);

c.metodoOut02(a, b, out d);
Console.WriteLine(" => "+d);

c.metodoRef04(a, b, ref d);
Console.WriteLine(" => "+d);

//int e;
// Erro... a variavel ref precisa ter sido inicializada para ser passada por paramentro
//c.metodoRef05(a, b, ref e);
//Console.WriteLine(" => "+e);

int [] listaDeValores = new int[5]{1,2,3,4,5};
Console.WriteLine(c.metodoParam01(listaDeValores));

Console.WriteLine(c.metodoParam01(1,2,3));

Console.WriteLine(c.metodoParam01(1,3,5,7,9,11,13,15,17,19));

Console.WriteLine(c.Propriedade);

// erro - propriedade construida como readonly
//c.Propriedade = "alguma informação";

c.oiStr = "Edson";
Console.WriteLine(c.oiStr);
Console.WriteLine(c.boraLa);

c.boraLa = "Moreno";
Console.WriteLine(c.oiStr);
Console.WriteLine(c.boraLa);


Cliente x = new Cliente("Edson", 10083346);
x = new Cliente();

CadastroCliente cc = new CadastroCliente(10);

cc[9] = new Cliente("Edson Moreno",10);
cc[1] = new Cliente();
cc[5] = new Cliente("Um nome qualquer");

for(int i=0; i<10; i++)
    Console.WriteLine(" Cliente => "+ cc[i]?.Nome);