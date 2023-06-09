using System;

class Program
{
    static void Main(string[] args)
    {
        // Display the text.
        Text lorem = new Text();
        lorem.DisplayText();

        // Start event controlled loop.
        bool run = true;
        while (run == true){
            Console.WriteLine("Press enter to hide words or type quit");
            string userInput = Console.ReadLine();
            
            // If they press enter hide random words and display text.
            if (userInput == "")
            {
                lorem.hideWords();
                lorem.DisplayText();
            }
            
            // End program is quit entered.
            else if (userInput.ToLower() == "quit")
            {
                run = false;
            }
            
            // Handle invalid input.
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}