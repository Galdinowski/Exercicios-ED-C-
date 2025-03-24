// See https://aka.ms/new-console-template for more information
using System;

class program
{
      static int index;
      static int contador;
     static int VetorMenosUm(int[] vet)
    {
      

        if(index < 0)
           {   
                
                return contador;
            }

            if(vet[index] <0)
            {
                vet[index] *= -1;
                contador++;
                index--;
                    return  VetorMenosUm(vet);
                }
                
                    index--;
                     return VetorMenosUm(vet);
            
               
             
            
    }
   
   static void Main(string[] args)
    {
        int[] vet =[-4, 15, 51, -42, 12, -8, 9, 91, -6];
        index = vet.Length-1;
        contador = 0;
       
        Console.WriteLine(VetorMenosUm(vet));
        
    }


}

