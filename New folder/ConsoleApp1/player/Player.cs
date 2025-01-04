using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

public class Player
{
    public string Name { get; private set; }
    public int Score { get; set; }
    public int Health { get; set; }
    public List<Item> Inventory { get; private set; }
    public enum SpecialAbility
    {
        Fireball,
        LightningStrike,
        IceBolt
    };

    private readonly Dictionary<SpecialAbility, int> _specialAbilities = new Dictionary<SpecialAbility, int>(){
        { SpecialAbility.Fireball, 15 },
        { SpecialAbility.LightningStrike, 5 },
        { SpecialAbility.IceBolt, 10 }
    };

    public Player(string name, int score = 0, int health = 100, List<Item> inventory = null)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name), "Name cannot be null");
        Score = score;
        Health = health >= 0 ? health : throw new ArgumentOutOfRangeException(nameof(health), "Health cannot be negative");
        Inventory = inventory ?? new List<Item>();

    }
    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }
    public void RemoveItem(Item item)
    {
        Inventory.Remove(item);
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Health = 0;
            Console.WriteLine("You died!");
        }
    }
    public void Heal(int amount)
    {
        Health += amount;
        if (Health > 100)
        {
            Health = 100;
        }
    }
    public void DisplayPlayerStats(Player player)
    {
        Console.WriteLine($"Name: {player.Name}");
        Console.WriteLine($"Score: {player.Score}");
        Console.WriteLine($"Health: {player.Health}");
        Console.WriteLine(player.Inventory.Count > 0 ? $"Inventory: {string.Join(", ", player.Inventory)}" : "Inventory: No items");
    }

    public static int UseSpecialAbility(SpecialAbility specialAbility, Player player)
    {
        if (player._specialAbilities.TryGetValue(specialAbility, out int cost))
        {
            if (player.Score >= cost)
            {
                player.Score -= cost;
                Console.WriteLine($"Used {specialAbility}!");
            }
            else
            {
                Console.WriteLine($"Not enough score to use {specialAbility}!");
            }
        }
        else
        {
            Console.WriteLine($"Unknown special ability: {specialAbility}");
        }
        return player._specialAbilities.GetValueOrDefault(specialAbility, 0);
    }
}