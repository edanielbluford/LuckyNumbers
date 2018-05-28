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

            string exitResp = "yes";
            Console.WriteLine(" Hey! You there! Would you like to play a game of Lucky Numbers?");

            exitResp = Console.ReadLine().ToLower();

            while (exitResp.Equals("yes"))
            {
                int luckyNumberMax = 0;
                int luckyNumberMin = 0;
                int[] chosenNumbers = new int[6];
                int numPicker;
                int[] randomNumber = new int[6];
                Random r = new Random();
                int jackpot = 1000;

                int count = 0;

                int singleRandom;





                Console.WriteLine("Great! No time to delay! Here's how it works.");
                Console.WriteLine("You have a chance of winning up to {0} dollars!", jackpot);



                Console.WriteLine("You're going to give me two numbers. Within those numbers, I'm going to write down 6 of them.");
                Console.WriteLine("I'll give you 6 chances to guess what numbers I'm thinking of. The more you guess, the more you win!");
                Console.WriteLine("");






                Console.WriteLine("Give me a starting number!");
                luckyNumberMin = int.Parse(Console.ReadLine());

                Console.WriteLine("Okay, now give me an ending number!");
                luckyNumberMax = int.Parse(Console.ReadLine());



                while ((luckyNumberMax == 0) || (luckyNumberMax <= luckyNumberMin) || (luckyNumberMax <= luckyNumberMin + 6))
                {
                    Console.WriteLine("Hm, that number is too low... Try something bigger than your starting number.");
                    luckyNumberMax = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Alright! You're doing great.");





                //Code for obtaining user numbers

                for (int i = 0; i < chosenNumbers.Length; i++)
                {
                    bool valid = false;
                    while (valid == false)
                    {
                        Console.WriteLine("Please enter a number between {0} and {1}", luckyNumberMin, luckyNumberMax);
                        numPicker = int.Parse(Console.ReadLine());
                        if ((numPicker < luckyNumberMin) || (numPicker > luckyNumberMax))
                        {
                            Console.WriteLine("Number out of Range!");
                            Console.Write("");
                        }
                        else if (chosenNumbers.Contains(numPicker))
                        {
                            Console.WriteLine("You have picked this number already!");
                            Console.Write("");
                        }
                        else
                        {
                            Console.WriteLine("Got it!");
                            Console.WriteLine("");

                            chosenNumbers[i] = numPicker;
                            valid = true;
                        }
                    }

                }






                Console.WriteLine("All done with that! Now the fun begins!");
                Console.WriteLine("These are your Numbers");
                for (int i = 0; i < chosenNumbers.Length; i++)
                {
                    Console.WriteLine("Your Number:{0}", chosenNumbers[i]);
                }

                Console.WriteLine("Now, I will choose 6 numbers!");


                // Code for determining Random Numbers
                for (int i = 0; i < randomNumber.Length; i++)
                {
                    bool valid = false;
                    while (valid == false)
                    {

                        singleRandom = r.Next(luckyNumberMin, luckyNumberMax);
                        if (randomNumber.Contains(singleRandom))
                        {
                            singleRandom = r.Next(luckyNumberMin, luckyNumberMax);
                        }
                        else
                        {

                            randomNumber[i] = singleRandom;
                            valid = true;
                        }
                    }

                    Console.WriteLine("Lucky Number:{0}", randomNumber[i]);
                }

                for (int i = 0; i < chosenNumbers.Length; i++)
                {
                    if (chosenNumbers.Contains(randomNumber[i]))
                    {
                        count = count + 1;
                    }
                    else
                    {
                        jackpot = jackpot / 2;
                    }
                }

                if (jackpot == 0)
                {
                    Console.WriteLine("Sorry you won {0} dollars.", jackpot);
                }
                else
                {
                    Console.WriteLine("You guessed {0} numbers correctly", count);
                    Console.WriteLine("You won {0} dollars!", jackpot);

                }



                Console.WriteLine("Another game for you?");
                exitResp = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Thanks for playing!");
        }


    }



}
