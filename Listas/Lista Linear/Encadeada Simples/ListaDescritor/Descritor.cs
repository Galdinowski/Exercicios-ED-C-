using System;

public class DescritorNode
{
    public Node? PrimeiroPos;
     public Node? UltimaPos;
     public int Tamanho;

     public DescritorNode()
    {
        PrimeiroPos = null;
        UltimaPos = null;
        Tamanho = 0;
    }

    public void AddElementoNoFim(int valor)
    {
        Node novoNode = new Node(valor);

        if (PrimeiroPos == null)
        {
            PrimeiroPos = novoNode;
            UltimaPos = novoNode;
        }else if(UltimaPos!=null)
        {
            UltimaPos.Proximo =novoNode;
            UltimaPos = novoNode;
        }

        Tamanho++;

    }

    public void AddElementoNoInicio(int valor)
    {
        Node novoNode = new Node(valor);

        if (PrimeiroPos == null)
        {
            PrimeiroPos = novoNode;
            UltimaPos = novoNode;
        }
        else
        {
            novoNode.Proximo = PrimeiroPos;
            PrimeiroPos = novoNode;

        }
        Tamanho++;
    }

    public void RemoveElementoNoInicio()
    {


        if (PrimeiroPos == null)
        {
            Console.WriteLine("Lista vazia");
        }
        else
        {
            PrimeiroPos = PrimeiroPos.Proximo;
        }
        Tamanho--;
       
    }
    public void Imprimir()
    {
        Node? atual = PrimeiroPos;
        while (atual != null)
        {
            Console.Write(atual.Valor + " -> ");
            atual = atual.Proximo;
        }
        Console.WriteLine("null");
        Console.WriteLine(PrimeiroPos.Proximo);
        Console.WriteLine(Tamanho);
    }
}