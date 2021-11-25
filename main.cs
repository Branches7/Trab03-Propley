using System;
using System.Collections.Generic;
using System.IO;


class Program {
  public static void Main (string[] args) {

    Servico servico = new Servico();
    bool repetir = true;
    string resposta;
    int navegacao;
    int id = 1;

    StreamWriter sw = new StreamWriter("Agenda.txt", true);
    string _nome = "testes222";
    string _tel = "testes";
    string date = "12/12/2000 12:00";

     while (repetir == true){

      Console.WriteLine("Cadastro:\nInsira seu nome: ");
      string N1 = Console.ReadLine();
      Console.WriteLine("RG: ");
      string R1 = Console.ReadLine();
      Console.WriteLine("Email: ");
      string M1 = Console.ReadLine();

      id++;
      Pessoa pessoa = new Pessoa(id, N1, R1, M1);

      Console.WriteLine("1. Tabela de Preços\n2. Agendar\n");
      navegacao = Convert.ToInt32(Console.ReadLine());
      switch (navegacao){ 
        case 1:
        servico.TabelaPrecos();
        break;

        case 2:
          Console.WriteLine("Insira seu Nome");
          _nome = Console.ReadLine();
          
          if(_nome == pessoa.Nome){
            Console.WriteLine("Insira seu Telefone");
            _tel = Console.ReadLine();
            

            Cliente cliente = new Cliente(id, _nome, _tel);

            Console.WriteLine("Escolha um serviço:\n 1- para Cabelo\n 2 - para Cabelo e Barba\n 3 -  para Barba");
            servico._servico(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Insira a data e hora: EX: 12/12/2000 12:00");
            date = Console.ReadLine();
            sw.WriteLine(_nome+" - "+_tel+" - "+date);
            sw.Close();

            IBarber agendamento = new Agendamento(id, cliente, servico, date);
            
            
          }
          else{
            Console.WriteLine("nome não cadastrado");
          }
        
        break;
        }
        
        Console.WriteLine("Deseja sair:(S/N)");
          resposta = Console.ReadLine();
          if (resposta == "S"  || resposta == "s"){
            repetir = false;
          }
      }
  }
}