public class Ui
{
    public float ScoreMultiplier = 1776f;

    public void DisplayScore(int score)
    {
        Console.WriteLine($"Score: {score * ScoreMultiplier}");
    }
}