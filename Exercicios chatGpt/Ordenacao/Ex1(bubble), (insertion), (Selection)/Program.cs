namespace Ex1_bubble_;
using System;
using System.Collections.Generic;
using Estudante;

class Program
{
    static void OrdenaBubble(List<Aluno> estudante)
    {
        Aluno indiceMneor ;
        for (int i = 0; i < estudante.Count; i++)
        {  
           for (int j = 0; j < estudante.Count; j++)
           {
                if (estudante[i].Nota < estudante[j].Nota )
                {
                 indiceMneor = estudante[i];
                    estudante[i] = estudante[j];
                    estudante[j] = indiceMneor;
                }
           } 
        }

        foreach (var item in estudante)
        {
            Console.WriteLine(item);
        }
    }


    static void Insertion(List<Aluno> estudante)
    {
        for (int i = 1; i < estudante.Count; i++)
        {
            Aluno maior = estudante[i];
            int j;
            for ( j = i-1; j >= 0 && estudante[j].Nota < maior.Nota; j--)
            {
               estudante[j+1] = estudante[j];
            }
            estudante[j+1] = maior;
        }

        foreach (var item in estudante)
        {
            Console.WriteLine(item);
        }

    }


    static void Selection (List<Aluno> estudante)
    {
           
        
        for (int i = 0; i < estudante.Count-1; i++)
        {
            int indiceMneor = i;
           
            int j;
            for ( j = i+1; j < estudante.Count; j++)
            {
            
                if(estudante[j].Nota > estudante[indiceMneor].Nota)
                {
                    
                    indiceMneor = j;

                }
                
            }

                Aluno estudanteAux= estudante[i];
                estudante[i] = estudante[indiceMneor];
                estudante[indiceMneor] = estudanteAux;
        }

        foreach (var item in estudante)
        {
            Console.WriteLine(item);
        }

    }


    static void SelectionNumeros(int[] vet)
    {
        for (int i = 0; i < vet.Length; i++)
        {
            int indiceMneor = i;
            int j;
            for ( j = i+1; j < vet.Length  ; j++)
            {
                if (vet[j] < vet[indiceMneor])
                {
                      indiceMneor = j;
                }
              
            }

            int aux = vet[i];
            vet[i] = vet[indiceMneor];
            vet[indiceMneor] = aux;
        }

        foreach (var item in vet)
        {
            Console.Write($"{item},");
        }

    }

static void InsertionNumeros(int[] vet)
{
    for (int i = 1; i < vet.Length; i++)
    {
        int aux = vet[i];
        int j;
        for ( j = i-1; j >= 0 && vet[j] > aux ; j--)
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
        List<Aluno> estudante = new List<Aluno>
        {
            new Aluno {Nome = "Arthur", Matricula =  201835035, Nota=8.54},
            new Aluno { Nome = "Bruna", Matricula = 102, Nota = 9.2 },
            new Aluno { Nome = "Carlos", Matricula = 103, Nota = 6.8 },
            new Aluno { Nome = "Daniela", Matricula = 104, Nota = 8.1 }
         };

        int[] vet = {100,1,5,10,-4,8,0,2,99};
        
            //OrdenaBubble(estudante);
           // Insertion(estudante);
           //Selection(estudante);
           // SelectionNumeros(vet);
           InsertionNumeros(vet);
    }
}
