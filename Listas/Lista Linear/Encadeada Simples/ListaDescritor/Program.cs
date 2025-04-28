using System;

class Program
{
    static void Main(string[] args)
    {
       DescritorNode lista = new DescritorNode();

        lista.AddElementoNoFim(10);
        lista.AddElementoNoFim(20);
          lista.AddElementoNoFim(30);

          lista.Imprimir();
    }
}