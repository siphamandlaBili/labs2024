using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Xml.Linq;
class TUT1_Question1
{

   /* 
      Write a C# application that prompts user for a number in the main() method. In turn pass the 
      number to the methods displayThreeTimesTheNumber(), displayNumberPlusTen() and
      displayNumberSquared(). Create each method to perform the task its name implies.Save
      project as TUT1_Question1 
   */


    // funct to display num * 3
    static void displayThreeTimesTheNumber(int num)
    {
        int results = num * 3;
        Console.WriteLine("{0} multiplied by three is = {1}", num, results);
      
    }

    // funct to display num + 10
    static void displayNumberPlusTen(int num)
    {
        int results = num + 10;
        Console.WriteLine("{0} plus 10 is = {1}", num, results);

    }

    // funct to display NumberSquared
    static void displayNumberSquared(int num)
    {
        double result = Math.Pow(3, (double)num);
        Console.WriteLine("{0} squared = {1}", num, result);

    }

    static void Main(string[] args)
    {
        Console.Write("input number to be used for calculations : ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("---------------------------------------------");

        displayThreeTimesTheNumber(num);
        displayNumberPlusTen(num);
        displayNumberSquared(num);
    }
}