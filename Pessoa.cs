class Pessoa{
  protected int id;
  protected string nome;
  protected string rg;
  protected string email;

  public Pessoa(int id, string nome){
    this.id = id;
    this.nome = nome;
  }

  public Pessoa(int id, string nome, string rg, string email){
    this.id = id;
    this.nome = nome;
    this.rg = rg;
    this.email = email;

  }

  public int Id{
    get { return id; }
    set { id = value; } 
  }

  public virtual int getId() {
    return id;
  }

  public virtual string getNome() {
    return nome;
  }

  public string Nome{
    get { return nome; }
    set { nome = value; } 
  }

  public string Rg{
    get { return rg; }
    set { rg = value; } 
  }

  public string Email{
    get { return email; }
    set { email = value; } 
  }
}