using System;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int low = 0;
            int high = 100;  
            int jackpot = 1000000000;
            string response = "yes";
            do
            {
                int i;
                int[] userArray = new int[6];
                Console.WriteLine("Welcome to Lucky Numbers!! \n\nThe current jackpot is $" + jackpot + "\n\n");
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

                
                Console.WriteLine("\nLet's see how you did...\n");
                Console.WriteLine("The lucky numbers are:");

                Random r = new Random();
                int[] rArray = new int[6];

                for (i = 0; i < rArray.Length; i++)
                {
                    rArray[i] = r.Next(low, high + 1);
                    Console.WriteLine("Lucky Number: " + rArray[i]);
                }

                double correct = 0;

                for (i = 0; i < rArray.Length; i++)
                {
                    if (rArray[i] == userArray[0] || rArray[i] == userArray[1] || rArray[i] == userArray[2] || rArray[i] == userArray[3] || rArray[i] == userArray[4] || rArray[i] == userArray[5] )
                    {
                        correct += 1;
                    }

                }

                Console.WriteLine("You got " + correct + " matches!");

                double reward;
                reward = (jackpot * (correct / 6)); 
                if (correct == 0)
                {
                    reward = 0;
                }
                

                Console.WriteLine("\nCongratulations you just won $" + reward + "!!!!!!!!!!");
                
                Console.WriteLine("Would you like to play again?");
                response = Console.ReadLine().ToLower();
            } while (response == "yes");
            if (response == "no")
            {
                Console.WriteLine("Thanks for playing!");
                return;
            }
            
            
        }

       

                   
              
            

            
        
        
       
        
           
       

    }
}
