using System.Data;

namespace BestAttempt
{
    struct Attempt
    {
        public int Score;
        public int Day;

        public Attempt(int score, int day)
        {
            this.Score = score;
            this.Day = day;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Attempt[][] attemptsArray =  {
                new Attempt[] { new Attempt(90, 1) },
                new Attempt[] { new Attempt(85, 2), new Attempt(70, 3), new Attempt(85, 1) }
            };

            Attempt[] res = BestAttempt(attemptsArray);
            PrintBestAttempts(res);
        }

        static Attempt[] BestAttempt(Attempt[][] array)
        {
            int rows = array.GetLength(0);
            Attempt[] result = new Attempt[rows];

            for (int rowIndex = 0; rowIndex < rows; ++rowIndex)
            {
                Attempt bestAttemptOfRow = array[rowIndex][0];
                for (int columnIndex = 1; columnIndex < array[rowIndex].Length; ++columnIndex)
                {
                    Attempt currentAttempt = array[rowIndex][columnIndex];
                    if (currentAttempt.Score > bestAttemptOfRow.Score)
                    {
                        bestAttemptOfRow = currentAttempt;
                    }
                    else if (currentAttempt.Score == bestAttemptOfRow.Score && currentAttempt.Day < bestAttemptOfRow.Day)
                    {
                        bestAttemptOfRow = currentAttempt;
                    }

                }
                result[rowIndex] = bestAttemptOfRow;
            }

            return result;
        }


        static void PrintBestAttempts(Attempt[] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write("Score " + array[i].Score + " Day " + array[i].Day + " ");
            }
        }
    }
}
