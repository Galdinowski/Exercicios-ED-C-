namespace SelectionSort;

class Program
{

    static void SelectionSort(int[] vet)
    {
        int indice;
        for (int i = 0; i < vet.Length; i++)
        {
             indice = i;
            for (int j = i+1; j < vet.Length; j++)
            {
                if (vet[j] < vet[indice])
                {
                    indice = j;
                }
            }

                            int aux = vet[i];
                            vet[i] = vet[indice];
                            vet[indice] = aux;
        }

            foreach (var item in vet)
            {
                Console.Write($"{item},");
            }

    }

    static void InsertionSort(int[] vet)
    {
        int j;
        for (int i = 1; i < vet.Length; i++)
        {
            int aux = vet[i];
            for ( j = i-1; j>=0 && vet[j] > aux; j--)
            {
               vet[j+1] = vet[j];
                
            }

            vet[j+1] = aux;
                
        }

        foreach (var item in vet)
        {
            Console.Write($"{item},");
        }
    }
    static void Main(string[] args)
    {
        int[] vet = {1,3,0,5,6,8,2};
        SelectionSort(vet);
        Console.WriteLine("");
        InsertionSort(vet);
    }
}