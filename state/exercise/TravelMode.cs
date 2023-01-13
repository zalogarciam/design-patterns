public class TravelMode
{
    IDirectionService _service;
    public TravelMode(IDirectionService service)
    {
        _service = service;
    }

    public void GetDirection()
    {
        _service.GetDirection();
    }

    public void GetETA()
    {
        _service.GetETA();
    }
}