
//using System;

//namespace TicTacToe
//{
//    class Program
//    {
//        static char[,] board = new char[3, 3];
//        static char currentPlayer;
//        static Random random = new Random();

//        static void Main(string[] args)
//        {
//            InitializeBoard();
//            currentPlayer = random.Next(0, 2) == 0 ? 'X' : 'O';
//            while (true)
//            {
//                PrintBoard();
//                PlayerMove();
//                if (CheckWin())
//                {
//                    PrintBoard();
//                    Console.WriteLine($"Игрок {currentPlayer} победил!");
//                    break;
//                }
//                if (IsDraw())
//                {
//                    PrintBoard();
//                    Console.WriteLine("Ничья!");
//                    break;
//                }
//                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
//            }
//        }

//        static void InitializeBoard()
//        {
//            for (int i = 0; i < 3; i++)
//                for (int j = 0; j < 3; j++)
//                    board[i, j] = ' ';
//        }

//        static void PrintBoard()
//        {
//            Console.Clear();
//            for (int i = 0; i < 3; i++)
//            {
//                Console.WriteLine($"| {board[i, 0]} | {board[i, 1]} | {board[i, 2]} |");
//                Console.WriteLine("--------------");
//            }
//        }

//        static void PlayerMove()
//        {
//            int row, col;
//            do
//            {
//                Console.WriteLine($"Игрок {currentPlayer}, введите вашу ход (строка и столбец): ");
//                var input = Console.ReadLine().Split(' ');
//                row = int.Parse(input[0]);
//                col = int.Parse(input[1]);
//            } while (row < 0 || row > 2 || col < 0 || col > 2 || board[row, col] != ' ');
//            board[row, col] = currentPlayer;
//        }

//        static bool CheckWin()
//        {
//            for (int i = 0; i < 3; i++)
//                if ((board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer) ||
//                    (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer))
//                    return true;

//            return (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
//                   (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer);
//        }

//        static bool IsDraw()
//        {
//            foreach (var cell in board)
//                if (cell == ' ')
//                    return false;
//            return true;
//        }
//    }
//}

//                   2 ex.
//using System;

//namespace TicTacToe
//{
//    class Program
//    {

//        static char[,] board = new char[3, 3];
//        static char currentPlayer;
//        static void Main(string[] args)
//        {
//            InitializeBoard();
//            currentPlayer = 'X'; // Первый игрок всегда 'X'
//            while (true)
//            {
//                PrintBoard();
//                PlayerMove();
//                if (CheckWin())
//                {
//                    PrintBoard();
//                    Console.WriteLine($"Игрок {currentPlayer} победил!");
//                    break;
//                }
//                if (IsDraw())
//                {
//                    PrintBoard();
//                    Console.WriteLine("Ничья!");
//                    break;
//                }
//                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
//            }
//        }
//        static void InitializeBoard()
//        {
//            for (int i = 0; i < 3; i++)
//                for (int j = 0; j < 3; j++)
//                    board[i, j] = ' ';
//        }

//        static void PrintBoard()
//        {
//            Console.Clear();
//            for (int i = 0; i < 3; i++)
//            {
//                Console.WriteLine($"| {board[i, 0]} | {board[i, 1]} | {board[i, 2]} |");
//                Console.WriteLine("--------------");
//            }
//        }

//        static void PlayerMove()
//        {
//            int row, col;
//            do
//            {
//                Console.WriteLine($"Игрок {currentPlayer}, введите вашу ход (строка и столбец): ");
//                var input = Console.ReadLine().Split(' ');
//                row = int.Parse(input[0]);
//                col = int.Parse(input[1]);
//            } while (row < 0 || row > 2 || col < 0 || col > 2 || board[row, col] != ' ');
//            board[row, col] = currentPlayer;
//        }

//        static bool CheckWin()
//        {
//            for (int i = 0; i < 3; i++)
//                if ((board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer) ||
//                    (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer))
//                    return true;

//            return (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
//                   (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer);
//        }

//        static bool IsDraw()
//        {
//            foreach (var cell in board)
//                if (cell == ' ')
//                    return false;
//            return true;
//        }
//    }
//}

using System;
using System.Collections.Generic;

namespace MorseCodeTranslator
{
    class Program
    {
        private static Dictionary<char, string> morseCode = new Dictionary<char, string>
        {
            {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."},
            {'E', "."}, {'F', "..-."}, {'G', "--."}, {'H', "...."},
            {'I', ".."}, {'J', ".---"}, {'K', "-.-"}, {'L', ".-.."},
            {'M', "--"}, {'N', "-."}, {'O', "---"}, {'P', ".--."},
            {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
            { 'U', "..-"}, { 'V', "...-"}, { 'W', ".--"}, { 'X', "-..-"},
            { 'Y', "-.--"}, { 'Z', "--.."},
            { '1', ".----"}, { '2', "..---"}, { '3', "...--"}, { '4', "....-"},
            { '5', "....."}, { '6', "-...."}, { '7', "--..."}, { '8', "---.."},
            { '9', "----."}, { '0', "-----"},
            { ' ', " "}
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст для перевода в азбуку Морзе:");
            string input = Console.ReadLine().ToUpper();
            string morseTranslation = TranslateToMorse(input);
            Console.WriteLine($"Азбука Морзе: {morseTranslation}");
        }

        // trim удаляет пробелы из начала и конца строчки
        static string TranslateToMorse(string input)
        {
            string morse = "";
            foreach (char c in input)
            {
                if (morseCode.ContainsKey(c))
                    morse += morseCode[c] + " ";
            }
            return morse.Trim();
        }
    }
}