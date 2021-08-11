public class Carro {
  private string _modelo {get; set;}
  private string _marca {get; set;}
  private int _anoFabricacao {get; set;}
  private double _tanqueNovo {get; set;}
  private double _tanqueAtual {get; set;}
  private int _capacidadeTanque {get; set;}
  private int _kmRodados {get; set;}
  private int _autonomiaPorLitro {get; set;}
  
  public string modelo {
      get => this._modelo;
      set => this._modelo = value;
    }
  public string marca {
      get => this._marca;
      set => this._marca = value;
    }
  public int anoFabricacao {
      get => this._anoFabricacao;
      set => this._anoFabricacao = value;
    }
  public double valorNovo {
      get => this._tanqueNovo;
      set => this._tanqueNovo = value;
    }
  public double tanqueAtual {
      get => this._tanqueAtual;
      set => this._tanqueAtual = value;
    }
  public int capacidadeTanque {
      get => this._capacidadeTanque;
      set => this._capacidadeTanque = value;
    }
  public int kmRodados { 
      get => this._kmRodados;
      set => this._kmRodados = value;
    }
  public int autonomiaPorLitro {
      get => this._autonomiaPorLitro;
      set => this._autonomiaPorLitro = value;
    }

  public Carro(string mod, string mc, int a, double vn, int ct, int kmr, int ta, int aut ) 
  {
    this._modelo = mod;
    this._marca = mc;
    this._anoFabricacao = a;
    this._tanqueNovo = vn;
    this._tanqueAtual = ct;
    this._capacidadeTanque = kmr;
    this._kmRodados = ta;
    this._autonomiaPorLitro = aut;
  }
  
  public Carro(string mod, string mc, int a, double vn, int ct, int aut ) 
  {
    this._modelo = mod;
    this._marca = mc;
    this._anoFabricacao = a;
    this._tanqueNovo = vn;
    this._tanqueAtual = ct;
    this._autonomiaPorLitro = aut;
  }

  public bool percorrerDistancia (int dist) {
    double litrosNecessarios = dist / _autonomiaPorLitro;
    if(_tanqueAtual >= litrosNecessarios) {
      kmRodados += dist;
      _tanqueAtual -= litrosNecessarios;
      return true;
    }
    return false;
  }

  public double encherTanque(double precoGasolina) {
    return (capacidadeTanque-_tanqueAtual)*precoGasolina;
  }//b

  public void atualizaValorCarro(int anoAtual) {
    // todo
  }

}