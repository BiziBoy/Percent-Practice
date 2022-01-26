using System;

namespace Percent_Practice
{
  class Program
  {
    static double Calculate(string _input)
    {
      string _inputNew = _input.Replace('.', ',');
      string[] vs = _inputNew.Split(' '); 
      double similarAmount = double.Parse(vs[0]);
      double percentRate = double.Parse(vs[1]);
      int mounths = int.Parse(vs[2]);
      double percentRatePerMonth = (double)percentRate / 1200;
      double sum = similarAmount * Math.Pow( 1 + percentRatePerMonth, mounths);
      return sum;
    }

    static void Main(string[] args)
    {
      string input =  Console.ReadLine();
      Console.WriteLine(Calculate(input));
    }
  }
}
