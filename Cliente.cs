class Cliente : Pessoa{
  protected string tel;

  public Cliente(int id, string nome, string tel):base(id, nome){
    this.tel = tel;
  }

  public Cliente(int id, string nome, string rg, string email, string tel):base(id, nome, rg, email){
    this.tel = tel;
  }

  public override int getId() {
    return id;
  }

  public override string getNome() {
    return nome;
  }

  public string Tel{
    get { return tel; }
    set { tel = value; } 
  }

}