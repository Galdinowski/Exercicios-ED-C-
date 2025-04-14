using System;

namespace Estudante
{

    public class Aluno{
        public string Nome {get; set;}
        public int Matricula {get;set;}
        public double Nota {get; set;}


        public override string ToString()
        {
            return $"{Nome}, Matrícula: {Matricula}, Nota: {Nota}";
        }
    }
}