
using System;
using System.Text;
/*1) Faça uma função recursiva que receba por parâmetro uma string e retorne-a sem os acentos.
Os caracteres acentuados são: 		"ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç"
Os caracteres não acentuados são: 	"AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc"
É proibido o uso de comandos de repetição nesta questão.*/



namespace Ex1;

class Program
{
    static void TiraAcento(string vet,string acentuados,string naoacentos ,StringBuilder sb)
    {
         
          int indiceVet = sb.Length - 1;
         Console.WriteLine(sb);

             while (indiceVet >=0)
             {
                
            
                int i = acentuados.Length - 1;
                while (i >=0 )
                    {
                        if ( acentuados[i] == sb[indiceVet])
                        {
                        
                            Console.WriteLine($"ENTROU: {vet[indiceVet]}");
                            sb[indiceVet] = naoacentos[i];
                            
                            break;
                        
                        }
                       
                        i--;    
                        
                    }

                      indiceVet--;

                 }

                Console.WriteLine(sb);


    }


    static void TiraAcentoRecursao(string acentuados,string naoacentos ,StringBuilder sb, int indiceVet, int i)
    {
                if(indiceVet < 0)
                {
                    Console.WriteLine(sb);
                    return;

                }
                if(i< 0 )
                {
                   TiraAcentoRecursao(acentuados,naoacentos,sb,indiceVet-1,acentuados.Length - 1);
                   return;
                }

                 if(acentuados[i] == sb[indiceVet])
                    {    
                        sb[indiceVet] = naoacentos[i];
                        TiraAcentoRecursao(acentuados, naoacentos,sb, indiceVet-1,acentuados.Length - 1);
                        return;
                    }
                      
                  
                    TiraAcentoRecursao(acentuados, naoacentos,sb, indiceVet,i-1);

    }
    static void Main(string[] args)
    {
        string acentuados = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
       string naoacentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";
        string vet = "PÃO, FLOR, CABEÇA";
        StringBuilder sb = new StringBuilder(vet);
        
      

    
        
       // TiraAcento(vet,acentuados,naoacentos,sb);
        //Console.WriteLine("");
        TiraAcentoRecursao(acentuados,naoacentos,sb,sb.Length-1, acentuados.Length - 1);
    }
}

   