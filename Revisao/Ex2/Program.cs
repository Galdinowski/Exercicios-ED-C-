/*2) Faça um procedimento que receba por parâmetro um vetor de números reais (chamado numeros)
e um número inteiro (chamado opção). Se a opção for igual a 1, o procedimento deve ordenar o 
vetor recebido por parâmetro pelo método da inserção. Se a opção for igual a 2, o 
procedimento deve ordenar o vetor recebido por parâmetro pelo método da seleção. Caso 
contrário, deve utilizar o método bolha.*/

namespace Ex2;

class Program
{

    static void Insertion(int[] vet)
    {

    }

    static void Selection(int[] vet)
    {
        for (int i = 0; i < vet.Length; i++)
        {
            int indMenor = i;
        
            for (int j = i+1; j < vet.Length; j++)
            {
                if (vet[j] < vet[indMenor])
                {
                     indMenor = j;
                }
               
            }

                int aux = vet[i];
                vet[i] = vet[indMenor];
                vet [indMenor] = aux;

        }

         Console.WriteLine("");
        foreach (var item in vet)
        {
            Console.WriteLine(item);
        }


    }

    static void Bubble(int[] vet)
    {
        int aux;
        for (int i = 0; i < vet.Length; i++)
        {
            for (int j = 0; j < vet.Length-1; j++)
            {
                if (vet[i] < vet[j])
                {
                    aux = vet[i];
                    vet[i] = vet[j];
                    vet[j] = aux;
                }
            }
        }
        Console.WriteLine("");
        foreach (var item in vet)
        {
            Console.WriteLine(item);
        }

    }

    static void Verifica(int verificando,int[] vet)
    {
        if(verificando == 1)
        {
            Insertion(vet);
            Console.WriteLine("INSER");
        }
        else if(verificando == 2)
        {
            Selection(vet);
           
        }else{
            Bubble(vet);
            
        }
    }
    static void Main(string[] args)
    {
        int[] vet = {1,3,0,6,32};
      int verificando;
        Console.WriteLine("Hello, World!");
        //verificando = int.Parse(Console.ReadLine());
        Verifica(2,vet);
    }
}
