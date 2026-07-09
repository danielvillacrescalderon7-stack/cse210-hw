using System;


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        PromptGenerator prompts = new PromptGenerator();


        string choice = "";


        while (choice != "5")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("Choose an option: ");

            choice = Console.ReadLine();



            if (choice == "1")
            {
                string prompt = prompts.GetRandomPrompt();


                Console.WriteLine(prompt);

                Console.Write("> ");

                string response = Console.ReadLine();



                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();

                entry._promptText = prompt;

                entry._entryText = response;



                journal.AddEntry(entry);
            }



            else if (choice == "2")
            {
                journal.DisplayAll();
            }



            else if (choice == "3")
            {
                Console.Write("Filename: ");

                string filename = Console.ReadLine();


                journal.LoadFromFile(filename);
            }



            else if (choice == "4")
            {
                Console.Write("Filename: ");

                string filename = Console.ReadLine();


                journal.SaveToFile(filename);
            }
        }


        Console.WriteLine("Goodbye!");
    }
}

//I added automatic dates to the journal entries and crated separated classes (the ones that we discused during the team meeting)
//this makes the program easier to organise and allows future improvements. 