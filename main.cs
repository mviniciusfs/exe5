using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite valor em MT: ");
    double n = double.Parse(Console.ReadLine());

    Console.WriteLine("Valor convertido em CM: " + n * 100);
  }
}