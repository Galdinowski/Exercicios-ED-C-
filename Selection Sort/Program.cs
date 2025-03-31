namespace Selection_Sort;

class Program
{
    static void Selection(int[] vet)
    {
         for(int i = 0 ; i < vet.Length ; i++)
        {
            int menor = i;

            for (int j = i+1; j < vet.Length; j++)
            {
                if (vet[j] < vet[menor])
                {
                    menor = j;
                    
                
                }
                  
            }

                    int aux = vet[i];
                    vet[i] = vet[menor];
                    vet[menor] = aux;

          
        }


        foreach (var item in vet)
        {
            Console.Write($"{item},");
        }

    }
    static void Main(string[] args)
    {
        int[] vet = {2,3,5,10,8,0,99,45,75,6,1};
        Selection(vet);

    }
}
