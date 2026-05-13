namespace StringToolkit
{
    internal class Game
    {
        public void Run()
        {
            bool playAgain = true;

            while (playAgain)
            {
                Console.Write("Enter a string: ");
                string input = Console.ReadLine() ?? "";

                Console.Write("Reverse (1) - Uppercase (2) - Lowercase (3): ");
                string choice = Console.ReadLine() ?? "";

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

                Console.Write("Do you want to play again? (Y/N): ");
                string response = Console.ReadLine() ?? "";

                if (response.ToUpper() != "Y")
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}
