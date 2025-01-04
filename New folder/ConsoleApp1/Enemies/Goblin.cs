public class Goblin : Enemy
{

    public string Name { get; private set; }
    public int Health { get; private set; }
    public int Damage { get; private set; }

    public Goblin()
    {
        Name = "Goblin";
        Health = 20;
        Damage = 5;
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;

        Console.WriteLine($"{Name} took {damage} damage, {Health} health remaining.");

        if (Health <= 0)
        {
            Console.WriteLine($"{Name} is dead.");
            GameManager.MoveToRoom(new SafeRoom("SafeRoom"));
        }
    }
}