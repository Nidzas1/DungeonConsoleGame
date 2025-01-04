public class SafeRoom : Room
{
    public SafeRoom(string name) : base(name)
    {

    }

    public override void DisplayRoomInfo()
    {
        Console.WriteLine("You are currently in a safe room.");
        Console.WriteLine("What would you like to do?");

        Console.WriteLine("1: Change spell");
        Console.WriteLine("2: Open the safe.");
        Console.WriteLine("3: Go to next room.");

        Choice(Convert.ToInt32(Console.ReadLine()));
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
                Console.WriteLine("Safe");
                GameManager.MoveToRoom(new DangerRoom("Safe"));
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
}