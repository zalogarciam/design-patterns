
public class DataReader
{
    private DataHandler Handler;

    public DataReader(DataHandler handler)
    {
        Handler = handler;
    }

    public void Handle(DataRequest request)
    {
        Handler.Handle(request);
    }
}
