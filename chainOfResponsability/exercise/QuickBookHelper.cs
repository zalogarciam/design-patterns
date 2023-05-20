public class QuickBookHelper : DataHandler
{
    public QuickBookHelper(DataHandler next) : base(next)
    {
    }

    public override bool DoHandle(DataRequest request)
    {
        if (request.FileName.Contains(".qbw"))
        {
            Console.WriteLine("Reading data from a QuickBooks file.");
        }
        return false;
    }
}