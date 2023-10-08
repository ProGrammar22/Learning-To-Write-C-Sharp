using System;
using System.Data;


class Test
{
    static void Main(string[] args)
    {
        string d = "";
        int size = 8, setboard = 0, countblack = 0, countwhite = 0, countempty = 0, turn = 0, blank = 0, x = 0, y = 0, row = 0, col = 0;
        int[,] board = new int[size, size];

        Console.Write("Enter Board Size: ");
        string f = Console.ReadLine();

        while (!int.TryParse(f, out size) || size % 2 != 0 || size < 8 || size > 20)
        {
            Console.WriteLine("Invalid Boadrd Size, Please Enter an Even Number from 8 to 20");
            Console.Write("Enter Board Size: ");
            f = Console.ReadLine();
        }
        size = Convert.ToInt32(f);

        board = new int[size, size];
        setboard = size / 2;

        for (x = 0; x < board.GetLength(0); x++)
        {
            for (y = 0; y < board.GetLength(1); y++)
            {
                if (x == setboard && y == setboard)
                {
                    board[x, y] = 1;
                    board[x, y - 1] = 2;
                    board[x - 1, y] = 2;
                    board[x - 1, y - 1] = 1;
                }
                else
                {
                    board[x, y] = 0;
                }
            }
        }
        Console.WriteLine("Black : B" + "  White : W");
        Console.WriteLine("Enter Row And Column Number To Place Your Disk On The Board");

        Board(size, setboard, row, col, ref turn, board);

        Console.Write("Press Enter To Start");
        Console.ReadLine();

        while (countempty >= 0)
        {
            countempty = Boardfill(countempty, board, blank);
            Turn(d, ref row, ref col, ref turn, size, setboard, board, countblack, countwhite, countempty);
            countempty = Boardfill(countempty, board, blank);
        }
        for (x = 0; x < board.GetLength(0); x++)
        {
            for (y = 0; y < board.GetLength(1); y++)
            {
                if (board[x, y] == 2)
                {
                    countblack++;
                }
                if (board[x, y] == 1)
                {
                    countwhite++;
                }
            }
        }
        if (countblack > countwhite)
        {
            Console.Write("Black Wins");
        }
        else if (countwhite > countblack)
        {
            Console.Write("White Wins");
        }
        else
        {
            Console.Write("Match Draw");
        }
    }
    static void Board(int size, int setboard, int row, int col, ref int turn, int[,] board)
    {
        for (int y = 0; y < board.GetLength(1); y++)
        {
            if (y > 9)
            {
                Console.Write("  _" + y + "");
            }
            else if (y == 0)
            {
                Console.Write("   _" + y + "_");
            }
            else
            {
                Console.Write("  _" + y + "_");
            }
        }
        Console.Write("\n");
        string str = "";

        for (int x = 0; x < board.GetLength(0); x++)
        {
            if (x > 9)
            {
                str = x + "";
            }
            else
            {
                str = x + " ";
            }
            for (int y = 0; y < board.GetLength(1); y++)
            {
                str += "|_";

                if (board[x, y] == 1)
                {
                    str += "W";
                    str += "_|";
                }
                else if (board[x, y] == 2)
                {
                    str += "B";
                    str += "_|";
                }
                else if (turn == 2 && row == x && col == y && board[x, y] == 0)
                {
                    board[x, y] = 2;
                    str += "B";
                    str += "_|";
                }
                else if (turn == 1 && row == x && col == y && board[x, y] == 0)
                {
                    board[x, y] = 1;
                    str += "W";
                    str += "_|";
                }
                else if (board[x, y] == 0)
                {
                    str += "_";
                    str += "_|";
                }
                else if (board[x, y] == 2)
                {
                    str += "B";
                    str += "_|";
                }
                else if (board[x, y] == 1)
                {
                    str += "W";
                    str += "_|";
                }
            }
            Console.WriteLine(str);
        }
    }
    static void Count(int countblack, int countwhite, int countempty, int[,] board)
    {
        for (int x = 0; x < board.GetLength(0); x++)
        {
            for (int y = 0; y < board.GetLength(1); y++)
            {
                if (board[x, y] == 2)
                {
                    countblack++;
                }
                else if (board[x, y] == 1)
                {
                    countwhite++;
                }
                else if (board[x, y] == 0)
                {
                    countempty++;
                }
            }
        }
        Console.WriteLine("Black Disks: " + countblack + "   White Disks: " + countwhite);
    }
    static void Turn(string d, ref int row, ref int col, ref int turn, int size, int setboard, int[,] board, int countblack, int countwhite, int countempty)
    {
        turn = 2;

        Console.WriteLine("Black's Turn");
        Console.Write("Enter Row: ");
        d = Console.ReadLine();

        while (!int.TryParse(d, out row) || row < 0 || row > board.GetLength(1))
        {
            Console.WriteLine("Invalid Input");
            Console.WriteLine("Black's Turn");
            Console.Write("Enter Row: ");
            d = Console.ReadLine();
        }
        row = Convert.ToInt32(d);

        Console.Write("Enter Column: ");

        d = Console.ReadLine();

        while (!int.TryParse(d, out col) || col < 0 || col > board.GetLength(1))
        {
            Console.WriteLine("Invalid Input");
            Console.WriteLine("Black's Turn");
            Console.Write("Enter Column: ");
            d = Console.ReadLine();
        }
        col = Convert.ToInt32(d);

        ValidMove(d, ref row, ref col, board, size, setboard, ref turn);
        CheckHL(row, col, turn, ref board);
        CheckHR(row, col, turn, ref board);
        CheckVU(row, col, turn, ref board);
        CheckVD(row, col, turn, ref board);
        CheckDLU(row, col, turn, ref board);
        CheckDLD(row, col, turn, ref board);
        CheckDRU(row, col, turn, ref board);
        CheckDRD(row, col, turn, ref board);
        Board(size, setboard, row, col, ref turn, board);
        Count(countblack, countwhite, countempty, board);

        turn = 1;

        Console.WriteLine("White's Turn");
        Console.Write("Enter Row: ");
        d = Console.ReadLine();

        while (!int.TryParse(d, out row) || row < 0 || row > board.GetLength(1))
        {
            Console.WriteLine("Invalid Input");
            Console.WriteLine("White's Turn");
            Console.Write("Enter Row: ");
            d = Console.ReadLine();
        }
        row = Convert.ToInt32(d);

        Console.Write("Enter Column: ");
        d = Console.ReadLine();

        while (!int.TryParse(d, out col) || col < 0 || col > board.GetLength(1))
        {
            Console.WriteLine("Invalid Input");
            Console.WriteLine("White's Turn");
            Console.Write("Enter Column: ");
            d = Console.ReadLine();
        }
        col = Convert.ToInt32(d);

        ValidMove(d, ref row, ref col, board, size, setboard, ref turn);
        CheckHL(row, col, turn, ref board);
        CheckHR(row, col, turn, ref board);
        CheckVU(row, col, turn, ref board);
        CheckVD(row, col, turn, ref board);
        CheckDLU(row, col, turn, ref board);
        CheckDLD(row, col, turn, ref board);
        CheckDRU(row, col, turn, ref board);
        CheckDRD(row, col, turn, ref board);
        Board(size, setboard, row, col, ref turn, board);
        Count(countblack, countwhite, countempty, board);
    }
    static void ValidMove(string d, ref int row, ref int col, int[,] board, int size, int setboard, ref int turn)
    {
        for (int x = 0; x < board.GetLength(0); x++)
        {
            for (int y = 0; y < board.GetLength(1); y++)
            {
                while (turn == 2)
                {
                    if (row == x && col == y && board[x, y] > 0)
                    {
                        Board(size, setboard, row, col, ref turn, board);
                        Console.WriteLine("Position is Occupied");
                        Console.WriteLine("Black's Turn");
                        Console.Write("Enter Row: ");

                        d = Console.ReadLine();
                        row = Convert.ToInt32(d);

                        Console.Write("Enter Column: ");

                        d = Console.ReadLine();
                        col = Convert.ToInt32(d);
                    }
                    else
                    {
                        break;
                    }
                }
                while (turn == 1)
                {
                    if (row == x && col == y && board[x, y] > 0)
                    {
                        Board(size, setboard, row, col, ref turn, board);
                        Console.WriteLine("Position is Occupied");
                        Console.WriteLine("White's Turn");
                        Console.Write("Enter Row: ");

                        d = Console.ReadLine();
                        row = Convert.ToInt32(d);

                        Console.Write("Enter Column: ");

                        d = Console.ReadLine();
                        col = Convert.ToInt32(d);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
    static int Boardfill(int countempty, int[,] board, int blank)
    {
        for (int x = 0; x < board.GetLength(0); x++)
        {
            for (int y = 0; y < board.GetLength(1); y++)
            {
                if (board[x, y] == 0)
                {
                    countempty++;
                }
            }
        }
        if (countempty == 0)
        {
            countempty--;
        }
        if (countempty == -1)
        {
            return countempty;
        }
        else
        {
            return blank;
        }
    }
    static void CheckHL(int row, int col, int turn, ref int[,] board)
    {
        bool canChange = false;
        int toIndex = 0;

        for (int y = col - 1; y >= 0; y--)
        {
            if (board[row, y] == 0)
            {
                canChange = false;
                break;
            }
            else if (board[row, y] == turn)
            {
                toIndex = y;
                break;
            }
            else if (y == 0 && board[row, y] != turn)
            {
                canChange = false;
            }
            else
            {
                canChange = true;
            }
        }
        if (canChange)
        {
            for (int y = col - 1; y > toIndex; y--)
            {
                board[row, y] = turn;
            }
        }
    }
    static void CheckHR(int row, int col, int turn, ref int[,] board)
    {
        bool canChange = false;
        int toIndex = 0;

        for (int y = col + 1; y < board.GetLength(1); y++)
        {
            if (board[row, y] == 0)
            {
                canChange = false;
                break;
            }
            else if (board[row, y] == turn)
            {
                toIndex = y;
                break;
            }
            else
            {
                canChange = true;
            }
        }
        if (canChange)
        {
            for (int y = col + 1; y < toIndex; y++)
            {
                board[row, y] = turn;
            }
        }
    }
    static void CheckVU(int row, int col, int turn, ref int[,] board)
    {
        bool canChange = false;
        int toIndex = 0;

        for (int x = row - 1; x > 0; x--)
        {
            if (board[x, col] == 0)
            {
                canChange = false;
                break;
            }
            else if (board[x, col] == turn)
            {
                toIndex = x;
                break;
            }
            else
            {
                canChange = true;
            }
        }
        if (canChange)
        {
            for (int x = row - 1; x > toIndex; x--)
            {
                board[x, col] = turn;
            }
        }
    }
    static void CheckVD(int row, int col, int turn, ref int[,] board)
    {
        bool canChange = false;
        int toIndex = 0;

        for (int x = row + 1; x < board.GetLength(1); x++)
        {
            if (board[x, col] == 0)
            {
                canChange = false;
                break;
            }
            else if (board[x, col] == turn)
            {
                toIndex = x;
                break;
            }
            else
            {
                canChange = true;
            }
        }
        if (canChange)
        {
            for (int x = row + 1; x < toIndex; x++)
            {
                board[x, col] = turn;
            }
        }
    }
    static void CheckDLU(int row, int col, int turn, ref int[,] board)
    {
        bool canChange = false;
        int toIndex = 0, toIndex2 = 0;

        for (int x = row - 1, y = col - 1; x >= 0 && y >= 0; x--, y--)
        {
            if (board[x, y] == 0)
            {
                canChange = false;
                break;
            }
            else if (board[x, y] == turn)
            {
                toIndex = x;
                toIndex2 = y;
                break;
            }
            else
            {
                canChange = true;
            }
        }
        if (canChange)
        {
            for (int x = row - 1, y = col - 1; x > toIndex && y > toIndex2; x--, y--)
            {
                board[x, y] = turn;
            }
        }
    }
    static void CheckDLD(int row, int col, int turn, ref int[,] board)
    {
        bool canChange = false;
        int toIndex = 0, toIndex2 = 0;

        for (int x = row + 1, y = col - 1; x < board.GetLength(0) && y >= 0; x++, y--)
        {
            if (board[x, y] == 0)
            {
                canChange = false;
                break;
            }
            else if (board[x, y] == turn)
            {
                toIndex = x;
                toIndex2 = y;
                break;
            }
            else
            {
                canChange = true;
            }
        }
        if (canChange)
        {
            for (int x = row + 1, y = col - 1; x < toIndex && y > toIndex2; x++, y--)
            {
                board[x, y] = turn;
            }
        }
    }
    static void CheckDRU(int row, int col, int turn, ref int[,] board)
    {
        bool canChange = false;
        int toIndex = 0, toIndex2 = 0;

        for (int x = row - 1, y = col + 1; x >= 0 && y < board.GetLength(1); x--, y++)
        {
            if (board[x, y] == 0)
            {
                canChange = false;
                break;
            }
            else if (board[x, y] == turn)
            {
                toIndex = x;
                toIndex2 = y;
                break;
            }
            else
            {
                canChange = true;
            }
        }
        if (canChange)
        {
            for (int x = row - 1, y = col + 1; x > toIndex && y < toIndex2; x--, y++)
            {
                board[x, y] = turn;
            }
        }
    }
    static void CheckDRD(int row, int col, int turn, ref int[,] board)
    {
        bool canChange = false;
        int toIndex = 0, toIndex2 = 0;

        for (int x = row + 1, y = col + 1; x < board.GetLength(0) && y < board.GetLength(1); x++, y++)
        {
            if (board[x, y] == 0)
            {
                canChange = false;
                break;
            }
            else if (board[x, y] == turn)
            {
                toIndex = x;
                toIndex2 = y;
                break;
            }
            else if (y == 0 && x == 0 && board[x, y] != turn)
            {
                canChange = false;
            }
            else
            {
                canChange = true;
            }
        }
        if (canChange)
        {
            for (int x = row + 1, y = col + 1; x < toIndex && y < toIndex2; x++, y++)
            {
                board[x, y] = turn;
            }
        }
    }
}