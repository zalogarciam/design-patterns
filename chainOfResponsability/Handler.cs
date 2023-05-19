public abstract class Handler
{
    private Handler Next;
    public Handler(Handler next)
    {
        this.Next = next;
    }

    public void Handle(HttpRequest request)
    {
        if (DoHandle(request))
            return; 
        if (Next!= null)
            Next.Handle(request);
    }
    public abstract bool DoHandle(HttpRequest request);
}