using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_1.models
{
    public class ContaCorrente
    {
        //encapsulamento
        public ContaCorrente(int Numero, decimal saldo)
        {
            this.NumeroConta = Numero;
            this.saldo = saldo;
        }
        public int NumeroConta { get; set; }

        private decimal saldo;

        public void Sacar(decimal valor){
            if(saldo >= valor){
                saldo -= valor;
                Console.WriteLine("Saque rrealizado");
            }else{
                Console.WriteLine("Valor indisponivel");
            }
            
        }

        public void ExibirSaldo(){
            Console.WriteLine(saldo);
        }
    }
}