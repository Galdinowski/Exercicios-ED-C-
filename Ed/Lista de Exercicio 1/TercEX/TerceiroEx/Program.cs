using System;

class Program

{
    static void ImprimeIntervalo(int n)
    {
        if(n == 0)
        {
            return;
        }
            
        if(n % 2 == 0 && n%3 == 0)
        {
            
            Console.Write($"{n},");

        }
        
         ImprimeIntervalo(n-1);
    }
    

    static void Main(string[] args)
    { 
        int n = 18;
        ImprimeIntervalo(n);
    }

}