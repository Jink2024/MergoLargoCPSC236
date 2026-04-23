public class EnemyAi
{
    public float DetectionRadius = 15f;
    public float PatrolSpeed = 3f;

    public void Patrol()
    {
        Console.WriteLine($"Patrolling at speed {PatrolSpeed}");
    }
}