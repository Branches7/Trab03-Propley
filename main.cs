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
      if(navegacao == 1){ 
        servico.TabelaPrecos();
        Console.WriteLine("\nDeseja prosseguir para o agendamento? ");
        resposta = Console.ReadLine();
        if(resposta == "s"){
          navegacao = 2;
        }
        else{
          repetir = false;
        }
      }
      if(navegacao == 2){
        Console.WriteLine("Insira seu Nome");
        string nome = Console.ReadLine();
          
        if(nome == pessoa.Nome){
          Console.WriteLine("Insira seu Telefone");
          string tel = Console.ReadLine();
            

          Cliente cliente = new Cliente(id, nome, tel);

          Console.WriteLine("Escolha um serviço:\n1. para Cabelo\n2. para Cabelo e Barba\n3. para Barba");
          servico._servico(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("Insira a data e hora: EX: 12/12/2000 12:00");
          string date = Console.ReadLine();

          IBarber agendamento = new Agendamento(id, cliente, servico, date);

          sw.WriteLine(agendamento.getCliente().getId()+": "+agendamento.getCliente().getNome()+" - "+agendamento.getServico().Descricao+" - "+agendamento.getServico().Valor);
          sw.Close();
            
            
        }
        else{
          Console.WriteLine("Usuário não cadastrado");
        }
        Console.WriteLine("Agendamento concluído!");
        Console.WriteLine("Deseja realizar outro agendamento? (S/N)");
        resposta = Console.ReadLine();
        if (resposta == "N"  || resposta == "n"){
          repetir = false;
        }
        break;
      }  
    }
  }
}