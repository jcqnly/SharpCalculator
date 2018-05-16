using System;

namespace SharpCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Bestest Calculator Will Calculate...");
      WhichChoice();
    }

    static public int Choices()
    {
      Console.WriteLine("What would you like to do? Choose a number\n" +
                        "1 - add\n" +
                        "2 - subtract\n" +
                        "3 - multiply\n" +
                        "4 - divide\n");
      int selection = int.Parse(Console.ReadLine()); 
      return selection;
    }

    static public void WhichChoice()
    {
      Console.Write("the first number:\n");
      int firstNum = int.Parse(Console.ReadLine());

      Console.Write("and the second number:\n");
      int secondNum = int.Parse(Console.ReadLine());

      int selection = Choices();

      switch (selection)
      {
        case 1: 
          Console.WriteLine("The answer is: " + Add(firstNum, secondNum));
        break;

        case 2:
          Console.WriteLine("The answer is: " + Subtract(firstNum, secondNum));
        break;

        case 3:
          Console.WriteLine("The answer is: " + Multiply(firstNum, secondNum));
        break;

        case 4:
          Console.WriteLine("The answer is: " + Divide(firstNum, secondNum));
        break;

        default:
          Console.WriteLine("Not valid. Select again.");
          WhichChoice();
        break;
      }
    }

    public static int Add(int x, int y)
    {
      int z = x + y;
      return z;
    }

    public static int Subtract(int x, int y)
    {
      int z = x - y;
      return z;
    }

    public static int Multiply(int x, int y)
    {
      int z = x * y;
      return z;
    }

    public static int Divide(int x, int y)
    {
      int z = x / y;
      return z;
    }

  }
}