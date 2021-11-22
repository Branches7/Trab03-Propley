class Pessoa{
  private int id;
  private string nome;
  private string tel;
  private string email;

  public Pessoa(int id, string nome, string tel, string email){
    this.id = id;
    this.nome = nome;
    this.tel = tel;
    this.email = email;

  }

  public int Id{
    get { return id; }
    set { id = value; } 
  }

  public string Nome{
    get { return nome; }
    set { nome = value; } 
  }

  public string Tel{
    get { return tel; }
    set { tel = value; } 
  }

  public string Email{
    get { return email; }
    set { email = value; } 
  }
}