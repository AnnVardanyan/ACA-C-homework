namespace ColdWorkingSensors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int columns = 3;
            int rows = 3;

            int[,] board = new int[rows, columns];

            Console.WriteLine("Player A sign select: ");
            var playerASign = Console.ReadLine();

            Console.WriteLine("Player B sign select: ");
            var playerBSign = Console.ReadLine();

            
            drawBoard(board);

        }

        static void drawBoard(int[,] board)
        {
            for(int rowIndex = 0; rowIndex < board.GetLength(0); ++rowIndex )
            {
                for(int columnIndex = 0; columnIndex < board.GetLength(1); ++columnIndex)
                {
                    string sign = board[rowIndex, columnIndex] == 1 ? "x" : board[rowIndex, columnIndex] == 2 ? "o" : "_";
                    Console.Write(sign + " ");
                }
                    Console.WriteLine();
            }
        }

        static bool checkRowWin()
        { }

        static bool checkColumnWin()
        { }

        static bool checkDiagonalWin()
        { }
    }
}
