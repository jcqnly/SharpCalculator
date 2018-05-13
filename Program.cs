using System;

namespace SharpCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate 2 numbers!\n");
            bool exit = false;

            do
                  {
            Console.WriteLine("What would you like to do? Choose a number\n" +
                              "1 - add\n" +
                              "2 - subtract\n" +
                              "3 - multiply\n" +
                              "4 - divide\n" +
                              "5 - exit\n");
            string Choice = Console.ReadLine();
                  
                  double Total = 0;

              if (Choice == "1")
              {
                Console.Write("What's the first number?\n");
                          string FirstInput = Console.ReadLine();
                          int FirstNum = int.Parse(FirstInput);

                          Console.Write("What's the second number?\n");
                          string SecondInput = Console.ReadLine();
                          int SecondNum = int.Parse(SecondInput);

                Total = FirstNum + SecondNum;
                          Console.WriteLine("The answer is " + Total);
              }
                      
              if (Choice == "2")
              {
                Console.Write("What's the first number?\n");
                          string FirstInput = Console.ReadLine();
                          int FirstNum = int.Parse(FirstInput);

                          Console.Write("What's the second number?\n");
                          string SecondInput = Console.ReadLine();
                          int SecondNum = int.Parse(SecondInput);

                Total = FirstNum - SecondNum;
                Console.WriteLine("The answer is " + Total);
              }

              if (Choice == "3")
              {
                Console.Write("What's the first number?\n");
                          string FirstInput = Console.ReadLine();
                          int FirstNum = int.Parse(FirstInput);

                          Console.Write("What's the second number?\n");
                          string SecondInput = Console.ReadLine();
                          int SecondNum = int.Parse(SecondInput);

                Total = FirstNum * SecondNum;
                Console.WriteLine("The answer is " + Total);
              }

              if (Choice == "4")
              {
                Console.Write("What's the first number?\n");
                          string FirstInput = Console.ReadLine();
                          int FirstNum = int.Parse(FirstInput);

                          Console.Write("What's the second number?\n");
                          string SecondInput = Console.ReadLine();
                          int SecondNum = int.Parse(SecondInput);

                Total = FirstNum / SecondNum;
                Console.WriteLine("The answer is " + Total);
                      }
              if (Choice == "5")
              {
                exit = true;
              }
      
              Console.ReadLine();
            } while (exit != true);  
        }
    }
}
