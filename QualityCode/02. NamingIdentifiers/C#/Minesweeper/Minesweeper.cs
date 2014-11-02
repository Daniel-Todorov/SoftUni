//Besides renaming, I've done some minor refactoring of the code.

namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class Minesweeper
    {
        public const int BoardRows = 5;
        public const int BoardColumns = 10;
        public const int NumberOfTopPlayers = 6;
        public const int NumberOfFreeFields = 35;

        private static Random random = new Random();

        public static void Main()
        {
            string command = string.Empty;
            char[,] hiddenGameBoard = GenerateHiddenGameBoard();
            char[,] actualGameBoard = GenerateActualGameBoard();
            int counter = 0;
            bool isGameLost = false;
            List<Player> topPlayers = new List<Player>(NumberOfTopPlayers);
            int row = 0;
            int col = 0;
            bool isGameStart = true;
            bool isGameWon = false;

            do
            {
                if (isGameStart)
                {
                    Console.WriteLine(
                        "Lets play “Minesweeper”. Try your luck and find all the fields without a mine."
                        + " Command 'top' shows the leader board, 'restart' begins a new game, 'exit' ends the game.");
                    DisplayGameBoard(hiddenGameBoard);
                    isGameStart = false;
                }

                Console.Write("Type a row and column : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out col)
                        && row <= hiddenGameBoard.GetLength(0) && col <= hiddenGameBoard.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PrintLeaderBoard(topPlayers);
                        break;
                    case "restart":
                        hiddenGameBoard = GenerateHiddenGameBoard();
                        actualGameBoard = GenerateActualGameBoard();
                        DisplayGameBoard(hiddenGameBoard);
                        isGameLost = false;
                        isGameStart = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye, bye!");
                        break;
                    case "turn":
                        if (actualGameBoard[row, col] != '*')
                        {
                            if (actualGameBoard[row, col] == '-')
                            {
                                MakeGuess(hiddenGameBoard, actualGameBoard, row, col);
                                counter++;
                            }

                            if (NumberOfFreeFields == counter)
                            {
                                isGameWon = true;
                            }
                            else
                            {
                                DisplayGameBoard(hiddenGameBoard);
                            }
                        }
                        else
                        {
                            isGameLost = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalid command! Please, try again!\n");
                        break;
                }

                if (isGameLost)
                {
                    DisplayGameBoard(actualGameBoard);
                    Console.Write("\nHrrrrrr! You had a heroic death with {0} points. " + "Provide nickname for the leaderboard: ", counter);
                    string nickname = Console.ReadLine();
                    Player player = new Player(nickname, counter);

                    if (topPlayers.Count < 5)
                    {
                        topPlayers.Add(player);
                    }
                    else
                    {
                        for (int i = 0; i < topPlayers.Count; i++)
                        {
                            if (topPlayers[i].Points < player.Points)
                            {
                                topPlayers.Insert(i, player);
                                topPlayers.RemoveAt(topPlayers.Count - 1);
                                break;
                            }
                        }
                    }

                    topPlayers.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    topPlayers.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));

                    PrintLeaderBoard(topPlayers);

                    hiddenGameBoard = GenerateHiddenGameBoard();
                    actualGameBoard = GenerateActualGameBoard();
                    counter = 0;
                    isGameLost = false;
                    isGameStart = true;
                }

                if (isGameWon)
                {
                    Console.WriteLine("\nBRAVOOOOO! You opened all free {0} fields without a single drop of blood!", NumberOfFreeFields);
                    DisplayGameBoard(actualGameBoard);
                    Console.WriteLine("Please, provide a nickname for the leaderboard: ");
                    string nickname = Console.ReadLine();
                    Player player = new Player(nickname, counter);
                    topPlayers.Add(player);
                    PrintLeaderBoard(topPlayers);
                    hiddenGameBoard = GenerateHiddenGameBoard();
                    actualGameBoard = GenerateActualGameBoard();
                    counter = 0;
                    isGameWon = false;
                    isGameStart = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria, where the ladies are the prettiest!");
            Console.WriteLine("Bye, bye, bye!");
            Console.Read();
        }

        private static void PrintLeaderBoard(List<Player> players)
        {
            Console.WriteLine("\nLeaderBoard");
            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, players[i].Name, players[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty LeaderBoard!\n");
            }
        }

        private static void MakeGuess(char[,] hiddenGameBoard, char[,] actualGameBoard, int row, int col)
        {
            char numberOfNearbyMines = GetNumberOfNearbyMines(actualGameBoard, row, col);
            actualGameBoard[row, col] = numberOfNearbyMines;
            hiddenGameBoard[row, col] = numberOfNearbyMines;
        }

        private static void DisplayGameBoard(char[,] board)
        {
            int RRR = board.GetLength(0);
            int KKK = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < RRR; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < KKK; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] GenerateHiddenGameBoard()
        {
            char[,] board = new char[BoardRows, BoardColumns];

            for (int i = 0; i < BoardRows; i++)
            {
                for (int j = 0; j < BoardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] GenerateActualGameBoard()
        {
            char[,] actualGameBoard = new char[BoardRows, BoardColumns];

            for (int i = 0; i < BoardRows; i++)
            {
                for (int j = 0; j < BoardColumns; j++)
                {
                    actualGameBoard[i, j] = '-';
                }
            }

            List<int> minePositions = new List<int>();

            while (minePositions.Count < 15)
            {
                int randomNumber = random.Next(50);

                if (!minePositions.Contains(randomNumber))
                {
                    minePositions.Add(randomNumber);
                }
            }

            foreach (int position in minePositions)
            {
                int col = position / BoardColumns;
                int row = position % BoardColumns;
                if (row == 0 && position != 0)
                {
                    col--;
                    row = BoardColumns;
                }
                else
                {
                    row++;
                }

                actualGameBoard[col, row - 1] = '*';
            }

            return actualGameBoard;
        }

        private static char GetNumberOfNearbyMines(char[,] actualGameBoard, int row, int col)
        {
            int count = 0;
            int rows = actualGameBoard.GetLength(0);
            int cols = actualGameBoard.GetLength(1);

            if (row - 1 >= 0)
            {
                if (actualGameBoard[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (actualGameBoard[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (actualGameBoard[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < cols)
            {
                if (actualGameBoard[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (actualGameBoard[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (actualGameBoard[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (actualGameBoard[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (actualGameBoard[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}