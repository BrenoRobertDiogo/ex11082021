using System;

class MainClass {
  public static void Main (string[] args) {
    
    Carro meuCarroAutonomo = new Carro("Fusca", "Wolks", 1950, 3.0, 3, 3);
    Carro meuCarroAutonomo2 = new Carro("Fusca", "Wolks", 1950, 3.0, 3, 3, 5, 7);
    Console.WriteLine(meuCarroAutonomo.encherTanque(4.32));

  }
}