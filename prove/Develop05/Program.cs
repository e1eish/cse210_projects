using System;

class Program
{
    static void Main(string[] args)
    {
        User user = new User("An user");
        FileManager fileManager = new FileManager();

        string response = "";
        string[] options = {"1","2","3","4","5","6"};
        while (response!="6")
        {
            while(options.Contains(response)==false)
            {
                Console.WriteLine($"\nYou have {user.GetScore()} points.");
                Console.WriteLine($"You are level {user.GetLevel()}.\n");
                Console.WriteLine("Menu Options:");
                Console.WriteLine(" 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
                Console.Write("Select a choice from the menu: ");
                response = Console.ReadLine() ?? String.Empty;
            }
            switch (response)
            {
                case "6":
                    Environment.Exit(0);
                    break;
                case "1":
                    user.AddGoal();
                    break;
                case "2":
                    user.Display();
                    break;
                case "3":
                    Console.Write("\nEnter the name of the file to save to: ");
                    string filenameSaving = Console.ReadLine();
                    fileManager.Save(filenameSaving, user.ExportGoals());
                    Console.WriteLine("Saving complete\n");
                    break;
                case "4":
                    Console.Write("\nEnter the name of the file to load from: ");
                    string filenameLoading = Console.ReadLine();
                    user.ImportGoals(fileManager.Load(filenameLoading));
                    Console.WriteLine("Loading Complete\n");
                    break;
                case "5":
                    user.RecordEvent();
                    break;
            }
            response = "";
        }
    }
}