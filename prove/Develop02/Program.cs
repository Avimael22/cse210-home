using System;

class Program
{
    static void Main(string[] args)
    {
        Prompt prompt = new Prompt();
        prompt._prompts.Add("Who was the most interesting person I interacted with today?");
        prompt._prompts.Add("What was the best part of my day?");
        prompt._prompts.Add("How did I see the hand of the lord in my life today?");
        prompt._prompts.Add("What was the strongest emotion I felt today?");
        prompt._prompts.Add("If I had one thing I could do over today, what would it be?");
        prompt._prompts.Add("What is one good thing that happened to you today?");
        prompt._prompts.Add("What is one bad thing that happened to you today?");

        string myPrompt = prompt.GetRandomPrompt();

        DateTime theCurrentTime = DateTime.Now;

        int answer = 0;
        Journal myJournal = new Journal();
        do{
            Console.WriteLine("Welcome to the Journal Entry Program");
            Console.WriteLine("Please choose one of the following options");
            Console.WriteLine("1. Write a new entry\n2.Display Entries\n3.Save entries\n4. Load entries \n5. Exit");
            answer = int.Parse(Console.ReadLine());

            if (answer == 1){
                myJournal._myEntry._date = theCurrentTime.ToShortDateString();
                myJournal._myEntry._promptText = myPrompt;
                Console.WriteLine(myJournal._myEntry._promptText);
                myJournal._myEntry._entryText = Console.ReadLine();
                myJournal.AddEntry();
            }

            else if (answer ==2){
                 myJournal.ShowEntries();
            }

            else if (answer == 3){
                Console.WriteLine("Please enter the file name to which you would like the journal entries saved.");
                myJournal._file = Console.ReadLine();
                myJournal.SaveToFile();
            }

            else if (answer == 4){
                myJournal._entries.Clear();
                Console.WriteLine("Please enter the name of the file to which you would like to read entries from.");
                myJournal._file = Console.ReadLine();
                myJournal.ReadFromFile();
            }
        }while (answer != 5);

        
        
        //myJournal._myEntry.Display();
       

    }
}