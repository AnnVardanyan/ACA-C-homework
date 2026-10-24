using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IntStack
{
    // LIFO Last In First Out
    public class IntStack
    {
        private int[] array;
        private const int DefaultCapacity = 4;
        public int Capacity => array.Length;
        public int Count { get; private set; }

        public IntStack()
        {
            Count = 0;
            array = new int[DefaultCapacity];
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

        public void Push(int value)
        {
            EnsureCapacity(Count + 1);
            array[Count] = value;
            Count++;
        }

        public int Pop()
        {
            array[Count - 1] = 0;
            return Count--;
        }

        public int Peek()
        {
            return array[Count - 1];
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
            IntStack stack = new IntStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();

            for (int i = 0; i < stack.Capacity; i++)
            {
                Console.Write(stack.get(i) + " ");
            }

        }
    }
}
