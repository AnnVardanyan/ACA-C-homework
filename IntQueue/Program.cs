namespace IntQueue
{
    //FIFO First In First Out
    public class IntQueue
    {
        private int[] array;
        public int Count { get; private set; }
        private const int DefaultCapacity = 4;
        public int Capacity => array.Length;

        public IntQueue()
        {
            Count = 0;
            array = new int[DefaultCapacity];
        }

        public void Enqueue(int value)
        {
            EnsureCapacity(Count + 1);
            array[Count] = value;
            Count++;
        }

        public int Dequeue()
        {
            for (int i = 0; i < Count - 1; i++)
            {
                array[i] = array[i + 1];
            }

            Count--;
            array[Count] = 0;

            return 0;
        }

        public int? get(int index)
        {
            if (index < 0 || index > Count)
            {
                return null;
            }
            else
            {
                return array[index];
            }
        }
        private void EnsureCapacity(int minCapacity)
        {
            if (Capacity >= minCapacity)
                return;

            int newCapacity = Capacity == 0 ? DefaultCapacity : Capacity * 2;

            while (newCapacity < minCapacity)
            {
                if (newCapacity > int.MaxValue / 2)
                {
                    newCapacity = minCapacity;
                    break;
                }

                newCapacity *= 2;
            }

            int[] newItems = new int[newCapacity];
            for (int i = 0; i < Count; i++)
            {
                newItems[i] = array[i];
            }

            array = newItems;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IntQueue queue = new IntQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            for (int i = 0; i <= queue.Capacity; i++)
            {
                Console.Write(queue.get(i) + " ");
            }
        }
    }
}
