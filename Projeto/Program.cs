using Projeto.Models;

Nokia telefone1 = new Nokia("123456", "Nokia c50", "1111111", 64);
Iphone telefone2 = new Iphone("654321", "Iphone 14", "2222222", 128);

telefone1.Ligar();
telefone2.Ligar();

telefone1.ReceberLigacao();
telefone2.ReceberLigacao();

telefone1.InstalarAplicativo("GitHub");
telefone2.InstalarAplicativo("GitHub");