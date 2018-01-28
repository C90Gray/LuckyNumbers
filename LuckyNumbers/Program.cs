using System;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int low = 0;
            int high = 100;  
            int jackpot = 9450000;
            string response = "yes";
            do
            {
                int i;
                int[] userArray = new int[6];
                Console.WriteLine("Welcome to:");
                Console.WriteLine("");
                Console.WriteLine("         __                               __  __  __  ___");
                Console.WriteLine("|   |  | |  |.' '. .'  |'.  | |  | |'..'| |_| |_  |_| |__");
                Console.WriteLine("|__ |__| |_ |'.   |    |  '.| |__| |    | |_| |__ |'. __| \n");
                Console.WriteLine("The current jackpot is $" + jackpot);
                Console.WriteLine("\nGuess all 6 numbers correctly to win it all!!");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadLine();
                Console.WriteLine("Please enter a lower bounds number.");
                low = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a higher bounds number.");
                high = int.Parse(Console.ReadLine());
               
                for (i = 0; i < userArray.Length; i++)
                {
                        Console.WriteLine("Please enter a number you think will match the winning numbers.");
                        userArray[i] = int.Parse(Console.ReadLine());
                    if (userArray[i] < low || userArray[i] > high)
                    {
                        Console.WriteLine("This number is out of range. Please try again");
                        userArray[i] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Thank you for your input. \n\nThe numbers you chose are:");
                for (i = 0; i < userArray.Length; i++)
                {
                        Console.WriteLine(userArray[i]);
                }

                
                Console.WriteLine("Let's see how you did...Press any key to see the winning numbers");
                Console.ReadLine();
                Console.WriteLine("The lucky numbers are:");

                Random r = new Random();
                int[] rArray = new int[6];

                int j;
                for (i = 0; i < rArray.Length; i++)
                {
                    rArray[i] = r.Next(low, high + 1);
                    for (j = 0; j < rArray.Length; j++)


                        if ((rArray[i] == rArray[j]) && (i != j))
                    {
                        i--;
                        break;
                    }
                }

                for (i = 0; i < rArray.Length; i++)
                {
                    Console.WriteLine("Lucky Number: " + rArray[i]);
                }
            
                double correct = 0;

                for (i = 0; i < rArray.Length; i++)
                {
                    for (j = 0; j < userArray.Length; j++)
                    if (rArray[i] == userArray[j])
                    {
                        correct += 1;
                    }

                }

                Console.WriteLine("\nYou got " + correct + " matches!");

                double reward;
                reward = (jackpot * (correct / 6)); 
                if (correct == 0)
                {
                    reward = 0;
                }
                Console.WriteLine("\nCalculating your winnings...press any key to continue");
                Console.ReadLine();

                Console.WriteLine("\nCongratulations you just won $" + reward + "!!!!!!!!!!");
                Console.WriteLine("\nPlease see Pete Fittante to collect your reward.");
                Console.WriteLine("\nWould you like to play again?");
                response = Console.ReadLine().ToLower();
            } while (response == "yes");
            if (response == "no")
            {
                Console.WriteLine("\n\t\t\tThanks for playing!");
                return;
            }
            
            
        }

       

                   
              
            

            
        
        
       
        
           
       

    }
}
