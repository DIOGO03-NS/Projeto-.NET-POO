using Modulo_1.models;
using Modulo_1.Interfaces;

Pessoa p1 = new Pessoa();

p1.Nome = "Diogo";
p1.Idade = 20;

Aluno aluno = new Aluno();
Professor professor = new Professor();

aluno.Nome = "Fulano";
aluno.Idade = 15;
aluno.Email = "fulanin@gmail.com";

professor.Nome = "Sr. Fulano";
professor.Idade = 60;
professor.Email = "srfulano@gmail.com";


p1.Apresentar();    //apresenta o metodo original da classe pessoa
aluno.Apresentar(); //apresenta o metodo reescrito na classe aluno apresentando resultado diferente
professor.Apresentar(); //apresenta o metodo reescrito na classe professor apresentando resultado diferente

//classes abstratas
//Conta conta = new Conta();     da erro pois a classe conta é abstrata

Corrente conta = new Corrente();
conta.Creditar(500);    //usando metod0 abstrato vindo da classe abstrata credito

Computador computador = new Computador();
computador.ToString();  //metodo que vem da classe object

//interfaces
//iCalculadora calc = new iCalculadora()    nao implementa a interface
Calculadora calc = new Calculadora();   //a classe que implementa é facilmente instanciada