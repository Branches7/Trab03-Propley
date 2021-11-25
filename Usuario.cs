class Usuario : Pessoa{
  private string senha;
  private string nivelAcesso;

  public Usuario(int id, string nome, string tel, string email, string senha, string nivelAcesso):base(id, nome, tel, email){
    this.senha = senha;
    this.nivelAcesso = nivelAcesso;
  }

  public Usuario(int id, string nome, string senha):base(id, nome){
    this.senha = senha;
  }

  public override string getNome() {
    return nome;
  }

  public string getSenha() {
    return senha;
  }

  public void setSenha(string senha) {
    this.senha = senha;
  }

  public string getNivelAcesso() {
    return nivelAcesso;
  }

  public void setNivelAcesso(string nivelAcesso) {
    this.nivelAcesso = nivelAcesso;
  }
}