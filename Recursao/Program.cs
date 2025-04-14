namespace Recursao;


class Program
{

    static int  NumerosNaturais(int numeros)
    {
        if (numeros== 1)
        {
            return 1;
        }
        
        return numeros + NumerosNaturais(numeros-1);
    }



    static bool EhPalindromo( string palavra, int tamanho, int inicio)
    {
        if(inicio >= tamanho)
        {
            return true;
        }

        if (palavra[tamanho] != palavra[inicio])
        {
             
             return false;
        }

           return EhPalindromo(palavra,tamanho-1, inicio+1);

    }


    static int contaPalavra(string palavra, char letra, int tamanho)
    {
         int contaVezes = 0;

        if (tamanho < 0)
        {
            return contaVezes;
        }

        if (palavra[tamanho] == letra)
        {
            return contaVezes +1 + contaPalavra(palavra,letra,tamanho-1);
        }

       return contaPalavra(palavra,letra,tamanho-1);

    }
    static void Main(string[] args)
    {
        string palavra = "radar";
        int tamanho = palavra.Length-1;
        int inicio = 0;
        bool resultado = EhPalindromo(palavra,tamanho,inicio);
        int numeros =6 ;
        int func = NumerosNaturais(numeros);
        //Console.WriteLine(func);

        Console.WriteLine(resultado);
        char letra = 'a';
        int funcConta = contaPalavra(palavra,letra,tamanho);
        Console.WriteLine(funcConta);
       
    }
}
