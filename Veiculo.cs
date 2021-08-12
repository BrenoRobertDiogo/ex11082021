public class Veiculo {
  public string registro {get;set;}
  public string motorista {get;set;}
  public int qtdRodas {get;set;}

  public Veiculo(){
    this.registro = "NENHUM";
    this.motorista = "NENHUM";
  }
  public Veiculo(string val1, string val2){
    this.registro =  val1;
    this.motorista = val2;
  }
  
  public Veiculo(string val1, string val2, int val3){
    this.registro =  val1;
    this.motorista = val2;
    this.qtdRodas = val3;
  }

  public void acelerar() {

  }

}