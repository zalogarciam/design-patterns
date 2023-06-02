public class EncryptedCloudStream : IStream
{
    private IStream stream;

    public EncryptedCloudStream(IStream stream)
    {
        this.stream = stream;
    }

    public void write(String data)
    {
        var encrypted = encrypt(data);
        stream.write(encrypted);
    }
    private String encrypt(String data)
    {
        return "sad231$^&sa";
    }
}