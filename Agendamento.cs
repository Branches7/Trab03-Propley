using System;
using System.Collections.Generic;
using System.Globalization;

class Agendamento : IBarber{
  protected int id;
  public Cliente cliente;
  public Servico servico;
  public DateTime horario;
  public List<string> agenda = new List<string>();
  
  protected string observacao;
  CultureInfo provider = CultureInfo.InvariantCulture;
  string padrao = "g";


  public Agendamento(int id, Cliente cliente, Servico servico, string horario){
    this.id = id;
    this.cliente = cliente;
    this.servico = servico;
    provider = new CultureInfo("fr-FR");
    this.horario = DateTime.ParseExact(horario, padrao, provider);
  }

  public Agendamento(int id, Cliente cliente, Servico servico, string horario, string observacao):this(id, cliente, servico, horario){
      this.observacao = observacao;
  }



  /*public void agendar(int id, string nm, string s1, string s2){
    agenda.add("Nome: {0}, Serviço escolhido: {1}{2}, Horário: {3}", nm, s1, s2, this.horario);
  }*/


  public string Observacao{
    get { return observacao; }
    set { observacao = value; } 
  }

  public Cliente getCliente() {
    return cliente;
  }

  public void setCliente(Cliente cliente) {
    this.cliente = cliente;
  }

  public Servico getServico() {
    return servico;
  }

  public void setServico(Servico servico) {
    this.servico = servico;
  }

}