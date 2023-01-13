public class ChatClient
{
    private String EncryptionAlgorithm;

    public ChatClient(String encryptionAlgorithm)
    {
        this.EncryptionAlgorithm = encryptionAlgorithm;
    }

    public void send(String message)
    {
        if (EncryptionAlgorithm == "DES")
            Console.WriteLine("Encrypting message using DES");
        else if (EncryptionAlgorithm == "AES")
            Console.WriteLine("Encrypting message using AES");
        else
            throw new Exception("Unsupported encryption algorithm");

        Console.WriteLine("Sending the encrypted message...");
    }
}
