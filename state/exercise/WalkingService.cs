public class WalkingService : IDirectionService
{
    public void GetDirection()
    {
        Console.WriteLine("Calculating Direction while WalkingService");
    }

    public void GetETA()
    {
        Console.WriteLine("Calculating ETA while WalkingService");
    }
}