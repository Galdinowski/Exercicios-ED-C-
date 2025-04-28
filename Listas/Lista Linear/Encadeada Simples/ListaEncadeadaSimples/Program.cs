using System;

class Program
{
 
    static unsafe void Main(string[] args)
    {
        Node primeiro = new Node(10);
         Node segundo = new Node(20);
          Node ultimo = new Node(30);
          
          NodePonteiros pontPrimeiro;
          NodePonteiros pontSegundo;
          pontPrimeiro.valor = 50;
          pontSegundo.valor = 60;

          pontPrimeiro.proximoNo = &pontSegundo;

          primeiro.Proximo = segundo;
          segundo.Proximo = ultimo;

          int* p2Valor = &pontSegundo.valor;

          Node atual = primeiro;

          while(atual != null)
          {
            Console.WriteLine(atual.Valor);
            atual = atual.Proximo;
          }
            Console.WriteLine("Usando ponteiro puro: ");
           Console.WriteLine(pontPrimeiro.valor);          // 10
          Console.WriteLine(pontPrimeiro.proximoNo->valor);
          Console.WriteLine("");
          Console.WriteLine((ulong)&pontPrimeiro.valor);
           Console.WriteLine(*p2Valor);


         
        ListaEncadeada lista = new ListaEncadeada();

        lista.AddElemento(90);
         lista.AddElemento(5640);
           lista.AddElemento(150);

        lista.Imprimir();
    }
}