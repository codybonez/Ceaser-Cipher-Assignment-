namespace Ceaser_Cipher_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cipher cipher = new Cipher();
            cipher.CeaserCipherEncryptFoward(5, "Joe");
            cipher.CeaserCipherEncryptBackward(-5, "Joe");
        }
    }
}
