public class RemoteControl
{
    // RemoteControl
    // - SonyRemoteControl
    // - SamsungRemoteControl
    // - AdvancedRemoteControl
    // -- SonyAdvancedRemoteControl
    // -- SamsungAdvancedRemoteControl

    protected IDevice Device;

    public RemoteControl(IDevice device)
    {
        Device = device;
    }

    public void TurnOn()
    {
        Device.TurnOn();
    }
    public void TurnOff()
    {
        Device.TurnOff();
    }
}