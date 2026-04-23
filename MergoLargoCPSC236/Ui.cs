public class Ui
{
    public float ScoreMultiplier = 69f;

    public void DisplayScore(int score)
    {
        Console.WriteLine($"Score: {score * ScoreMultiplier}");
    }
}