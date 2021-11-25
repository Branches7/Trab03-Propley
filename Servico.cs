using System;
using System.Collections.Generic;

class Servico{
  
  protected string descricao;
  protected double valor;
  protected List<(string, double)> tabelaPrecos = new List<(string, double)>();

  public Servico(){
  }

  public Servico(string descricao, double valor){
    this.descricao = descricao;
    this.valor = valor;
  }

  public string Descricao{
    get { return descricao; }
    set { descricao = value; } 
  }

  public double Valor{
    get { return valor; }
    set { valor = value; } 
  }

  public void TabelaPrecos(){
    tabelaPrecos.Add(("1 - Cabelo", 20));
    tabelaPrecos.Add(("2 - Cabelo e Barba", 30));
    tabelaPrecos.Add(("3 - Barba", 10));
    foreach(var list in tabelaPrecos){
      Console.WriteLine(list);
    }
  }

  public void _servico(int svc){
    switch(svc){
      case 1:
        Descricao = "Cabelo";
        Valor = 20;
        break;
      case 2:
        Descricao = "Cabelo e Barba";
        Valor = 30;
        break;
      case 3:
        Descricao = "Barba";
        Valor = 10;
        break;
      default:
        Console.WriteLine("Serviço invalido");
        break;
    }
  }
}