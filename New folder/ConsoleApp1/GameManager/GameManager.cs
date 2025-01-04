
public class GameManager
{
    public static void StartGame()
    {
        Console.WriteLine("Game started!");
    }

    public static void MoveToRoom(Room room)
    {
        room.DisplayRoomInfo();
    }
    public static void InitiateCombat(Enemy enemy)
    {
        Console.WriteLine("Combat started!");
        Console.WriteLine("Enemy: " + enemy);

        while (enemy.Health > 0)
        {
            Console.WriteLine("What would you like to do?");

            Console.WriteLine("1: Attack");
            Console.WriteLine("2: Cast a spell");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("You attacked the enemy!");
                enemy.TakeDamage(10);
            }
            if (choice == 2)
            {
                Console.WriteLine("You cast a spell!");
                enemy.TakeDamage(20);
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }
    }
}