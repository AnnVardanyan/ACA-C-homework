namespace Delegates
{
    internal class Program
    {
        public delegate int Op(int value);

        static public int Apply(Op fn, int val )
        {
            return fn(val);
        }

        static public int Pick(Op fnForOdds, Op fnForEvens, int value)
        {
            if (value % 2 == 0) return fnForEvens(value);
            else return fnForOdds(value);
        }

        static public int Double(int value)
        {
            return value * 2;
        }

        static public int PlusTen(int value)
        {
            return value + 10;
        }

        static void Main(string[] args)
        {
            //Call
            Op op = Double;
            int result1 = op(20);
            Console.WriteLine("result1: ", result1);

            op = PlusTen;
            int result2 = op(14);
            Console.WriteLine("result2: ", result2);

            //Pass it
            int result3 = Apply(PlusTen, 5);
            int result4 = Apply(Double, 4);
            Console.WriteLine("Apply 5 to PlusTen " + result3);
            Console.WriteLine("Apply 4 to Double " + result4);

            //Pick
            int result5 = Pick(PlusTen, Double, 3);
            int result6 = Pick(PlusTen, Double, 4);
            Console.WriteLine("Pick 3 " + result5);
            Console.WriteLine("Pick 4 " + result6);
        }
    }
}
