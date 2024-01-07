using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public abstract class Smartphone
    {
        protected Smartphone(string numero, string modelo, string iMEI, int memoria)
        {
            this.Numero = numero;
            this.Modelo = modelo;
            this.IMEI = iMEI;
            this.Memoria = memoria;
        }

        //propriedades
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }         

        //metodos
        public void Ligar(){
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao(){
            Console.WriteLine("Recebendo ligacao...");
        }

        public abstract void InstalarAplicativo(string nome);
    }
}