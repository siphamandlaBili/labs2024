using System; // Importing necessary namespaces
using System.IO;

namespace ConsoleApp3
{
    internal class Program
    {
        // Method to display menu and get user selection
        public static int menu()
        {
            // Displaying menu options
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("******************************************************");
            Console.WriteLine("*                   Big data                         *");
            Console.WriteLine("******************************************************");
            Console.WriteLine("1: Display all data from the dataset");
            Console.WriteLine("2: Display all data based on the given year(2013 - 2021)");
            Console.WriteLine("3: Display based on the level (1-4)");
            Console.WriteLine("0: Exit ......");
            Console.WriteLine(" ");
            Console.Write("enter option number: ");
           

            return Convert.ToInt32(Console.ReadLine()); // Return user's selection
        }

        // Method to display all records from the dataset
        static void display(string path)
        {
            string filePath = $"{path}.csv";
            string[] dataRows = File.ReadAllLines(filePath);

            // Loop through each record and display it
            foreach (string row in dataRows)
            {
                string[] eachLine = row.Split(",");
                Console.WriteLine("{0}.{1},{2},{3}", eachLine[0], eachLine[1], eachLine[2], eachLine[3]);
            }
        }

        // Method to display records based on the chosen year
        static void displayByYear(string path)
        {
            Console.Write("Enter year: ");
            string yearChosen = Console.ReadLine();
            string filePath = $"{path}.csv";
            bool recordFound = false;

            string[] dataRows = File.ReadAllLines(filePath);

            // Loop through each record and check if it matches the chosen year
            foreach (string row in dataRows)
            {
                string[] eachLine = row.Split(",");
                if (eachLine[0] == yearChosen)
                {
                    // Display the record if it matches the chosen year
                    Console.WriteLine("{0}.{1},{2},{3}", eachLine[0], eachLine[1], eachLine[2], eachLine[3]);
                    recordFound = true;
                }

            }

            // Display message if no records found for the chosen year
            if (!recordFound)
            {
                Console.WriteLine("No records found for year chosen: " + yearChosen);
            }
        }

        // Method to display records based on the chosen level
        static void displayByLevel(string path)
        {
            Console.Write("Enter level e.g 1 : ");
            string levelChosen = Console.ReadLine();
            string levelString = $"Level {levelChosen}";
            string filePath = $"{path}.csv";

            string[] dataRows = File.ReadAllLines(filePath);
            bool recordFound = false;

            // Loop through each record and check if it matches the chosen level
            foreach (string row in dataRows)
            {
                string[] eachLine = row.Split(",");
                if (eachLine[1] == levelString)
                {
                    // Display the record if it matches the chosen level
                    Console.WriteLine("{0}.{1},{2},{3}", eachLine[0], eachLine[1], eachLine[2], eachLine[3]);
                    recordFound = true;
                }

            }

            // Display message if no records found for the chosen level
            if (!recordFound)
            {
                Console.WriteLine("No records found for level: " + levelString);
            }
        }

        // Main method to execute the program
        static void Main(string[] args)
        {
            int selection; // Variable to store user's selection

            do
            {
                selection = menu(); // Display menu and get user's selection

                // Execute the corresponding functionality based on user's selection
                if (selection == 0)
                {
                    Console.WriteLine("Good-Bye"); // If selection is 0, exit the program
                }
                else if (selection == 1)
                {
                    display("financial"); // If selection is 1, display all records
                }
                else if (selection == 2)
                {
                    displayByYear("financial"); // If selection is 2, display records based on year
                }
                else if (selection == 3)
                {
                    displayByLevel("financial"); // If selection is 3, display records based on level
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("invalid selection please choose from the menu again");
                    Console.WriteLine(" ");
                }

            } while (selection != 0); // Repeat until user selects 0 to exit

        }
    }
}
