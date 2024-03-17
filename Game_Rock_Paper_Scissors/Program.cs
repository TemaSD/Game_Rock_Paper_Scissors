﻿using System;

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
        //Graphic cases
        private static void GameGraphicCase(string playerName, int playerWeapon, int computerWeapon)
        {
            switch (playerWeapon)
            {
                case 1: //Player Rock
                    {
                        if (computerWeapon == 1)
                        {
                            Console.WriteLine("===============================================");
                            Console.WriteLine("   'Rock'                              'Rock' ");
                            Console.WriteLine(@"  _______                           _______  ");
                            Console.WriteLine(@"-'   ____)                         (____   '-");
                            Console.WriteLine(@"    (_____)                       (_____)    ");
                            Console.WriteLine(@"    (_____)        |DRAW|         (_____)    ");
                            Console.WriteLine(@"    (____)                         (____)    ");
                            Console.WriteLine(@"-.__(___)                           (___)__.-");
                            Console.WriteLine();
                            Console.WriteLine($"   {playerName}                         Computer");
                            Console.WriteLine("===============================================");
                            Console.WriteLine();
                        }
                        if (computerWeapon == 2)
                        {
                            Console.WriteLine("===============================================");
                            Console.WriteLine("   'Rock'                              'Paper'");
                            Console.WriteLine(@"  _______                           _______  ");
                            Console.WriteLine(@"-'   ____)                     ____(____   '-");
                            Console.WriteLine(@"    (_____)                   (______        ");
                            Console.WriteLine(@"    (_____)       <LOSE>     (______         ");
                            Console.WriteLine(@"    (____)                    (______        ");
                            Console.WriteLine(@"-.__(___)                       (__________.-");
                            Console.WriteLine();
                            Console.WriteLine($"   {playerName}                         Computer");
                            Console.WriteLine("===============================================");
                            Console.WriteLine();
                        }
                        if (computerWeapon == 3)
                        {
                            Console.WriteLine("===============================================");
                            Console.WriteLine("   'Rock'                           'Scissors'");
                            Console.WriteLine(@"  _______                           _______  ");
                            Console.WriteLine(@"-'   ____)                     ____(____   '-");
                            Console.WriteLine(@"    (_____)                   (______        ");
                            Console.WriteLine(@"    (_____)        >WIN<     (__________     ");
                            Console.WriteLine(@"    (____)                         (____)    ");
                            Console.WriteLine(@"-.__(___)                           (___)__.-");
                            Console.WriteLine();
                            Console.WriteLine($"   {playerName}                         Computer");
                            Console.WriteLine("===============================================");
                            Console.WriteLine();
                        }
                    }
                    break;

                case 2: //Player Papper
                    {
                        if (computerWeapon == 1)
                        {
                            Console.WriteLine("===============================================");
                            Console.WriteLine("   'Paper'                              'Rock'");
                            Console.WriteLine(@"  _______                           _______  ");
                            Console.WriteLine(@"-'   ____)____                     (____   '-");
                            Console.WriteLine(@"        ______)                   (_____)    ");
                            Console.WriteLine(@"         ______)     >WIN<        (_____)    ");
                            Console.WriteLine(@"        ______)                    (____)    ");
                            Console.WriteLine(@"-.__________)                       (___)__.-");
                            Console.WriteLine();
                            Console.WriteLine($"   {playerName}                         Computer");
                            Console.WriteLine("===============================================");
                            Console.WriteLine();
                        }
                        if (computerWeapon == 2)
                        {
                            Console.WriteLine("===============================================");
                            Console.WriteLine("   'Paper'                             'Paper'");
                            Console.WriteLine(@"  _______                           _______  ");
                            Console.WriteLine(@"-'   ____)____                 ____(____   '-");
                            Console.WriteLine(@"        ______)               (______        ");
                            Console.WriteLine(@"         ______)    |DRAW|   (______         ");
                            Console.WriteLine(@"        ______)               (______        ");
                            Console.WriteLine(@"-.__________)                   (__________.-");
                            Console.WriteLine();
                            Console.WriteLine($"   {playerName}                         Computer");
                            Console.WriteLine("===============================================");
                            Console.WriteLine();
                        }
                        if (computerWeapon == 3)
                        {
                            Console.WriteLine("===============================================");
                            Console.WriteLine("   'Paper'                          'Scissors'");
                            Console.WriteLine(@"  _______                           _______  ");
                            Console.WriteLine(@"-'   ____)____                 ____(____   '-");
                            Console.WriteLine(@"        ______)               (______        ");
                            Console.WriteLine(@"         ______)    <LOSE>   (__________     ");
                            Console.WriteLine(@"        ______)                    (____)    ");
                            Console.WriteLine(@"-.__________)                       (___)__.-");
                            Console.WriteLine();
                            Console.WriteLine($"   {playerName}:                        Computer");
                            Console.WriteLine("===============================================");
                            Console.WriteLine();
                        }
                    }
                    break;

                case 3: //Player Scissors
                    {
                        if (computerWeapon == 1)
                        {
                            Console.WriteLine("===============================================");
                            Console.WriteLine(" 'Scissors'                             'Rock'");
                            Console.WriteLine(@"  _______                           _______  ");
                            Console.WriteLine(@"-'   ____)____                     (____   '-");
                            Console.WriteLine(@"        ______)                   (_____)    ");
                            Console.WriteLine(@"     __________)    <LOSE>        (_____)    ");
                            Console.WriteLine(@"    (____)                         (____)    ");
                            Console.WriteLine(@"-.__(___)                           (___)__.-");
                            Console.WriteLine();
                            Console.WriteLine($"   {playerName}                         Computer");
                            Console.WriteLine("===============================================");
                            Console.WriteLine();
                        }
                        if (computerWeapon == 2)
                        {
                            Console.WriteLine("===============================================");
                            Console.WriteLine(" 'Scissors'                            'Paper'");
                            Console.WriteLine(@"  _______                           _______  ");
                            Console.WriteLine(@"-'   ____)____                 ____(____   '-");
                            Console.WriteLine(@"        ______)               (______        ");
                            Console.WriteLine(@"     __________)    >WIN<    (______         ");
                            Console.WriteLine(@"    (____)                    (______        ");
                            Console.WriteLine(@"-.__(___)                       (__________.-");
                            Console.WriteLine();
                            Console.WriteLine($"   {playerName}                         Computer");
                            Console.WriteLine("===============================================");
                            Console.WriteLine();
                        }
                        if (computerWeapon == 3)
                        {
                            Console.WriteLine("===============================================");
                            Console.WriteLine(" 'Scissors'                         'Scissors'");
                            Console.WriteLine(@"  _______                           _______  ");
                            Console.WriteLine(@"-'   ____)____                 ____(____   '-");
                            Console.WriteLine(@"        ______)               (______        ");
                            Console.WriteLine(@"     __________)    |DRAW|   (__________     ");
                            Console.WriteLine(@"    (____)                         (____)    ");
                            Console.WriteLine(@"-.__(___)                           (___)__.-");
                            Console.WriteLine();
                            Console.WriteLine($"   {playerName}                         Computer");
                            Console.WriteLine("===============================================");
                            Console.WriteLine();
                        }
                    }
                    break;

            }
        }

        //Welcome Text
        private static void WelcomeText()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine($"Welcome to the ROCK, PAPER, SCISSORS game!");
            Console.WriteLine("===============================================");
            Console.WriteLine("Rules:");
            Console.WriteLine("* The game lasts a maximum of three rounds");
            Console.WriteLine("* The winner must win more rounds than opponent");
            Console.WriteLine("* Each round you choose a weapon");
            Console.WriteLine("* 'Paper' beats 'Rock','Rock' beats 'Scissors', 'Scissors' beats 'Paper'");
            Console.WriteLine("* Have fun!");
            Console.WriteLine("===============================================");
        }

        //Player Name Enter
        private static void EnterYourName(ref string playerName)
        {
            Console.Write("Enter your nickname: ");
            playerName = Console.ReadLine();

            while (playerName.Length > 20)
            {
                Console.Write("Your name is too long! Enter a shorter nickname: ");
                playerName = Console.ReadLine();
            }
            if (playerName == "")
                playerName = "Player";
        }

        // Enter Your Age
        private static void EnterYourAge(string playerName, ref int playerAge)
        {
            Console.Write("Enter your age:");
            playerAge = int.Parse(Console.ReadLine());

            while (playerAge > 120)
            {
                Console.Write("Enter your real age: ");
                playerAge = int.Parse(Console.ReadLine());
            }
            if (playerAge < 12)
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


        // Game
        private static void GameStart(string playerName, int playerAge, ref int roundsPlayed, ref int gamesWon)
        {
            int round = 1;
            int playerWon = 0;
            int computerWon = 0;

            while (round <=3 && playerWon != 2 && computerWon != 2)
            {
                Console.Clear();
                RoundLogo(round);
                RoundScoreBoard(playerName, playerWon, computerWon);
                Console.WriteLine("===============================================");
                Console.WriteLine("Choose your weapon:");
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Paper");
                Console.WriteLine("3. Scissors");
                Console.WriteLine("===============================================");
                Console.WriteLine();
                Console.Write("Write 1, 2 or 3 to choose weapon, then press 'Enter': ");

                int playerWeapon = int.Parse(Console.ReadLine());

                if (playerWeapon > 3 || playerWeapon < 1)
                    continue;

                int computerWeapon = ComputerAi();

                switch (playerWeapon)
                {
                    case 1: //Player selected Rock
                        {
                            if (computerWeapon == 1) //vs rock
                            {
                                Console.Clear();
                                RoundLogo(round);
                                RoundScoreBoard(playerName, playerWon, computerWon);
                                GameGraphicCase(playerName, playerWeapon, computerWeapon);
                                roundsPlayed++;
                                round++;

                            }
                            if (computerWeapon == 2) //vs paper
                            {
                                computerWon++;
                                Console.Clear();
                                RoundLogo(round);
                                RoundScoreBoard(playerName, playerWon, computerWon);
                                GameGraphicCase(playerName, playerWeapon, computerWeapon);
                                roundsPlayed++;
                                round++;
                            }
                            if (computerWeapon == 3) //vs cissors
                            {
                                playerWon++;
                                Console.Clear();
                                RoundLogo(round);
                                RoundScoreBoard(playerName, playerWon, computerWon);
                                GameGraphicCase(playerName, playerWeapon, computerWeapon);
                                roundsPlayed++;
                                round++;
                            }
                        }
                        break;

                    case 2: //Player selected Paper
                        {
                            if (computerWeapon == 1) //vs rock
                            {
                                playerWon++;
                                Console.Clear();
                                RoundLogo(round);
                                RoundScoreBoard(playerName, playerWon, computerWon);
                                GameGraphicCase(playerName, playerWeapon, computerWeapon);
                                roundsPlayed++;
                                round++;

                            }
                            if (computerWeapon == 2) //vs paper
                            {
                                Console.Clear();
                                RoundLogo(round);
                                RoundScoreBoard(playerName, playerWon, computerWon);
                                GameGraphicCase(playerName, playerWeapon, computerWeapon);
                                roundsPlayed++;
                                round++;
                            }
                            if (computerWeapon == 3) //vs scissors
                            {
                                computerWon++;
                                Console.Clear();
                                RoundLogo(round);
                                RoundScoreBoard(playerName, playerWon, computerWon);
                                GameGraphicCase(playerName, playerWeapon, computerWeapon);
                                roundsPlayed++;
                                round++;
                            }
                        }
                        break;

                    case 3: //Player selected Scissors
                        {
                            if (computerWeapon == 1) //vs rock
                            {
                                computerWon++;
                                Console.Clear();
                                RoundLogo(round);
                                RoundScoreBoard(playerName, playerWon, computerWon);
                                GameGraphicCase(playerName, playerWeapon, computerWeapon);
                                roundsPlayed++;
                                round++;
                            }
                            if (computerWeapon == 2) //vs paper
                            {
                                playerWon++;
                                Console.Clear();
                                RoundLogo(round);
                                RoundScoreBoard(playerName, playerWon, computerWon);
                                GameGraphicCase(playerName, playerWeapon, computerWeapon);
                                roundsPlayed++;
                                round++;

                            }
                            if (computerWeapon == 3) //vs scissors
                            {
                                Console.Clear();
                                RoundLogo(round);
                                RoundScoreBoard(playerName, playerWon, computerWon);
                                GameGraphicCase(playerName, playerWeapon, computerWeapon);
                                roundsPlayed++;
                                round++;
                            }
                        }
                        break;
                }
                Console.WriteLine();
                Console.Write("Press 'Enter' to continue...");
                Console.ReadKey();
            }

            //Player won?
            if (playerWon > computerWon)
            {
                gamesWon++;
                Console.Clear();
                YouWonLogo();
                RoundScoreBoard(playerName, playerWon, computerWon);
                TextPlayerWin(playerName);
                PlayerStats(playerName, playerAge, roundsPlayed, gamesWon);
                Console.WriteLine();
                Console.Write("Press 'Enter' to continue...");
                Console.ReadKey();
                return;
            }
            else if (playerWon == computerWon)
            {
                Console.Clear();
                GameOverLogo();
                RoundScoreBoard(playerName, playerWon, computerWon);
                TextPlayerLose(playerName);
                PlayerStats(playerName, playerAge, roundsPlayed, gamesWon);
                Console.WriteLine();
                Console.Write("Press 'Enter' to continue...");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.Clear();
                YouLoseLogo();
                RoundScoreBoard(playerName, playerWon, computerWon);
                TextPlayerLose(playerName);
                PlayerStats(playerName, playerAge, roundsPlayed, gamesWon);
                Console.WriteLine();
                Console.Write("Press 'Enter' to continue...");
                Console.ReadKey();
                return;
            }

        }

        //Main Menu
        public static void Main(string[] args)
        {
            GameLogo();

            WelcomeText();

            string playerName = "Player";
            int playerAge = 0;
            int roundsPlayed = 0;
            int gamesWon = 0;

            EnterYourName(ref playerName);

            EnterYourAge(playerName, ref playerAge);

            Console.Clear();
            GameLogo();
            PlayerStats(playerName, playerAge, roundsPlayed, gamesWon);

            //Console.Write("Want to start the game? yes/no:");
            Console.ReadKey();
            GameStart(playerName, playerAge, ref roundsPlayed, ref gamesWon);
        }
    }
}
