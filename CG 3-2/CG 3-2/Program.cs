using System;

namespace CG_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //step one was testing out the code below. it works so now to make it more interesting. 
            //Console.WriteLine("Guess a number between 1 and 10: ");
            //Console.ReadLine();

            //tried to combine the if and else if with this assignment. My problem is that if you type no it gives the right response but still 
            //prompts you to choose a number between 1 and 10. What would I do to have it end if they say no? 
                Console.WriteLine("Do you want to play a game? Type yes or no");
                string userValue = Console.ReadLine();
                string message = " ";

                if (userValue == "yes")
                    message = "Okay, great! Select the enter key to continue: ";
                else
                    message = "Bummer, see you later!";

                Console.WriteLine(message);
                Console.ReadLine();
            
            //I realized that I could not use the userValue and message again so I renamed to userResponse and response. This makes sense to me
            //because it is the response of the user that they put in. 
            Console.WriteLine("Choose a number between 1 and 10: ");
            string userResponse = Console.ReadLine();

            string response = (userResponse == "8") ? "You win!" : "You lose!";

            Console.WriteLine(response);
            Console.ReadLine();
      
        }
    }
}
