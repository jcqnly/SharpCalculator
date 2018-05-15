using System;

namespace SharpCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Calculate 2 numbers!\n");

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
        Answer = FirstNum + SecondNum;
        Console.Write("The answer is ", Answer);
        break;

        case "2":
        Answer = FirstNum - SecondNum;
        Console.Write("The answer is ", Answer);
        break;

        case "3":
        Answer = FirstNum * SecondNum;
        Console.Write("The answer is ", Answer);
        break;

        case "4":
        Answer = FirstNum / SecondNum;
        Console.Write("The answer is ", Answer);
        break;
      }
      Console.ReadLine();
    }
  }
}
