using System.Xml.Serialization;

class Program
{
    public static void Main(string[] args)
    {
        GameManager.StartGame();

        Goblin goblin = new Goblin();

        Player player = new Player("Player", 0, 100, new List<Item>());
        Console.WriteLine("Your current stats:");

        player.DisplayPlayerStats(player);

        GameManager.InitiateCombat(goblin);
    }
}