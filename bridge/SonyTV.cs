public class SonyTV : IDevice
{
    public void TurnOn()
    {
        System.Console.WriteLine("Sony: turn on");
    }

    public void TurnOff()
    {
        System.Console.WriteLine("Sony: turn off");
    }

    public void SetChannel(int number)
    {
        System.Console.WriteLine("Sony: set channel");
    }
}