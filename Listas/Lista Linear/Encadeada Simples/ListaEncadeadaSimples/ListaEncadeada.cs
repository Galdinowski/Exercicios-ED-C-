public class ListaEncadeada
{
    private Node? head;
   

    public ListaEncadeada()
    {
        head = null;
    }

    public void AddElemento(int valor)
    {
        Node? novaCabeca = new Node(valor);
        if (head == null)
        {
            head = novaCabeca;
        }else
        {
            Node? atual = head;
             while (atual.Proximo != null)
            {
                atual = atual.Proximo;
            }
              atual.Proximo = novaCabeca;
        }

    }
     public void Imprimir()
    {
        Node? atual = head;
        while (atual != null)
        {
            Console.Write(atual.Valor + " -> ");
            atual = atual.Proximo;
        }
        Console.WriteLine("null");
    }


}