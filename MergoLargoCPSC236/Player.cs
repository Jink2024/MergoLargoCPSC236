public class Player
{
    // TODO: branches will replace these 0 placeholders
    public float MoveSpeed = 420f;
    public float JumpForce = 67f;

    public void Move(float horizontal)
    {
        Console.WriteLine($"Moving at speed {MoveSpeed}, input: {horizontal}");
    }
}