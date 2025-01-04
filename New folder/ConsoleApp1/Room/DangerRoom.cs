public class DangerRoom : Room
{

    public DangerRoom(string name) : base(name)
    {

    }

    public override void Choice(int choice)
    {
        switch (choice)
        {
            case 1:
                Console.WriteLine("Safe");
                GameManager.MoveToRoom(new SafeRoom("SafeRoom"));
                break;
            case 2:
                Console.WriteLine("DangerRoom");
                GameManager.MoveToRoom(new DangerRoom("DangeRoom"));
                break;
            case 3:
                Console.WriteLine("DangerRoom");
                GameManager.MoveToRoom(new SafeRoom("DangerRoom"));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    public override void DisplayRoomInfo()
    {
        Console.WriteLine("You are currently in a Danger room.");
        Console.WriteLine("What would you like to do?");

        GameManager.InitiateCombat(new Goblin());



    }
}