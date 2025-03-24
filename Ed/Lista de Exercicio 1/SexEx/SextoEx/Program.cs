using System;

class Program
{
    //static int tamanho ;
    //static int contador;
    static string vogais ="aeiouAEIOU";


    static void Vogais (string vog, int contador, int tamanho)
    {
        
        if(tamanho < 0)
        {
            
            Console.WriteLine("");
             Console.WriteLine($"O numero de vogais nesta Palavras é de: {contador}");
            return;
        }

    

            if(vogais.Contains(vog[tamanho]))
            {
                
                contador ++; 
                
                Console.Write($"[{vog[tamanho]}] ");
               
            }
            

             tamanho --;
              
              Vogais(vog,contador,tamanho);
               
                
                 
    }


    static void Main(string[] args)
    {
        string vog = "carnavalesco";
        int tamanho = vog.Length-1;
        int contador = 0;

        Console.WriteLine(contador);
        Console.Write("As vogais presentes sao : ");
        Vogais(vog,contador,tamanho);

    }


}

