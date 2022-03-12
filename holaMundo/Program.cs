using System;

namespace contador
{ 
  public class Program
  {
    static void Main(string[] args)
    {
      int contador = 0, suma = 0;
      while(contador < 10)
      {
        suma += contador;   //igual a suma = suma + contador
        contador++;   //igual a contador + 1
        Console.WriteLine(suma);
      }

      Console.WriteLine("La suma final es: " + suma);
    }
  }
}