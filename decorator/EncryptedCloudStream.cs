public class EncryptedCloudStream : CloudStream
{
    public override void write(String data)
    {
        var encrypted = encrypt(data);
        base.write(encrypted);
    }
    private String encrypt(String data)
    {
        return "sad231$^&sa";
    }
}