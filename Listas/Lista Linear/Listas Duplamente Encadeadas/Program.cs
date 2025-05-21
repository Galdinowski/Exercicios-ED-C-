using System;

  Console.WriteLine("Adicionando no INICIO DE UMA LISTA DUPLAMENTE ENCAD");
    ListaDuplamenteEncadeada lista = new();
    lista.AddInicio(10);
    lista.AddInicio(32);
    lista.AddInicio(50);
lista.AddInicio(69);
 lista.Imprimir();
lista.RemoveFinal();
      Console.WriteLine("");
    lista.Imprimir();
  Console.WriteLine("");
    Console.WriteLine("Tamanho da lista : " + lista.Tamanho);
    
