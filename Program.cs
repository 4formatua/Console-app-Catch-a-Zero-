using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// DISCLAIMER: IT'S A CODE JUST FOR TEST MY cycles, conditionals and loops. 
namespace GuessTheNumberGame
{
                    
    class Program
    {
        static void Main(string[] args)
        {
            string playerName1;
            string playerName2;
           // string playerName3;
           // string playerName4;
            int enterNumber = 0;
            bool WinPlayer1 = false;
            bool WinPlayer2 = false;
           // bool WinPlayer3 = false;
            //bool WinPlayer4 = false;
            bool hadwin = false;
            int maxV = 0;
            bool CheckInput = false;
           // bool PlayerTest = true;
         //   int maxAmountOfPlayer = 4;
          //  int currentAmounOfPlayer = 0; 
            Console.WriteLine("---------------------CATCH UP A ZERO v1.0.3------------------\n" +
                "To win, go to zero faster than your opponent using numbers one through four");




            // disallow the typing of that character; - DONE!
            // Add option to add maxValue of gameNumber - DONE! || Add option to add player amount; 
            // Add Single player game. its will little bit hard if i will try to create AI. So mb i will make random number pick


            while (hadwin == false)
            {
                Random rand = new Random();


             /*   while (true) {
                    try
                    {
                        Console.WriteLine("Pick a amount of Players");
                        currentAmounOfPlayer = Convert.ToInt32(Console.ReadLine());
                        if (currentAmounOfPlayer > maxAmountOfPlayer && currentAmounOfPlayer < 2)
                        {
                            Console.WriteLine($"Amont of player can't be greater than {maxAmountOfPlayer} and less than 2");
                            PlayerTest = false;
                        }
                        else
                        {
                            PlayerTest = true;
                        }
                    }
                   catch
                    {
                        Console.WriteLine("Your enter wrong symbol ");
                        PlayerTest = false;
                    }

                }*/

                Console.WriteLine("Enter name of player 1: ");
                playerName1 = Console.ReadLine();
                Console.WriteLine("Enter name of player 2: ");
                playerName2 = Console.ReadLine();

                while (CheckInput == false) 
                {
                    try
                    {
                        Console.WriteLine("Enter MaxValue of game number: ");
                        maxV = Convert.ToInt32(Console.ReadLine());
                        if (maxV >= 12)
                           {
                            CheckInput = true;
                           }
                        else
                        {
                            Console.WriteLine("Your max value can't be less then 12");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Your enter wrong symbol ");
                        CheckInput = false;
                    }
                }
               
                
                for (int gameNumber = rand.Next(12, maxV); gameNumber != 0; gameNumber -= enterNumber)
                {

                    gameNumber += enterNumber;
                    
                    do
                    {

                        WinPlayer1 = true;

                        Console.Write($"Move {playerName1}: ");

                        try
                        {
                            enterNumber = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Your enter wrong symbol ");
                        }
                        if (enterNumber < 1 || enterNumber > 4)
                        {
                            Console.WriteLine("Enter a valid value");
                        }
                    } while ((enterNumber < 1 || enterNumber > 4));

                    if ((gameNumber -= enterNumber) < 0)
                    {
                        Console.WriteLine("Result can't be negative. Move goes to opponent");
                        gameNumber += enterNumber;


                    }
                    else
                    {
                        Console.WriteLine($"Number is: {gameNumber}");
                    }
                    enterNumber = 0;


                    if (gameNumber == 0 && WinPlayer1 == true)
                    {
                        Console.WriteLine($"{playerName1}: WON THE GAME");
                        hadwin = true;
                        break;
                    }
                    if (gameNumber == 0 && WinPlayer2 == true)
                    {
                        Console.WriteLine($"{playerName2}: WON THE GAME");
                        hadwin = true;
                        break;
                    }

                    do
                    {
                        WinPlayer2 = true;

                        Console.Write($"Move {playerName2}: ");
                        try
                        {
                            enterNumber = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Your enter wrong symbol ");
                        }
                        if (enterNumber < 1 || enterNumber > 4)
                        {
                            Console.WriteLine("Enter a valid value");
                        }
                    } while ((enterNumber < 1 || enterNumber > 4));

                    if ((gameNumber -= enterNumber) < 0)
                    {
                        Console.WriteLine("Result can't be negative. Move goes to opponent");
                        gameNumber += enterNumber;


                    }
                    else
                    {
                        Console.WriteLine($"Number is: {gameNumber}");
                    }
                    enterNumber = 0;


                    if (gameNumber == 0 && WinPlayer1 == true)
                    {
                        Console.WriteLine($"{playerName1}: WON THE GAME");
                        hadwin = true;
                        break;
                    }
                    if (gameNumber == 0 && WinPlayer2 == true)
                    {
                        Console.WriteLine($"{playerName2}: WON THE GAME");
                        hadwin = true;
                        break;
                    }

                }
                Console.WriteLine("Play again? Type YES");
                string answer;
                answer = Console.ReadLine();
                if (answer == "YES")
                {
                    hadwin = false;
                    CheckInput = false;
                }
                
            }

        }

    }
}
