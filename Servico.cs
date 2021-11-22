class Servico{
  
  protected string descricao;
  protected double valor;

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
}