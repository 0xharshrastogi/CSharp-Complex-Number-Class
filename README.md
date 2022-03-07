# CSharp-Complex-Number-Class
Class file containing all operation related to complex number in C# 

```c#
class Program
{
  static void Main(string[] args)
  {
    var c1 = new Complex(10, -5);
    var c2 = new Complex(1, 1);
    var multiplicationResult = c1 * c2; // You can use this way;
    
    // Currently Public Statics Methods Provided;
    Complex.Pow(c1, 6); // Raise complex num to power using De Moivre's method
    Complex.Abs(c2); // Absoute value of complex number
    
    Console.WriteLine($"{((string)c1)}*{((string)c2)}={((string)(c1 / c2))}");
    Console.WriteLine(Complex.Abs(new Complex(3, 4)));
    Console.WriteLine(((string)Complex.Sqrt(new Complex(0, 9))));
  }
}
```
