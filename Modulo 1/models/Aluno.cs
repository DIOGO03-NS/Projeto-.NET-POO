using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_1.models
{
    //herança
    public class Aluno : Pessoa
    {
        public Aluno(){
            
        }
        //construtor com heranca
        public Aluno(string nome) : base(nome) {

        }
     public double Nota { get; set; } 

    //reescreve o metodo
     public override void Apresentar(){
        Console.WriteLine($"Ola meu nome é {Nome}, Sou um aluno e minha nota é {Nota}");
     }  
    }
}