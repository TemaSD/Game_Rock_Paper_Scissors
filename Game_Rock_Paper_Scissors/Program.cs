using System;

namespace Game_Rock_Paper_Scissors
{
    class MainClass
    {
        // Logo
        private static void GameLogo()
        {
            Console.WriteLine();
            Console.WriteLine(@"__________ ________  _________  ____  __.");
            Console.WriteLine(@"\______   \\_____  \ \_   ___ \|    |/ _|");
            Console.WriteLine(@" |       _/ /   |   \/    \  \/|      <");
            Console.WriteLine(@" |    |   \/    |    \     \___|    |  \");
            Console.WriteLine(@" |____|_  /\_______  /\______  /____|__ \ /\");
            Console.WriteLine(@"        \/         \/        \/        \/ )/");
            Console.WriteLine(@"__________  _____ _______________________________");
            Console.WriteLine(@"\______   \/  _  \\______   \_   _____/\______   \");
            Console.WriteLine(@" |     ___/  /_\  \|     ___/|    __)_  |       _/");
            Console.WriteLine(@" |    |  /    |    \    |    |        \ |    |   \");
            Console.WriteLine(@" |____|  \____|__  /____|   /_______  / |____|_  / /\");
            Console.WriteLine(@"                 \/                 \/         \/  )/");
            Console.WriteLine(@"  __________________ .___  _________ _________________ __________  _________");
            Console.WriteLine(@" /   _____/\_   ___ \|   |/   _____//   _____/\_____  \\______   \/   _____/");
            Console.WriteLine(@" \_____  \ /    \  \/|   |\_____  \ \_____  \  /   |   \|       _/\_____  \ ");
            Console.WriteLine(@" /        \\     \___|   |/        \/        \/    |    \    |   \/        \");
            Console.WriteLine(@"/_______  / \______  /___/_______  /_______  /\_______  /____|_  /_______  /");
            Console.WriteLine(@"        \/         \/            \/        \/         \/       \/        \/");
            Console.WriteLine();
        }

        //PlayerStats
        private static void PlayerStats(string playerName, int playerAge, int roundsPlayed, string)
        {

        }



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
            GameLogo();
            Console.Write("Enter your nickname:");
            string playerName = Console.ReadLine();

            Console.Write("Enter your age:");
            string playerAge = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"<<< {playerName} >>>");
            Console.WriteLine($"Age: {playerAge}");
            Console.WriteLine($"Rounds played: 24");
            Console.WriteLine($"Games won: 5");
            Console.WriteLine();
            
        }
    }
}
