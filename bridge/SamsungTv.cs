public class SamsungTV : IDevice
{
    public void TurnOn()
    {
        System.Console.WriteLine("Samsung: turn on");
    }

    public void TurnOff()
    {
        System.Console.WriteLine("Samsung: turn off");
    }

    public void SetChannel(int number)
    {
        System.Console.WriteLine("Samsung: set channel");
    }
}