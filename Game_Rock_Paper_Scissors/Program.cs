using System;

namespace Game_Rock_Paper_Scissors
{
    class MainClass
    {
        // Logo
        private static void GameLogo()
        {
            Console.WriteLine(@"__________ ________  _________  ____  __.   ");
            Console.WriteLine(@"\______   \\_____  \ \_   ___ \|    |/ _|   ");
            Console.WriteLine(@" |       _/ /   |   \/    \  \/|      <     ");
            Console.WriteLine(@" |    |   \/    |    \     \___|    |  \    ");
            Console.WriteLine(@" |____|_  /\_______  /\______  /____|__ \ /\");
            Console.WriteLine(@"        \/         \/        \/        \/ )/");
            Console.WriteLine(@"__________  _____ _______________________________    ");
            Console.WriteLine(@"\______   \/  _  \\______   \_   _____/\______   \   ");
            Console.WriteLine(@" |     ___/  /_\  \|     ___/|    __)_  |       _/   ");
            Console.WriteLine(@" |    |  /    |    \    |    |        \ |    |   \   ");
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

        // Start Logo
        private static void StartLogo()
        {
            Console.WriteLine(@"   ______________    ____  ______");
            Console.WriteLine(@"  / ___/_  __/   |  / __ \/_  __/");
            Console.WriteLine(@"  \__ \ / / / /| | / /_/ / / /   ");
            Console.WriteLine(@" ___/ // / / ___ |/ _, _/ / /    ");
            Console.WriteLine(@"/____//_/ /_/  |_/_/ |_| /_/     ");
            Console.WriteLine();
        }

        // Game Over Logo
        private static void GameOverLogo()
        {
            Console.WriteLine(@"   _________    __  _________                     ");
            Console.WriteLine(@"  / ____/   |  /  |/  / ____/                     ");
            Console.WriteLine(@" / / __/ /| | / /|_/ / __/ ____ _    ____________ ");
            Console.WriteLine(@"/ /_/ / ___ |/ /  / / /___/ __ \ |  / / ____/ __ \");
            Console.WriteLine(@"\____/_/  |_/_/  /_/_____/ / / / | / / __/ / /_/ /");
            Console.WriteLine(@"                        / /_/ /| |/ / /___/ _, _/ ");
            Console.WriteLine(@"                        \____/ |___/_____/_/ |_|  ");
            Console.WriteLine();
        }
        // Round 1 Graph
        private static void Round1Logo()
        {
            Console.WriteLine(@"    ____                        __        ___");
            Console.WriteLine(@"   / __ \____  __  ______  ____/ /  _    <  /");
            Console.WriteLine(@"  / /_/ / __ \/ / / / __ \/ __  /  (_)   / / ");
            Console.WriteLine(@" / _, _/ /_/ / /_/ / / / / /_/ /  _     / /  ");
            Console.WriteLine(@"/_/ |_|\____/\__,_/_/ /_/\__,_/  (_)   /_/   ");
            Console.WriteLine();
        }
        // Round 2 Graph
        private static void Round2Logo()
        {
            Console.WriteLine(@"    ____                        __        ___ ");
            Console.WriteLine(@"   / __ \____  __  ______  ____/ /  _    |__ \");
            Console.WriteLine(@"  / /_/ / __ \/ / / / __ \/ __  /  (_)   __/ /");
            Console.WriteLine(@" / _, _/ /_/ / /_/ / / / / /_/ /  _     / __/ ");
            Console.WriteLine(@"/_/ |_|\____/\__,_/_/ /_/\__,_/  (_)   /____/ ");
            Console.WriteLine();
        }
        // Round 3 Graph
        private static void Round3Logo()
        {
            Console.WriteLine(@"    ____                        __        _____");
            Console.WriteLine(@"   / __ \____  __  ______  ____/ /  _    |__  /");
            Console.WriteLine(@"  / /_/ / __ \/ / / / __ \/ __  /  (_)    /_ < ");
            Console.WriteLine(@" / _, _/ /_/ / /_/ / / / / /_/ /  _     ___/ / ");
            Console.WriteLine(@"/_/ |_|\____/\__,_/_/ /_/\__,_/  (_)   /____/  ");
            Console.WriteLine();
        }



        //PlayerStats
        private static void PlayerStats(string playerName, int playerAge, int roundsPlayed, int gamesWon)
        {
            Console.WriteLine("===============================================");
            Console.WriteLine($"<<< {playerName} >>>");
            Console.WriteLine($"Age: {playerAge}");
            Console.WriteLine($"Rounds played: {roundsPlayed}");
            Console.WriteLine($"Games won: {gamesWon}");
            Console.WriteLine("===============================================");
            Console.WriteLine();
        }

        // AI
        private static int ComputerAi()
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

            int roundsPlayed = 0;
            int gamesWon = 0;

            Console.Write("Enter your age:");
            int playerAge = int.Parse(Console.ReadLine());

            if(playerAge >= 12)
            {
                Console.Clear();
                StartLogo();
                PlayerStats(playerName, playerAge, roundsPlayed, gamesWon);

                Console.Write("Want to start the game? yes/no:");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                GameOverLogo();
                Console.WriteLine("=========================================================");
                Console.WriteLine($"Sorry, {playerName}, this game can be played from 12 years old.");
                Console.WriteLine("=========================================================");
            }

        }
    }
}
