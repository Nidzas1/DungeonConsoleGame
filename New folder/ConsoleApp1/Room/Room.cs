public abstract class Room
{
    public string Name { get; set; }

    public Room(string name)
    {
        Name = name;
    }
    public abstract void DisplayRoomInfo();
    public abstract void Choice(int choice);
}