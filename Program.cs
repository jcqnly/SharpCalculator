using System;

namespace SharpCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Bestest Calculator Will Calculate");
 
      WhichChoice();
      // UserNumbers();
      /*Console.WriteLine("Calculate 2 numbers!\n");

      Console.Write("What's the first number?\n");
      string FirstInput = Console.ReadLine();
      int FirstNum = int.Parse(FirstInput);

      Console.Write("What's the second number?\n");
      string SecondInput = Console.ReadLine();
      int SecondNum = int.Parse(SecondInput);

      Console.WriteLine("What would you like to do? Choose a number\n" +
                        "1 - add\n" +
                        "2 - subtract\n" +
                        "3 - multiply\n" +
                        "4 - divide\n" +
                        "5 - exit\n");
      string Choice = Console.ReadLine();
      int Answer;

      switch (Choice)
      {
        case "1": 
        Console.Write("The answer is {0}", Answer = FirstNum + SecondNum);
        break;

        case "2":
        Console.Write("The answer is {0}", Answer = FirstNum - SecondNum);
        break;

        case "3":
        Console.Write("The answer is {0}", Answer = FirstNum * SecondNum);
        break;

        case "4":
        Console.Write("The answer is {0}", Answer = FirstNum / SecondNum);
        break;

        default:
        break;
      }
      Console.ReadLine();*/
    }
    static public int Choices()
    {
      Console.WriteLine("What would you like to do? Choose a number\n" +
                        "1 - add\n" +
                        "2 - subtract\n" +
                        "3 - multiply\n" +
                        "4 - divide\n" +
                        "5 - exit\n");
      int selection = int.Parse(Console.ReadLine()); 
      return selection;
    }
    // static public int UserNumbers()
    // {
    //   Console.Write("What's the first number?\n");
    //   int firstNum = int.Parse(Console.ReadLine());

    //   Console.Write("What's the second number?\n");
    //   int secondNum = int.Parse(Console.ReadLine());

    //   return (firstNum, secondNum);
    // }

    static public void WhichChoice()
    {
      Console.Write("What's the first number?\n");
      int firstNum = int.Parse(Console.ReadLine());

      Console.Write("What's the second number?\n");
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

        // case 5:

        // break;

        default:
          Choices();
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
