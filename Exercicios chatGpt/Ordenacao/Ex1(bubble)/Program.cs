namespace Ex1_bubble_;
using System;
using System.Collections.Generic;
using Estudante;

class Program
{
    static void OrdenaBubble(List<Aluno> estudante)
    {
        Aluno aux ;
        for (int i = 0; i < estudante.Count; i++)
        {  
           for (int j = 0; j < estudante.Count; j++)
           {
                if (estudante[i].Nota < estudante[j].Nota )
                {
                    aux = estudante[i];
                    estudante[i] = estudante[j];
                    estudante[j] = aux;
                }
           } 
        }

        foreach (var item in estudante)
        {
            Console.WriteLine(item);
        }
    }


    static void Insertion (List<Aluno> estudante)
    {
       
        for (int i = 0; i < estudante.Count; i++)
        {
            Aluno menor = estudante[i];
            for (int j = 0; j < estudante.Count; j++)
            {
                if (estudante[j].Nota> menor.Nota)
                {
                    menor = estudante[j];
                }
                estudante[j] = estudante[i];
                estudante[i] = menor;
            }
        }
            Console.WriteLine("SDIJSDHSIFIFJIEF");
        foreach (var item in estudante)
        {
            Console.WriteLine(item);
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

        
            //OrdenaBubble(estudante);
            Insertion(estudante);
    }
}
