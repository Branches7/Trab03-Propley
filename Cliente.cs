class Cliente : Pessoa{
  private string cep;
  private string endereco;

  public Cliente(int id, string nome, string tel, string email, string cep, string endereco):base(id, nome, tel, email){
    this.cep = cep;
    this.endereco = endereco;
  }

  public string Cep{
    get { return cep; }
    set { cep = value; } 
  }

  public string Endereco{
    get { return endereco; }
    set { endereco = value; } 
  }
}