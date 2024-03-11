namespace ConsoleApp1
{
    

    internal class Program
    {
        static void enterMenu()
        {
            Console.Write("enterMenu choice : " );
        }
        static void Main(string[] args)
        {
            enterMenu();

            Console.Write("");
            int yes = Convert.ToInt32(Console.ReadLine());

            if(yes == 0)
            {
                Console.WriteLine("yes marn");
            }
        }
    }
}
