namespace IntList
{
    class IntList
    {
        private int[] List;
        public int Count;

        public IntList()
        {
            List = new int[4];
            Count = 0;
        }

        public void Add(int number)
        {
            if (IsOutOfRange(Count + 1))
            {
                DoubleArray();
            }

            List[Count] = number;
            Count += 1;
        }

        public void Insert(int index, int number)
        {
            if (index >= Count)
            {
                DoubleArray();
                List[index] = number;
            }
            else
            {
                for (int i = Count; i > index; i--)
                {
                    List[i] = List[i - 1];
                }
                List[index] = number;
            }
            Count++;
        }

        public void RemoveAt(int index)
        {
            if (IsOutOfRange(index))
            {
                Console.WriteLine("Index is out of range!");
            }
            else
            {
                int[] newList = new int[List.Length];
                for (int i = 0; i < index; i++)
                {
                    newList[i] = List[i];
                }

                for (int i = index; i < List.Length - 1; i++)
                {
                    newList[i] = List[i + 1];
                }

                List = newList;
                List = newList;
            }
        }

        public int Get(int index)
        {
            if (IsOutOfRange(index))
            {
                Console.WriteLine("Index is Out of Range");
            }

            return List[index];
        }

        bool IsOutOfRange(int index)
        {
            return index > Count || index < 0;
        }

        void DoubleArray()
        {
            int[] newList = new int[List.Length * 2];
            for (int i = 0; i < List.Length; i++)
            {
                newList[i] = List[i];
            }

            List = newList;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            IntList list = new IntList();

            Console.WriteLine("new list count is - " + list.Count);

            list.Add(2);
            Console.WriteLine("After adding 2");
            PrintArray(list);

            Console.WriteLine("After adding 7");
            list.Add(7);
            PrintArray(list);

            Console.WriteLine("After inserting 8");
            list.Insert(0, 8);
            PrintArray(list);

            Console.WriteLine("After removing from 2");
            list.RemoveAt(2);
            PrintArray(list);


            Console.WriteLine("Getting 5th element " + list.Get(3));
        }


        static public void PrintArray(IntList list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list.Get(i) + " ");
            }
        }
    }
}
