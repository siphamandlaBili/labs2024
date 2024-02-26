using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class TUT1_Question2
{
    /*
     Write a C# application that prompts user for two double variables in the main() method. Pass
b    oth variables to a method called computePercentage() that displays the two values and the
     
     value of the first number as a percentage of the second one. For example, if the numbers are
3    .0 and 5.0, the method should display a statement similar to “3.0 is 60% of 5.0”. Then call
     the method a second time, passing the values in revered order. Save project as
     TUT1_Question2.

     */

    // compute percantage and limit answer to two decimal places
    static void computePercentage(double num1,double num2 )
    {
        double result = (num1 / num2) * 100;
        Console.WriteLine("the percentage of {0} out of {1} is {2}%",num1,num2, Math.Round(result, 2));
    }

    static void Main(string[] args)
    {
        Console.Write("give first number to used in percentage calc ");
        double firstNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("give second number to used in percentage calc ");
        double secondNum = Convert.ToDouble(Console.ReadLine());

        computePercentage(firstNum,secondNum);
        computePercentage(secondNum, firstNum);
    }
}