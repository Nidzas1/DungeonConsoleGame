public class Sword : Item
{
    public int Damage { get; set; }
    public Sword(string name, int cost, int damage) : base(name, cost, ItemType.Sword)
    {
        this.Damage = damage;
    }
}