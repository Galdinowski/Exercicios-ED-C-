using System;
using System.Globalization;


class program
{  
    static double juros;
    static int meses;

    static void Aposentadoria( double montante, double retirada)
    {  
        if(montante < retirada )
        {
             Console.WriteLine($"O total de meses disponiveis para a retirada é de : {meses}") ;
             return;
        }

        
            montante = (montante+(montante*juros))- retirada;
            meses++;
            
            Console.WriteLine(montante.ToString("C2",new CultureInfo("pt-BR")));

             Aposentadoria(montante , retirada);


    }
    static void Main(string[] args)
    {
        double montante = 100000.50;
    
        double retirada = 10000.50;
        meses = 0;
        juros = 0.0055;
         Aposentadoria(montante,retirada);
         

    }



}
