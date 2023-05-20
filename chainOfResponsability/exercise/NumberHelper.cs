public class NumberHelper : DataHandler
{
    public NumberHelper(DataHandler next) : base(next)
    {
    }

    public override bool DoHandle(DataRequest request)
    {
        if (request.FileName.Contains(".numbers"))
        {
            Console.WriteLine("Reading data from a Numbers spreadsheet.");
        }
        return false;
    }
}