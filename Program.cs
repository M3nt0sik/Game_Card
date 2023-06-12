using Game_Card;


internal class Program
{
    public static Random random = new Random();
    private static void Main(string[] args)
    {
        Card myCard = new Card((EValue)random.Next(1,14), (ESuit)random.Next(0,4));
        Console.WriteLine(myCard.Name);
    }
}