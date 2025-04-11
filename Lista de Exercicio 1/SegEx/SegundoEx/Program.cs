using System;

class Program
{
    static int Recursao(int numero)
    {
        
        if(numero == 0)
        {
            return 0;
           
        }else if(numero % 2 == 0)
            {

                
                
              return numero + Recursao(numero-2);
            }
            else
            {
                return Recursao(numero-1);
                
            }

             

            

        
    }
    static void Main(string[] args )
    {
        int n = 10;
        int func = Recursao(n);
        Console.WriteLine(func);


    }
}


