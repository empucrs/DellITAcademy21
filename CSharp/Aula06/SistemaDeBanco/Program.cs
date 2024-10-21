Banco b = new();

string[] nomes = new string[]
{
    "Ana",
    "Bruno",
    "Carlos",
    "Diana",
    "Eduardo",
    "Fernanda",
    "Gabriel",
    "Helena",
    "Isabela",
    "João",
    "Larissa",
    "Marcelo",
    "Nathalia",
    "Otávio",
    "Paula"
};

Random r = new();

for(int i=0; i<10; i++)
    b.cadastraCliente(nomes[r.Next()%nomes.Length], new DateTime(2024-(18+(r.Next()%43)), 1+r.Next()%12, 1+r.Next()%28));

b.listaClientes();

for(int i=0; i<100; i++){
    int tipo = r.Next()%3;
    tipoDeConta tipoC;

    if(tipo==0) tipoC=tipoDeConta.simples;
    else if(tipo==1) tipoC=tipoDeConta.poupanca;
    else tipoC=tipoDeConta.corrente;
    
    b.cadastraConta((uint) (1+r.Next()%10), tipoC, 50+r.NextDouble()*4950, r.NextDouble()*2000);
}

b.detalhaCliente(3);
Console.WriteLine("-=-=-==-=-=-=");
b.detalhaCliente(1000);
    