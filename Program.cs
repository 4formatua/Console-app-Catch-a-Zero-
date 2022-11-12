using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberGame
{
                    
    class Program
    {
        static void Main(string[] args)
        {
            string playerName1;
            string playerName2;
            int enterNumber = 0;
            bool MovePlayer1;
            bool hadwin = false;
            Console.WriteLine("---------------------CATCH UP A ZERO v1.01------------------\n" +
                "To win, go to zero faster than your opponent using numbers one through four");



           
            // disallow the typing of that character; - DONE!
            // Add option to add range of gameNumber || Add option to add player amount; 
            // Add Single player game. its will little bit hard if i will try to create AI. So mb i will make random number pick
            while (hadwin == false)
            {
                Random rand = new Random();


                Console.WriteLine("Enter name of player 1: ");
                playerName1 = Console.ReadLine();
                Console.WriteLine("Enter name of player 2: ");
                playerName2 = Console.ReadLine();
                
                for (int gameNumber = rand.Next(12, 120); gameNumber != 0; gameNumber -= enterNumber)
                {

                    gameNumber += enterNumber;
                    
                    do
                    {

                        MovePlayer1 = true;

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


                    if (gameNumber == 0 && MovePlayer1 == true)
                    {
                        Console.WriteLine($"{playerName1}: WON THE GAME");
                        hadwin = true;
                        break;
                    }
                    if (gameNumber == 0 && MovePlayer1 == false)
                    {
                        Console.WriteLine($"{playerName2}: WON THE GAME");
                        hadwin = true;
                        break;
                    }

                    do
                    {
                        MovePlayer1 = false;

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


                    if (gameNumber == 0 && MovePlayer1 == true)
                    {
                        Console.WriteLine($"{playerName1}: WON THE GAME");
                        hadwin = true;
                        break;
                    }
                    if (gameNumber == 0 && MovePlayer1 == false)
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
                }
                
            }

        }

    }
}
