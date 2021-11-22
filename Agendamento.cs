using System;
using System.Collections.Generic;
using System.Globalization;

class Agendamento{
  protected Cliente clienteAgendado;
  protected Servico servicoAgendado;
  public DateTime horario;
  public List<string> agenda = new List<string>();
  CultureInfo myCI = new CultureInfo("en-US", false);
  protected string observacao;

  public Agendamento(Cliente clienteAgendado, Servico servicoAgendado, string horario){
    this.clienteAgendado = clienteAgendado;
    this.servicoAgendado = servicoAgendado;
    this.horario = DateTime.Parse(horario, myCI);
  }

  public Agendamento(Cliente clienteAgendado, Servico servicoAgendado, string horario, string observacao):this(clienteAgendado, servicoAgendado, horario){
      this.observacao = observacao;
  }

  public string Observacao{
    get { return observacao; }
    set { observacao = value; } 
  }

}