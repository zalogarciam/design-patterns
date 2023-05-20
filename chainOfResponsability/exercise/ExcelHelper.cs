public class ExcelHelper : DataHandler
{
    public ExcelHelper(DataHandler next) : base(next)
    {
    }

    public override bool DoHandle(DataRequest request)
    {
        if (request.FileName.Contains(".xls"))
        {
            Console.WriteLine("Reading data from an Excel spreadsheet.");
        }
        return false;
    }
}