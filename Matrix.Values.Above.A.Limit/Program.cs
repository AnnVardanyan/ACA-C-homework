namespace Matrix.Values.Above.A.Limit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 0, 2, 8 }, { 1, 6, 10 } };
            int[] arr = Above(matrix, 20);
            PrintArray(arr);
        }


        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write(array[i] + " ");
            }
        }

        static int[] Above(int[,] matrix, int limit)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int resultArrayLength = 0;

            for(int rowIndex = 0; rowIndex < rows; ++rowIndex)
            {
                for(int columnIndex = 0; columnIndex < columns; ++columnIndex)
                {
                    if (matrix[rowIndex, columnIndex] > limit)
                    {
                        ++resultArrayLength;
                    }
                }
            }

            if (resultArrayLength == 0) return new int[0];

            int[] result = new int[resultArrayLength];
            int resultCurrentIndex = 0;

            for (int rowIndex = 0; rowIndex < rows; ++rowIndex)
            {
                for (int columnIndex = 0; columnIndex < columns; ++columnIndex)
                {
                    if (matrix[rowIndex, columnIndex] > limit)
                    {
                        result[resultCurrentIndex++] = matrix[rowIndex, columnIndex];
                    }
                }
            }

            return result;
        }
    }
}
