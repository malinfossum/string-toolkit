using System;
using System.Collections.Generic;
using System.Text;

namespace PPOppgave1
{
    internal class Game
    {

         bool playAgain = true;
         string input;
         string choice;

            public void Run()
            {
            while (playAgain)
            {

                input = "";
                choice = "";


                while (input == "")
                {

                    Console.Write("Enter a string: ");
                    input = Console.ReadLine();

                    Console.WriteLine("Reverse (1) - Uppercase (2) - Lowercase (3)");
                    choice = Console.ReadLine();

                    string result = "";

                    switch (choice)
                    {
                        case "1":
                            for (int i = input.Length - 1; i >= 0; i--)
                            {
                                result += input[i];
                            }
                            break;

                        case "2":
                            for (int i = 0; i < input.Length; i++)
                            {
                                result += char.ToUpper(input[i]);
                            }
                            break;

                        case "3":
                            for (int i = 0; i < input.Length; i++)
                            {
                                result += char.ToLower(input[i]);
                            }
                            break;
                        default:
                            result = "Invalid choice. No changes made.";
                            break;
                    }
                    Console.WriteLine(result);
                }
                Console.Write("Do you want to play again? (Y/N): ");
                string response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();
        }
    }
}

