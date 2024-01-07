using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_1.models
{
    //classe chamada pessoa
    public class Pessoa
    {
        public Pessoa(){
            
        }
        public Pessoa(String nome){
            Nome = nome;
        }
        //abstracao
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        //metodo que permite a reescrita
        public virtual void Apresentar(){
            Console.WriteLine($"Ola, meu nome é {Nome} e minha idade {Idade}");
        }
    }
}