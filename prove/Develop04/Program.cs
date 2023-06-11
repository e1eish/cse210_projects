using System;

class Program
{
    static void Main(string[] args)
    {
        Breathing breathAct = new Breathing("Welcome to the Breathing Activity.", "This activity will help you relax by walking you through breathing in adn out slowly. Clear your mind and focus on your breathing.", 5);

        Refleciton refAct = new Refleciton("Welcome to the Refletion Activity.", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it on other aspects of your life.", 5);

        Listing listAct = new Listing("Welcome to the Listing Activity.", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 5);

        int activityCount = 0;
        int breathingCount = 0;
        int reflectCount = 0;
        int listCount = 0;

        string response = "";
        string[] options = {"1","2","3","4"};
        while (response!="4")
        {
            while (options.Contains(response)==false)
            {
                Console.Clear();
                Console.Write("Menu Options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit\nSelect a choice from the menu: ");
                response = Console.ReadLine() ?? String.Empty;
                response = response.ToUpper();
            }
            switch (response)
            {
                case "4":
                    Console.WriteLine($"\nYou completed {activityCount} activities!");
                    Console.WriteLine($"You completed {breathingCount} breathing activities, {reflectCount} reflecting activities, and {listCount} listing activities!");
                    Environment.Exit(0);
                    break;
                case "1":
                    breathAct.Display();
                    activityCount++;
                    breathingCount++;
                    break;
                case "2":
                    refAct.Display();
                    activityCount++;
                    reflectCount++;
                    break;
                case "3":
                    listAct.Display();
                    activityCount++;
                    listCount++;
                    break;
            }
            response = "";
        }
    }
}