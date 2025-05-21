using System;

namespace ED;

class Program
{
    static void Main(string[] args)
    {
        int[] vet = {1,9,21,2,3,6,8,15};
        int[] vetor = {10,20,30,40,50,60};
        int aux;
        

        for(int i = 0; i < vet.Length-1;i++)
        {

            for(int j = 0 ; j < vet.Length-1 ; j++)
            {
                if(vet[j] > vet[j+1])
                {
                    aux = vet[j];
                    vet[j] = vet[j+1];
                    vet[j+1] = aux;
                    
                }
            }
        }

             Console.WriteLine("Bubble");
        foreach (var item in vet)
        {
           
            Console.Write($" {item} ")  ;
        }
            Console.WriteLine("");
                Console.WriteLine("APS");

        for (int i = 0; i < 3; i++)

                {

                    aux = vetor[i];

                    vetor[i] = vetor[6 - 1 - i];

                    vetor[6 - 1 - i] = aux;

                }       

                foreach (var item in vetor)
                {
                    Console.Write($"{item},");
                }
     } 
}