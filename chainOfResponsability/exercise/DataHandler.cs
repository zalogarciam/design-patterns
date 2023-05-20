public abstract class DataHandler
{
    private DataHandler Next;
    public DataHandler(DataHandler next)
    {
        this.Next = next;
    }

    public void Handle(DataRequest request)
    {
        if (DoHandle(request))
            return; 
        if (Next!= null)
            Next.Handle(request);
    }
    public abstract bool DoHandle(DataRequest request);
}