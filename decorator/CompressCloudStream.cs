public class CompressCloudStream : CloudStream
{

    public override void write(string data)
    {
        var compressed = compress(data);
        base.write(data);
    }

    private String compress(String data)
    {
        return data.Substring(0, 5);
    }
}