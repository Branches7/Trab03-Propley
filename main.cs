using System;
using System.Collections.Generic;


class Program {
  public static void Main (string[] args) {

    Servico servico = new Servico();
    bool repetir = true;
    string resposta;
    int navegacao;
    int id = 1;

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
          string nome = Console.ReadLine();
          if(nome == pessoa.Nome){
            Console.WriteLine("Insira seu Telefone");
            string tel = Console.ReadLine();
            Cliente cliente = new Cliente(id, nome, tel);

            Console.WriteLine("Escolha um serviço: ");
            servico._servico(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Insira a data e hora: EX: 12/12/2000 12:00");
            string date = Console.ReadLine();

            IBarber agendamento = new Agendamento(id, cliente, servico, date);
            
            
          }
          else{
            Console.WriteLine("nome não cadastrado");
          }
        
        break;
        }
        
        Console.WriteLine("Deseja sair:(S/N)");
          resposta = Console.ReadLine();
          if (resposta == "S"){
            repetir = false;
          }
      }
  }
}