using System;

namespace Game_Rock_Paper_Scissors
{
    class MainClass
    {
        // Logo
        private static void GameLogo()
        {
            Console.WriteLine(@"    ____  ____  ________ __                                ");
            Console.WriteLine(@"   / __ \/ __ \/ ____/ //_/  ____  ___    ____  __________ ");
            Console.WriteLine(@"  / /_/ / / / / /   / ,<    / __ \/   |  / __ \/ ____/ __ \");
            Console.WriteLine(@" / _, _/ /_/ / /___/ /| |_ / /_/ / /| | / /_/ / __/ / /_/ /");
            Console.WriteLine(@"/_/ |_|\____/\____/_/ |_( ) ____/ ___ |/ ____/ /___/ _, _/ ");
            Console.WriteLine(@"   _____ _______________|/_/_ _/_/  |_/_/ __/_____/_/ |_( )");
            Console.WriteLine(@"  / ___// ____/  _/ ___/ ___// __ \/ __ \/ ___/         |/ ");
            Console.WriteLine(@"  \__ \/ /    / / \__ \\__ \/ / / / /_/ /\__ \             ");
            Console.WriteLine(@" ___/ / /____/ / ___/ /__/ / /_/ / _, _/___/ /             ");
            Console.WriteLine(@"/____/\____/___//____/____/\____/_/ |_|/____/              ");
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
        // Round Graph
        private static void RoundLogo(int round)
        {
            if (round == 1)
            {
                Console.WriteLine(@"    ____                        __        ___");
                Console.WriteLine(@"   / __ \____  __  ______  ____/ /  _    <  /");
                Console.WriteLine(@"  / /_/ / __ \/ / / / __ \/ __  /  (_)   / / ");
                Console.WriteLine(@" / _, _/ /_/ / /_/ / / / / /_/ /  _     / /  ");
                Console.WriteLine(@"/_/ |_|\____/\__,_/_/ /_/\__,_/  (_)   /_/   ");
                Console.WriteLine();
            }
            if (round == 2)
            {
                Console.WriteLine(@"    ____                        __        ___ ");
                Console.WriteLine(@"   / __ \____  __  ______  ____/ /  _    |__ \");
                Console.WriteLine(@"  / /_/ / __ \/ / / / __ \/ __  /  (_)   __/ /");
                Console.WriteLine(@" / _, _/ /_/ / /_/ / / / / /_/ /  _     / __/ ");
                Console.WriteLine(@"/_/ |_|\____/\__,_/_/ /_/\__,_/  (_)   /____/ ");
                Console.WriteLine();
            }
            if (round == 3)
            {
                Console.WriteLine(@"    ____                        __        _____");
                Console.WriteLine(@"   / __ \____  __  ______  ____/ /  _    |__  /");
                Console.WriteLine(@"  / /_/ / __ \/ / / / __ \/ __  /  (_)    /_ < ");
                Console.WriteLine(@" / _, _/ /_/ / /_/ / / / / /_/ /  _     ___/ / ");
                Console.WriteLine(@"/_/ |_|\____/\__,_/_/ /_/\__,_/  (_)   /____/  ");
                Console.WriteLine();
            }
        }
        // You Won Graph
        private static void YouWonLogo()
        {
            Console.WriteLine(@"__  __                                 ");
            Console.WriteLine(@"\ \/ /___  __  ___       ______  _   __");
            Console.WriteLine(@" \  / __ \/ / / / |     / / __ \/ | / /");
            Console.WriteLine(@" / / /_/ / /_/ /| | /| / / / / /  |/ / ");
            Console.WriteLine(@"/_/\____/\__,_/ | |/ |/ / /_/ / /|  /  ");
            Console.WriteLine(@"                |__/|__/\____/_/ |_/   ");
            Console.WriteLine();
        }
        // You Lose Graph
        private static void YouLoseLogo()
        {
            Console.WriteLine(@"    ____  _____________________  ______");
            Console.WriteLine(@"   / __ \/ ____/ ____/ ____/   |/_  __/");
            Console.WriteLine(@"  / / / / __/ / /_  / __/ / /| | / /   ");
            Console.WriteLine(@" / /_/ / /___/ __/ / /___/ ___ |/ /    ");
            Console.WriteLine(@"/_____/_____/_/   /_____/_/  |_/_/     ");
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
        // Round Score Board
        private static void RoundScoreBoard(string playerName, int playerWon, int computerWon)
        {
            Console.WriteLine($"<<< {playerName} {playerWon} : {computerWon} Computer >>>");
            Console.WriteLine();
        }

        // Age Check
        private static void AgeCheck(string playerName, int playerAge)
        {
            if(playerAge < 12)
            {
                Console.Clear();
                GameOverLogo();
                Console.WriteLine("=========================================================");
                Console.WriteLine($"Sorry, {playerName}, this game can be played from 12 years old.");
                Console.WriteLine("=========================================================");
                Console.WriteLine();
                Console.WriteLine("To Exit press 'Enter'...");
                Console.ReadKey(); 
                Environment.Exit(0);
            }
        }

        // Game
        private static void GameStart(string playerName)
        {
            int round = 1;
            int playerWon = 0;
            int computerWon = 0;

            while (round<=3)
            {
                Console.Clear();
                RoundLogo(round);
                RoundScoreBoard(playerName, playerWon, computerWon);
                Console.WriteLine("Select weapon:");

                int playerWeapon = int.Parse(Console.ReadLine());
                int computerWeapon = ComputerAi();

                if (playerWeapon > 3 || playerWeapon < 1)
                    continue;

                switch (playerWeapon)
                {
                    case 1: //Player selected Rock
                        {
                            if (computerWeapon == 1)
                            {
                                Console.Clear();
                                RoundLogo(round);
                                RoundScoreBoard(playerName, playerWon, computerWon);
                                Console.WriteLine($"You selected 'Rock'");
                                Console.WriteLine($"Computer selected 'Rock'");
                                Console.WriteLine($"Game Draw");
                                round++;

                            }
                            if (computerWeapon == 2)
                            {
                                computerWon++;
                                Console.Clear();
                                RoundLogo(round);
                                RoundScoreBoard(playerName, playerWon, computerWon);
                                Console.WriteLine($"You selected 'Rock'");
                                Console.WriteLine($"Computer selected 'Paper'");
                                Console.WriteLine($"You Lose");
                                round++;
                            }
                            if (computerWeapon == 3)
                            {
                                playerWon++;
                                Console.Clear();
                                RoundLogo(round);
                                RoundScoreBoard(playerName, playerWon, computerWon);
                                Console.WriteLine($"You selected 'Rock'");
                                Console.WriteLine($"Computer selected 'Scissors'");
                                Console.WriteLine($"You Win");
                                round++;
                            }
                        }
                        break;

                    case 2: //Player selected Paper
                        {
                            if (computerWeapon == 1)
                            {
                                playerWon++;
                                Console.Clear();
                                RoundLogo(round);
                                RoundScoreBoard(playerName, playerWon, computerWon);
                                Console.WriteLine($"You selected 'Paper'");
                                Console.WriteLine($"Computer selected 'Rock'");
                                Console.WriteLine($"You Win");
                                round++;

                            }
                            if (computerWeapon == 2)
                            {
                                Console.Clear();
                                RoundLogo(round);
                                RoundScoreBoard(playerName, playerWon, computerWon);
                                Console.WriteLine($"You selected 'Paper'");
                                Console.WriteLine($"Computer selected 'Paper'");
                                Console.WriteLine($"Game Draw");
                                round++;
                            }
                            if (computerWeapon == 3)
                            {
                                computerWon++;
                                Console.Clear();
                                RoundLogo(round);
                                RoundScoreBoard(playerName, playerWon, computerWon);
                                Console.WriteLine($"You selected 'Paper'");
                                Console.WriteLine($"Computer selected 'Scissors'");
                                Console.WriteLine($"You Lose");
                                round++;
                            }
                        }
                        break;

                    case 3: //Player selected Scissors
                        {
                            if (computerWeapon == 1)
                            {
                                computerWon++;
                                Console.Clear();
                                RoundLogo(round);
                                RoundScoreBoard(playerName, playerWon, computerWon);
                                Console.WriteLine($"You selected 'Scissors'");
                                Console.WriteLine($"Computer selected 'Rock'");
                                Console.WriteLine($"You Lose");
                                round++;
                            }
                            if (computerWeapon == 2)
                            {
                                playerWon++;
                                Console.Clear();
                                RoundLogo(round);
                                RoundScoreBoard(playerName, playerWon, computerWon);
                                Console.WriteLine($"You selected 'Scissors'");
                                Console.WriteLine($"Computer selected 'Paper'");
                                Console.WriteLine($"You Win");
                                round++;

                            }
                            if (computerWeapon == 3)
                            {
                                Console.Clear();
                                RoundLogo(round);
                                RoundScoreBoard(playerName, playerWon, computerWon);
                                Console.WriteLine($"You selected 'Scissors'");
                                Console.WriteLine($"Computer selected 'Scissors'");
                                Console.WriteLine($"Game Draw");
                                round++;
                            }
                        }
                        break;
                }
                Console.Write("Press 'Enter' to continue...");
                Console.ReadKey();
            }

            //Player won?
            if (playerWon > computerWon)
            {
                Console.Clear();
                YouWonLogo();
                RoundScoreBoard(playerName, playerWon, computerWon);
                TextPlayerWin(playerName);
            }
            else
            {
                Console.Clear();
                YouLoseLogo();
                RoundScoreBoard(playerName, playerWon, computerWon);
                TextPlayerLose(playerName);
            }

        }

        //Main Menu
        public static void Main(string[] args)
        {
            GameLogo();
            Console.Write("Enter your nickname:");
            string playerName = Console.ReadLine();
            if (playerName == "")
                playerName = "Player";
            
            int roundsPlayed = 0;
            int gamesWon = 0;

            Console.Write("Enter your age:");
            int playerAge = int.Parse(Console.ReadLine());
            AgeCheck(playerName, playerAge);

            Console.Clear();
            StartLogo();
            PlayerStats(playerName, playerAge, roundsPlayed, gamesWon);

            //Console.Write("Want to start the game? yes/no:");
            //Console.ReadLine();
            GameStart(playerName);
        }
    }
}
