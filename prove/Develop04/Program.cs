using System;

class Program
{
    static void Main(string[] args)
    {
        string menu = "Menu Options:\n  1. Start breathing activity.\n  2. Start reflecting activity\n  3. Start listing activity.\n  4. Quit.\nSelect a choice from the menu: ";
        Console.Clear();
        Console.Write(menu);
        int choice = Convert.ToInt32(Console.ReadLine());

        while (choice != 4)
        {
            switch (choice)
            {
                case 1:
                    BreathingActivity br = new BreathingActivity();
                    br.Run();
                    break;
                case 2:
                    ReflectingActivity br2 = new ReflectingActivity();
                    br2.Run();
                    break;
                case 3:
                    ListingActivity br3 = new ListingActivity();
                    br3.Run();
                    break;
                default:
                    Console.WriteLine("You entered an incorrect number, please try again");
                    break;
            }
            Console.Clear();
            Console.Write(menu);
            choice = Convert.ToInt32(Console.ReadLine());
        }
    }
}