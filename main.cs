//Nesse programa criamos a classe base abstrata animal, é abstrata porque tem o comportamento emitir som padrão, porém não produz nenhum som na base, esse método é implementado depois nas classes herdadas.

using System;

abstract class Animal {
  public abstract void EmitirSom();
  public abstract void EmitirSom(string texto);
}

class Cachorro : Animal {
  public override void EmitirSom() {
    Console.WriteLine("Latindo...");
  }

  public override void EmitirSom(string texto) {
    Console.WriteLine(texto);
  }
}

class Gato : Animal {
  public override void EmitirSom() {
    Console.WriteLine("Miando...");
  }

  public override void EmitirSom(string texto) {
    Console.WriteLine(texto);
  }
}

class Porco : Animal {
  public override void EmitirSom() {
    Console.WriteLine("Oinc Oinc...");
  }

  public override void EmitirSom(string texto) {
    Console.WriteLine(texto);
  }
}
class Galinha : Animal {
  public override void EmitirSom() {
    Console.WriteLine("Cocoricó...");
  }

  public override void EmitirSom(string texto) {
    Console.WriteLine(texto);
  }
}




class Program {
  public static void Main(string[] args) {
    Cachorro c = new Cachorro();
    Gato g = new Gato();
    Porco p1 = new Porco();
    Porco p2 = new Porco();
    Galinha ga = new Galinha();
    c.EmitirSom();
    g.EmitirSom("Miando alto!");
    p1.EmitirSom();
    p2.EmitirSom("Oinc");
    ga.EmitirSom();
  }
}