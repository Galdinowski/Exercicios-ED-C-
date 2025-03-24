using System;

class Program
{
    static int tamanho ;
    static int contador;
    static string vogais ="aeiouAEIOU";


    static void Vogais (string vog)
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
              
              Vogais(vog);
               
                
                 
    }


    static void Main(string[] args)
    {
        string vog = "carnavalesco";
        tamanho = vog.Length-1;
        contador = 0;
        Console.Write("As vogais presentes sao : ");
        Vogais(vog);

    }


}

