using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string reply = "";
            bool game = true;
            do
            {
                GameBoard('X', 'O');
                while (game == true)
                {
                    Console.WriteLine($"Do you wish to play again? (Y/N)");
                    reply = Console.ReadLine();

                    if ((reply == "y") || (reply == "Y"))
                    {
                        Console.WriteLine();
                        GameBoard('X', 'O');
                    }
                    else if ((reply == "n") || (reply == "N"))
                    {
                        break;
                    }
                }
            } while (game == false);
        }

        public static char[,] GameBoard(char X, char Y)
        {
            string[] playerName = new string[2];

            Console.WriteLine($"Welcome to the TicTacToe gameboard");
            Console.WriteLine($"Player 1 enter your name");
            playerName[0] = Console.ReadLine();

            Console.WriteLine($"Player 2 enter your name");
            playerName[1] = Console.ReadLine();
            Console.WriteLine($"Enjoy the game and good luck players\n");

            char[,] ticTacToeBoard = new char[,]
            {
                { '-', '-', '-' },
                { '-', '-', '-' },
                { '-', '-', '-' },
                { '-', '-', '-' }
            };

            for (int turns = 0; turns < 9; turns++)
            {
                bool playerTurn = true;
                char player = 'X';
                int playerNumber = 0;
                if (turns % 2 == 1)
                {
                    player = 'O';
                    playerNumber = 1;
                }

                int r = 0;
                int c = 0;
                try
                {
                    do
                    {
                        Console.Write($"{playerName[playerNumber]}, please pick a number for your row: ");
                        r = int.Parse(Console.ReadLine());

                        while (r < 0 || r > 2)
                        {
                            Console.WriteLine($"{playerName[playerNumber]}, invalid number. Pick a number between 0-2 ");
                            Console.Write($"{playerName[playerNumber]}, pick a number for your row again: ");
                            r = int.Parse(Console.ReadLine());
                        }

                        Console.Write($"{playerName[playerNumber]}, please pick a number for your column: ");
                        c = int.Parse(Console.ReadLine());

                        while (c < 0 || c > 2)
                        {
                            Console.WriteLine($"{playerName[playerNumber]}, invalid number. Pick a number between 0-2");
                            Console.Write($"{playerName[playerNumber]}, pick a number for your column again: ");
                            c = int.Parse(Console.ReadLine());
                        }

                        if (ticTacToeBoard[r, c] == 'X' || ticTacToeBoard[r, c] == 'O')
                        {
                            Console.WriteLine($"Lost your turn {playerName[playerNumber]}. Spot has been taken. Next player ");
                        }
                        else
                        {
                            ticTacToeBoard[r, c] = player;
                        }

                        PrintBoard(ticTacToeBoard);

                    } while (playerTurn == false);

                    if (Winner(ticTacToeBoard, playerName) == true)
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{playerName[playerNumber]}, you lost your turn. (Please enter only numbers on your next turn)\n");
                }

            }


            return ticTacToeBoard;

            static void PrintBoard(char[,] ticTacToeBoard)
            {
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        Console.Write(ticTacToeBoard[row, col]);
                    }
                    Console.WriteLine();
                }
            }

            static bool Winner(char[,] ticTacToe, string[] PlayerName)
            {
                int playerNumber = 0;
                if ((ticTacToe[0, 0] == 'X' && ticTacToe[0, 1] == 'X' && ticTacToe[0, 2] == 'X') || (ticTacToe[0, 0] == 'O' && ticTacToe[0, 1] == 'O' && ticTacToe[0, 2] == 'O'))
                {
                    if (ticTacToe[0, 0] == 'X')
                    {
                        Console.WriteLine($"Congratulations {PlayerName[0]}, You won!!\n");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations {PlayerName[1]}, You won!!\n");
                    }
                    return true;
                }
                else if ((ticTacToe[1, 0] == 'X' && ticTacToe[1, 1] == 'X' && ticTacToe[1, 2] == 'X') || (ticTacToe[1, 0] == 'O' && ticTacToe[1, 1] == 'O' && ticTacToe[1, 2] == 'O'))
                {
                    if (ticTacToe[1, 0] == 'X')
                    {
                        Console.WriteLine($"Congratulations {PlayerName[0]}, You won!!\n");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations {PlayerName[1]}, You won!!\n");
                    }
                    return true;
                }
                else if ((ticTacToe[2, 0] == 'X' && ticTacToe[2, 1] == 'X' && ticTacToe[2, 2] == 'X') || (ticTacToe[2, 0] == 'O' && ticTacToe[2, 1] == 'O' && ticTacToe[2, 2] == 'O'))
                {
                    if (ticTacToe[2, 0] == 'X')
                    {
                        Console.WriteLine($"Congratulations {PlayerName[0]}, You won!!\n");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations {PlayerName[1]}, You won!!\n");
                    }
                    return true;
                }
                else if ((ticTacToe[0, 0] == 'X' && ticTacToe[1, 0] == 'X' && ticTacToe[2, 0] == 'X') || (ticTacToe[0, 0] == 'O' && ticTacToe[1, 0] == 'O' && ticTacToe[2, 0] == 'O'))
                {
                    if (ticTacToe[0, 0] == 'X')
                    {
                        Console.WriteLine($"Congratulations {PlayerName[0]}, You won!!\n");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations {PlayerName[1]}, You won!!\n");
                    }
                    return true;
                }
                else if ((ticTacToe[0, 1] == 'X' && ticTacToe[1, 1] == 'X' && ticTacToe[2, 1] == 'X') || (ticTacToe[0, 1] == 'O' && ticTacToe[1, 1] == 'O' && ticTacToe[2, 1] == 'O'))
                {
                    if (ticTacToe[0, 1] == 'X')
                    {
                        Console.WriteLine($"Congratulations {PlayerName[0]}, You won!!\n");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations {PlayerName[1]}, You won!!\n");
                    }
                    return true;
                }
                else if ((ticTacToe[0, 2] == 'X' && ticTacToe[1, 2] == 'X' && ticTacToe[2, 2] == 'X') || (ticTacToe[0, 2] == 'O' && ticTacToe[1, 2] == 'O' && ticTacToe[2, 2] == 'O'))
                {
                    if (ticTacToe[0, 2] == 'X')
                    {
                        Console.WriteLine($"Congratulations {PlayerName[0]}, You won!!\n");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations {PlayerName[1]}, You won!!\n");
                    }
                    return true;
                }
                else if ((ticTacToe[0, 0] == 'X' && ticTacToe[1, 1] == 'X' && ticTacToe[2, 2] == 'X') || (ticTacToe[0, 0] == 'O' && ticTacToe[1, 1] == 'O' && ticTacToe[2, 2] == 'O'))
                {
                    if (ticTacToe[0, 0] == 'X')
                    {
                        Console.WriteLine($"Congratulations {PlayerName[0]}, You won!!\n");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations {PlayerName[1]}, You won!!\n");
                    }
                    return true;
                }
                else if ((ticTacToe[0, 2] == 'X' && ticTacToe[1, 1] == 'X' && ticTacToe[2, 0] == 'X') || (ticTacToe[0, 2] == 'O' && ticTacToe[1, 1] == 'O' && ticTacToe[2, 0] == 'O'))
                {
                    if (ticTacToe[0, 2] == 'X')
                    {
                        Console.WriteLine($"Congratulations {PlayerName[0]}, You won!!\n");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations {PlayerName[1]}, You won!!\n");
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
