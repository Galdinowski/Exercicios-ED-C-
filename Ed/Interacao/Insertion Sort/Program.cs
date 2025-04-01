namespace Insertion_Sort;

class Program
{

    static void Insertion_Sort(int[] vet)

    {  
        

        for (int i = 1; i < vet.Length; i++)
        {
            int pivor = vet[i];
            int j;
            
            for( j = i-1 ; j>=0 && vet[j] > pivor ; j--)
            {
                vet[j+1] = vet[j]; 
                
                
            }
              vet[j+1] = pivor;
        }

        foreach (var item in vet)
        {
            Console.Write($"{item} ");
        }

    } 

    
    static void Main(string[] args)
    {
        int[] vet = {10,0,2,4,3};
       
        Console.Write("Vetor original: ");
         foreach (var item in vet)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
        Console.Write("Vetor Ordenado: ");
        
        Insertion_Sort(vet);

        
    }
}
