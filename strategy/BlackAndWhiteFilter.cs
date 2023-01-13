public class BlackAndWhiteFilter : IFilter
{
    public void Apply(string fileName)
    {
        Console.WriteLine("Apply " + fileName + " Black and White");
    }
}