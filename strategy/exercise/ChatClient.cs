public class ChatClient
{
    private IEncryptionAlgorithm EncryptionAlgorithm;
    public ChatClient(IEncryptionAlgorithm encryptionAlgorithm)
    {
        this.EncryptionAlgorithm = encryptionAlgorithm;
    }

    public void Send(String message)
    {
        this.EncryptionAlgorithm.Encrypt();
    }
}
