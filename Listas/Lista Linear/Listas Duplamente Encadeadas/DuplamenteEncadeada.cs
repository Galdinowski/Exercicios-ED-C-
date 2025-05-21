using System;



public class ListaDuplamenteEncadeada
{
  public Node? PrimeiroPos { get; set; }
    public Node? UltimoPos {get ;set;}
    public int Tamanho  {get; set;}

    public void AddInicio(int valor)
    {
        var newNode = new Node { Valor = valor };
        if (PrimeiroPos == null)
        {
            PrimeiroPos = UltimoPos = newNode;
        }
        else
        {
            PrimeiroPos.Anterior = newNode;
            newNode.Proximo = PrimeiroPos;
            PrimeiroPos = newNode;
        }

        Tamanho++;
    }

    public void AddFim(int valor)
    {
        var newNode = new Node { Valor = valor };
        if (PrimeiroPos == null)
        {
            PrimeiroPos = UltimoPos = newNode;
        }
        else
        {

            newNode.Anterior = UltimoPos;
            UltimoPos.Proximo = newNode;
            UltimoPos = newNode;

           

        }
        Tamanho++;
    }

    public void RemoveInicio()
    {
        
        if (PrimeiroPos == null)
        {
            Console.WriteLine("Lista vazia, impossivel remover.");
            return;
        }
        if (PrimeiroPos == UltimoPos)
        {
            PrimeiroPos = UltimoPos = null;
        }
        else
        {
            PrimeiroPos = PrimeiroPos.Proximo;
            PrimeiroPos.Anterior = null;


        }
        Tamanho--;

    }


    public void RemoveFinal()
    {

        if (PrimeiroPos == null)
        {
            Console.WriteLine("Lista vazia, impossivel remover.");
            return;
        }
          if (PrimeiroPos == UltimoPos)
        {
        
                 PrimeiroPos = UltimoPos = null;
        }
        else
        {

            UltimoPos = UltimoPos?.Anterior;
            UltimoPos.Proximo = null;

        }
        Tamanho--;

    }

    public void Imprimir()
    {
        Node? atual = PrimeiroPos;

        if (PrimeiroPos == null)
        {
            Console.WriteLine("Lista vazia, nada para imprimir");
        }
        else
        {

            while (atual != null)
            {

                Console.Write(atual.Valor + " -> ");
                atual = atual.Proximo;
            }
            Console.Write("NULL ");
        }

    }

   
}