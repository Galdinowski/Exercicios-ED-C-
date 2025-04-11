namespace EX1
{
    using System;
    using System.Collections.Generic;
    using Produtos;

    class Program
    {

        static void OrdenaBubble( List<Produto>listaP)
        {
            for(int i = 0 ; i < listaP.Count-1; i++ )
            {
                for(int j = 0; j < listaP.Count-1-i; j++)
                {
                    if(listaP[j].preco > listaP[j+1].preco )
                    {
                        Produto aux = listaP[j];
                        listaP[j] = listaP[j+1];
                        listaP[j+1] = aux;
                    }
                }
            }

            foreach (Produto produto in listaP)
            {
                Console.WriteLine($" O produto {produto.nome} com o preco de R${produto.preco}");
            }


        
        }
        static void Main(string[] args)
        {
        
            List<Produto> listaP = new List<Produto>();
            listaP.Add(new Produto { nome = "TV", preco = 900.54 });
            listaP.Add(new Produto { nome = "Geladeira", preco = 1900 });
            listaP.Add(new Produto { nome = "Fogao", preco = 800.54 });
            listaP.Add(new Produto { nome = "Garfo", preco = 19.24 });


            //Console.WriteLine(listaP.Count);
            OrdenaBubble(listaP);
            
           
        }
    }
}