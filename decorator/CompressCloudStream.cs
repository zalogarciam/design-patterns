public class CompressCloudStream : IStream
{
    private IStream stream;

    public CompressCloudStream(IStream stream)
    {
        this.stream = stream;
    }

    public void write(string data)
    {
        var compressed = compress(data);
        stream.write(compressed);
    }

    private String compress(String data)
    {
        return data.Substring(0, 5);
    }
}