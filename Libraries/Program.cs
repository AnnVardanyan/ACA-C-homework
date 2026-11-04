namespace Libraries
{
    internal class Program
    {
        static int visitorsCount = 0;

        static public void Desk(string name)
        {
            visitorsCount++;
            Console.WriteLine($"{visitorsCount} {name}");
        }

        static public void Chime(string name)
        {
            Console.WriteLine($"chime {name}");
        }

        static public void Hold(string name)
        {
            Console.WriteLine($"hold {name}");
        }

        static public void Slip(string name)
        {
            Console.WriteLine($"slip {name}");
        }
        static public void Card(string name)
        {
            Console.WriteLine($"card {name}");
        }


        static void Main(string[] args)
        {
            Library lib = new Library();
            lib.Subscribe(Chime);
            lib.Subscribe(Desk);
            lib.SubscribeOnce(Slip);
            lib.SubscribeOnce(Card);

            lib.Enter("Ana");
            lib.Enter("Leo");

            lib.UnSubscribe(Desk);
            lib.SubscribeOnce(Hold);

            lib.Enter("Mia");
        }
    }
}
