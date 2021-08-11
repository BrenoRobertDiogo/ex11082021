public class Carro {
  private string _modelo {get; set;}
  private string _marca {get; set;}
  private int _anoFabricacao {get; set;}
  private double _valorNovo {get; set;}
  private double _valorAtual {get; set;}
  private int _capacidadeTanque {get; set;}
  private int _kmRodados {get; set;}
  private int _autonomiaPorLitro {get; set;}
  
  public string modelo {get{return this._modelo}; set{this._modelo = value};}
  public string marca {get{return this._marca}; set{this._marca = value};}
  public int anoFabricacao {get{return this._anoFabricacao}; set{this._anoFabricacao = value};}
  public double valorNovo {get{return this._valorNovo}; set{this._valorNovo = value};}
  public double valorAtual {get{return this._valorAtual}; set{this._valorAtual = value};}
  public int capacidadeTanque {get{return this._capacidadeTanque}; set{this._capacidadeTanque = value};}
  public int kmRodados {get{return this._kmRodados}; set{this._kmRodados = value};}
  public int autonomiaPorLitro {get{return this._autonomiaPorLitro}; set{this._autonomiaPorLitro = value};}

  public Carro(string mod, string mc, int a, double vn, int ct, int kmr, int ta, int aut ) 
  {
    this._modelo = mod;
    this._marca = mc;
    this._anoFabricacao = a;
    this._valorNovo = vn;
    this._valorAtual = ct;
    this._capacidadeTanque = kmr;
    this._kmRodados = ta;
    this._autonomiaPorLitro = aut;
  }//
  
  public Carro(string mod, string mc, int a, double vn, int ct, int aut ) 
  {
    this._modelo = mod;
    this._marca = mc;
    this._anoFabricacao = a;
    this._valorNovo = vn;
    this._valorAtual = ct;
    this._autonomiaPorLitro = aut;
  }

  public bool percorrerDistancia () {

  }

  public double encherTanque(double precoGasolina) {

  }//b

  public void atualizaValorCarro(int anoAtual) {

  }

}