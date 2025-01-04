public class Item
{
    public string Name { get; set; }
    public int Cost { get; set; }
    public ItemType Type { get; set; }

    public enum ItemType
    {
        Sword,
        Armor
    }

    public Item(string name, int cost, ItemType type)
    {
        Name = name;
        Cost = cost;
        Type = type;
    }
}