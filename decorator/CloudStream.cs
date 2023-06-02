public class CloudStream : IStream
{
    public void write(String data)
    {
        System.Console.WriteLine("Storing..." + data);
    }
}