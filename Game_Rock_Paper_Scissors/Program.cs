using System;

namespace Game_Rock_Paper_Scissors
{
    class MainClass
    {
        // AI
        private static int ComputerAI()
        {
            Random generator = new Random();

            int aiAnswer = generator.Next(1, 4);

            return aiAnswer;
        }

        // Player Win Text
        private static void TextPlayerWin(string playerName)
        {
            Random generator = new Random();

            int randomText = generator.Next(1, 4);

            if (randomText == 1)
                Console.WriteLine($"Congratulations, {playerName}, YOU WIN!");
            if (randomText == 2)
                Console.WriteLine($"All Hail {playerName}! The WINNER!");
            if (randomText == 3)
                Console.WriteLine($"Winner Winner Chiken Dinner!");
        }

        // Player Lose Text
        private static void TextPlayerLose(string playerName)
        {
            Random generator = new Random();

            int randomText = generator.Next(1, 4);

            if (randomText == 1)
                Console.WriteLine($"Sorry, {playerName}, you lose:( Don't give up!");
            if (randomText == 2)
                Console.WriteLine($"Defeat. Better luck next time.");
            if (randomText == 3)
                Console.WriteLine($"You lose, but next time you will win!");
        }

        //Game
        public static void Main(string[] args)
        {
            Console.Write("Enter your nickname:");
            string playerName = Console.ReadLine();

            Console.Write("Enter your age:");
            string playerAge = Console.ReadLine();


            Console.WriteLine($"<<< {playerName} >>>");
            Console.WriteLine($"Age: {playerAge}");
            Console.WriteLine($"Rounds played: 24");
            Console.WriteLine($"Games won: 5");

        }
    }
}
