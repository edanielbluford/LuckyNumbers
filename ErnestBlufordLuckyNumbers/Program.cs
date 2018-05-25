using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErnestBlufordLuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int luckyNumberMax = 0;
            int luckyNumberMin = 0;
            int[] chosenNumbers = new int[6];
            int[] randomNumber = new int[6];
            Random r = new Random();
            var prizeTickets = randomNumber.Except(chosenNumbers).Count();
            string exitResp;




            Console.WriteLine("Welcome to the carnival! Step right up! Hey! You there! Would you like to play a game of Lucky Numbers?");
            exitResp = Console.ReadLine().ToLower();

            while (exitResp.Equals("yes"))
            { 
            Console.WriteLine("Great! No time to delay! Let's keep it simple. Give me a starting number!");
            luckyNumberMin = int.Parse(Console.ReadLine());

            Console.WriteLine("Okay, now give me an ending number!");
            luckyNumberMax = int.Parse(Console.ReadLine());



            while ((luckyNumberMax == 0) || (luckyNumberMax <= luckyNumberMin) || (luckyNumberMax <= luckyNumberMin + 12))
                {
                    Console.WriteLine("Hm, that number is too low... Try something bigger than your starting number.");
                    luckyNumberMax = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Alright! You're doing great.  Choose 6 numbers between your starting number and your ending number.");

                //Gathering chosen numbers loop
                for (int i = 0; i < chosenNumbers.Length; i++)
                {

                 chosenNumbers[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Got it!");
                }
            Console.WriteLine("All done with that! Now the fun begins!");

            Console.WriteLine("I'm thinking of {0} numbers, between {1} and {2}.", randomNumber.Length, luckyNumberMin, luckyNumberMax);
            Console.WriteLine("If you guess correctly, you'll win a little pocket change. The better you guess the more you'll win!");
            
            for(int i =0; i<randomNumber.Length; i++)
            {
                randomNumber[i] = r.Next(luckyNumberMin +1 , luckyNumberMax -1);
                Console.WriteLine(randomNumber[i]);
            }

             

            //if (prizePot > 0)
            //{
                Console.WriteLine("Congratulations! You won {0} tickets!", prizeTickets);
            //}
            //else if (prizePayOut == 0)
            //{
            //    Console.WriteLine("So Sorry, you didn't win anything.");
            //}
            //else
            //{
            //    Console.WriteLine("What are you doing here?");
            //}
           }
            Console.WriteLine("Another game for you?");
            exitResp = Console.ReadLine().ToLower();
        }


    }

    
}
