using System;

class Program
{
    static void printgraphPlayer(string playerName, int playerScore)
    {
        string start = "";
        for(int i = 0;i < playerScore; i++)
        {
            start = start + "*";
           
        }

        if(start == "")
        {
            Console.WriteLine(playerName + "    " + "player did not score");
        }
        else
        {
            Console.WriteLine(playerName + "    " + start);
        }
        
    }

    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        // user input 
        Console.Write("Enter points earned by Art >> ");
        int Art = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter points earned by Bob >> ");
        int Bob = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter points earned by Cal >> ");
        int Cal = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter points earned by Dan >> ");
        int Dan = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter points earned by Eli >> ");
        int Eli = Convert.ToInt32(Console.ReadLine());
        // space between
        Console.WriteLine("");
        Console.WriteLine("");

        // graph sect
        Console.WriteLine("Points for Game");

        printgraphPlayer("Art",Art);
        printgraphPlayer("Bob", Bob);
        printgraphPlayer("Cal",Cal);
        printgraphPlayer("Dan",Dan);
        printgraphPlayer("Eli",Eli);
        
    }
}