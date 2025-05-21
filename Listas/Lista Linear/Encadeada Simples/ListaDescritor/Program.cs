using System;

class Program
{
    static void Main(string[] args)
    {
       DescritorNode lista = new DescritorNode();

       
    
        lista.AddElementoNoFim(10); //10
        lista.AddElementoNoFim(20);//10 20
        lista.AddElementoNoFim(30); // 10 20 30
        lista.AddElementoNoInicio(99); // 99 10 20 30
        lista.AddElementoNoInicio(100); // 100 99 10 20 30
      lista.RemoveElementoNoInicio(); //  99 10 20 30
       lista.RemoveElementoNoInicio(); // 10 20 30

          lista.Imprimir();
    }
}