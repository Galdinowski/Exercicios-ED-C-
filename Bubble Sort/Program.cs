namespace ED;

class Program
{
    static void Main(string[] args)
    {
        int[] vet = {1,9,21,2,3,6,8,15};
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

        foreach (var item in vet)
        {
            Console.Write($"{item} ")  ;
        }       
    } 
}