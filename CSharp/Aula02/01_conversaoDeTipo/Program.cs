namespace _01_conversaoDeTipo;
class Program
{
    static void Main(string[] args)
    {
        // CONVERSAO ENTRE TIPOS + COERSÃO(CAST)
        int i = 123;
        Console.WriteLine("i = "+i);
        long l = i;
        Console.WriteLine("l = "+l);
        short s = (short)i;
        Console.WriteLine("m = "+s);

        double d = 1.2579;
        Console.WriteLine("d = "+d);
        float f = (float) d;
        Console.WriteLine("f = "+f);
        l = (long)d; 
        Console.WriteLine("l = "+l);
        i = (int)d;
        Console.WriteLine("i = "+i);

        // TIPOS ANULAVEIS
        int x=0;
        Console.WriteLine("x="+x);
        int? y=null;
        Console.WriteLine("y="+y);

        string str1="Dell IT Academy 21";
        Console.WriteLine("s="+str1);
        string? str2=null;
        Console.WriteLine("s="+(str2 ?? "o valor está nulo" ));

        Console.WriteLine("s."+str1.ToUpper());
        Console.WriteLine("s."+str2?.ToUpper().ToLower().ToString().Length );

        // array
        int [] vetor = new int[5];
        int [,] matriz = {{1,2},{3,4}};
        
        int [][] jagged = new int[2][];
        jagged[0] = new int[2];
        jagged[1] = new int[2];
        for(int lin=0;lin<2;lin++){
            vetor[lin] = lin*10;
            for(int col=0; col<2; col++){
                jagged[lin][col]=(lin+col+1)*10;
            }
        }

        foreach(int valor in vetor){
            Console.WriteLine("  Vetor => "+valor);
        }

        for(int lin=0; lin<2; lin++){
            for(int col=0; col<2; col++){
                Console.WriteLine(" -> Matriz ["+lin+"]["+col+"]: "+matriz[lin,col]);
            }
        }  

        for(int lin=0; lin<2; lin++){
            for(int col=0; col<2; col++){
                Console.WriteLine(" ::> Jagged ["+lin+"]["+col+"]: "+jagged[lin][col]);
            }
        }  


    }
}
