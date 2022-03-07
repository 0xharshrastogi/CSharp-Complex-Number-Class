class Complex
{
  public double Real { get; set; }
  public double Imaginary { get; set; }

  public Complex(double real, double imaginary)
  {
    this.Real = real;
    this.Imaginary = imaginary;
  }
  static private double Square(double num) => Math.Pow(num, 2);
  public static double Abs(Complex c)
  {
    return Math.Sqrt(Complex.Square(c.Real) + Complex.Square(c.Imaginary));
  }

  public static Complex Pow(Complex c, double power)
  {
    if (c.Imaginary == 0) throw new Exception("Imaginary part is Zero, B != 0");

    var abs = Math.Sqrt(Complex.Square(c.Real) + Complex.Square(c.Imaginary));
    var angleInRadian = Math.Atan(c.Imaginary / c.Real);

    var real = Math.Pow(abs, power) * Math.Cos(power * angleInRadian);
    var imaginary = Math.Pow(abs, power) * Math.Sin(power * angleInRadian);

    return new Complex(real, imaginary);
  }

  public static Complex Sqrt(Complex c)
  {
    return Complex.Pow(c, 0.5);
  }

  public static explicit operator string(Complex c)
  {
    var symbol = c.Imaginary < 0 ? "-" : "+";
    return $"({c.Real}{symbol}{Math.Abs(c.Imaginary)}i)";
  }

  public string ToString()
  {
    return (string)this;
  }

  public static Complex operator -(Complex c)
  {
    return new Complex(-c.Real, -c.Imaginary);
  }

  public static Complex operator -(Complex left, Complex right)
  {
    return left + (-right);
  }

  public static Complex operator +(Complex left, Complex right)
  {
    return new Complex(left.Real + right.Real, left.Imaginary + right.Imaginary);
  }

  public static Complex operator *(Complex left, Complex right)
  {
    var real = left.Real * right.Real - left.Imaginary * right.Imaginary;
    var imaginary = left.Real * right.Imaginary + left.Imaginary * right.Real;

    return new Complex(real, imaginary);
  }

  public static Complex operator /(Complex complexNumber, double divisor)
  {
    return new Complex(complexNumber.Real / divisor, complexNumber.Imaginary / divisor);
  }

  public static Complex operator /(Complex left, Complex right)
  {
    return (left * new Complex(right.Real, -right.Imaginary)) / (Math.Pow(right.Real, 2) + Math.Pow(right.Imaginary, 2));
  }
}