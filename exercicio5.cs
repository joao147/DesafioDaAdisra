using System; 
  
class exercicio5  
{ 
    //Função main
    public static void Main(string[] args) { 
        if (args.Length == 0)
        {
            Console.WriteLine("digite um numero igual ou maior que 1");
            return 1;
        }
        
        int n;//voidariavel que receberá 
        
        bool testar = int.TryParse(args[0], out n);//n recebe o argumento vindo
        //da linha de comando e gera um cariavel para testar se é um numero;
        
        if(testar){
            printGolomb(n);//print a sequencia, e dentro desta função é feita a 
            //chamada da função que gera o vetor
        }else{
            Console.WriteLine("digite um numero igual ou maior que 1");
            return 1;
        }
    }
    
    //encontra a sequencia por recursividade
    static int escontrarSequencia(int n) { 
        
        if (n == 1) return 1;
            
        return 1 + escontrarSequencia(n - escontrarSequencia(escontrarSequencia(n - 1)));
        //Escrevi a formula "1 + a(n-a(n-1))", só que com o nome da função que dei
    } 
      
    //printa no console a sequencia
    static void mostrarSequencia(int n) { 
        for (int i = 1; i <= n; i++)//começa em 1, pois não faz sentido começar com 0 nessa sequencia
            Console .Write(escontrarSequencia(i) + ", ");  
    } 
}
