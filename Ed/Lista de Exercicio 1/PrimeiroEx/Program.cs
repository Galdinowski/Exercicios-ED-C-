using System;

class Program 
{
        static void Recursao(int n)
    {
        if(n == 0)
        {
            return;    
        }

       
        if(n%2 == 0)
        {
            Recursao(n-1);
            Console.Write($"{n},");
           

        }else
        {
            Recursao(n-1);
            
        }


    }

        static void Main(string[] args)
        {
            int n = 12;
        Recursao(n);

        }
}