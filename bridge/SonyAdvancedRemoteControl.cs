public class SonyAdvancedRemoteControl : AdvancedRemoteControl
{
    public override void SetChannel(int number)
    {
        System.Console.WriteLine("Sony: set channel: " + number);

    }
    public override void TurnOn()
    {
        System.Console.WriteLine("Sony: turn on");
    }

    public override void TurnOff()
    {
        System.Console.WriteLine("Sony: turn off");
    }
}