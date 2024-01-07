using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_1.models
{
    //herança
    public sealed class Professor : Pessoa  //sealad significa que a classe é selada, ou seja, nenhuma outra classe pode herdar dessa classe(isso tambem funciona com metodos)
    {
        public Professor(){

        }
        //construtor com heranca
        public Professor(string nome) : base(nome) {

        }

        public decimal Salario { get; set; }

        //reescreve o metodo 
        public override void Apresentar(){
            Console.WriteLine($"Ola meu nome é {Nome}, Sou um professor e meu salario é {Salario}");
        }
    }
}