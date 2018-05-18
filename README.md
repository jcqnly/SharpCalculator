# Calculator App Console in C#

## Dependencies
Sharp Calculator runs on .NET Core 2.0, which can be downloaded [here](https://www.microsoft.com/net/download/macos).

---
## Build and Run
After installing the [.NET Core 2.0 SDK](https://www.microsoft.com/net/download/macos), clone this repo onto your machine and type the following commands:

```
cd SharpCalculator
dotnet run
```
---
## Program Explanation
Sharp Calculator will ask a user to choose one of four operations followed by the two numbers they want to calculate.  

A _successful_ run will be indicated with "The answer is: " and the answer.

---
## Reflection
This assignment was worked on nightly at 2 hour sprints each time for 4 days.

Day 1 - Four math operations were added in the Main method

Day 2 - The four operations were changed to switch statements.

Day 3 - Each of the operations were given their own methods.  Other parts of the Main method from Day 1 were also broken into smaller methods where data was passed from one method to wherever it needed to go.

Day 4 - The user is now prompted with which math operation they wish to use before they're asked for the numbers.

---
## Learning Moments
The main hurdle was learning how to pass around the variables from one method to the next. It took some fiddling with the name of the methods for it to work.  Aside from that, it was similar to how Javascript passes around parameters.  I learned how to use switch statements in C# from this forum [post](https://codereview.stackexchange.com/questions/131158/simple-calculator-in-c).  I also utilized these lessons from the [Microsoft Virtual Academy](https://mva.microsoft.com/en-us/training-courses/c-fundamentals-for-absolute-beginners-16169).