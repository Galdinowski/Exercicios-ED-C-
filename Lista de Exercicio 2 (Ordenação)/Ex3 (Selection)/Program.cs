namespace EX2
{
    using System;
    using System.Collections.Generic;
    using Produtos;

    class Program
    {

        static void OrdenaSelection( List<Produto>listaP)
        {
          
            for(int i = 0; i < listaP.Count-1; i++ )
            {
                int indiceMenor = i;
              
                 int j;

                for( j = i+1 ; j < listaP.Count ; j++)
                {
                        if (listaP[j].preco < listaP[indiceMenor].preco)
                        {
                             indiceMenor = j;
                            
                        }
                }
                            Produto aux = listaP[i];
                            listaP[i] = listaP[indiceMenor];
                            listaP[indiceMenor] = aux;

                
            }

            foreach (Produto produto in listaP)
            {
                Console.WriteLine($" O produto {produto.nome} com o preco de R${produto.preco}");
            }


        
        }
        static void Main(string[] args)
        {
            Produto aux = new Produto();
            List<Produto> listaP = new List<Produto>();
            listaP.Add(new Produto { nome = "TV", preco = 900.54 , codigo =1});
            listaP.Add(new Produto { nome = "Geladeira", preco = 1900 , codigo = 4});
            listaP.Add(new Produto { nome = "Fogao", preco = 800.54 , codigo = 3});
            listaP.Add(new Produto { nome = "Garfo", preco = 19.24 , codigo = 2});


            //Console.WriteLine(listaP.Count);
            OrdenaSelection(listaP);
            
           
        }
    }
}