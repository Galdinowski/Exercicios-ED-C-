namespace EX2
{
    using System;
    using System.Collections.Generic;
    using Produtos;

    class Program
    {

        static void OrdenaInsertion( List<Produto>listaP, Produto aux)
        {
            
            for(int i = 1 ; i < listaP.Count; i++ )
            {
                aux = listaP[i];
              
                 int j;

                for( j = i-1 ; j >= 0 && listaP[j].preco  > aux.preco ; j--)
                {
                         listaP[j+1] = listaP[j];

                }

                listaP[j+1] = aux;
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
            OrdenaInsertion(listaP,aux);
            
           
        }
    }
}